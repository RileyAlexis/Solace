using System.Text;
using Solace.Interfaces;
using Solace.Models;

public sealed class MarkovNameGenerator : IMarkovNameGenerator
{
    private const char Start = '^';
    private const char End = '\0';

    private readonly int _order;
    private readonly Dictionary<string, List<char>> _transitions = new();
    private readonly HashSet<string> _known = new(StringComparer.OrdinalIgnoreCase);

    public MarkovNameGenerator(IEnumerable<string> names, int order = 3)
    {
        _order = order;

        foreach (var raw in names)
        {
            var name = raw.Trim().ToLowerInvariant();
            if (name.Length < 2) continue;

            _known.Add(name);

            var padded = new string(Start, order) + name;

            for (int i = 0; i <= name.Length; i++)
            {
                var context = padded.Substring(i, order);
                var next = i < name.Length ? padded[i + order] : End;

                if (!_transitions.TryGetValue(context, out var list))
                    _transitions[context] = list = new List<char>();

                list.Add(next);
            }
        }

        if (_transitions.Count == 0)
            throw new ArgumentException("No usable names supplied.", nameof(names));
    }

    private string Generate(int minLength = 3, int maxLength = 12, bool allowExisting = false, Random? rng = null)
    {
        rng ??= Random.Shared;

        for (int attempt = 0; attempt < 100; attempt++)
        {
            var sb = new StringBuilder();
            var context = new string(Start, _order);
            var ended = false;

            while (sb.Length < maxLength)
            {
                var options = _transitions[context];
                var next = options[rng.Next(options.Count)];

                if (next == End) { ended = true; break; }

                sb.Append(next);
                context = context[1..] + next;
            }

            if (!ended || sb.Length < minLength) continue;

            var name = sb.ToString();
            if (!allowExisting && _known.Contains(name)) continue;

            return char.ToUpperInvariant(name[0]) + name[1..];
        }

        throw new InvalidOperationException("Could not generate a name within the constraints.");
    }

    public Task<Result<string>> GenerateName()
    {
        return Task.FromResult(Result<string>.Success(Generate()));
    }
}