using System.Collections.Concurrent;
using System.Text;
using Solace.Interfaces;
using Solace.Models;

public sealed class MarkovNameGenerator : IMarkovNameGenerator
{
    private const char Start = '^';
    private const char End = '\0';
    private const int Order = 4;

    private sealed class Model
    {
        public Dictionary<string, List<char>> Transitions = new();
        public HashSet<string> Known = new(StringComparer.OrdinalIgnoreCase);
    }

    private readonly ConcurrentDictionary<string, Model> _models = new();

    public Task<Result<List<string>>> GenerateName(int count)
    {
        var model = _models.GetOrAdd("data/namesList.csv", Train);
        var results = new List<string>();

        for (int i = 0; i < count; i++)
            results.Add(Generate(model));

        return Task.FromResult(Result<List<string>>.Success(results));
    }

    public Task<Result<List<string>>> GenerateCityName(int count)
    {
        var model = _models.GetOrAdd("data/cities.csv", Train);
        var results = new List<string>();

        for (int i = 0; i < count; i++)
        {
            results.Add(Generate(model));
        }

        return Task.FromResult(Result<List<string>>.Success(results));
    }

    private static Model Train(string file)
    {
        var model = new Model();
        var names = File.ReadLines(file).Skip(1).Select(l => l.Split(',')[0]);

        foreach (var raw in names)
        {
            var name = raw.Trim().ToLowerInvariant();
            if (name.Length < 2) continue;

            model.Known.Add(name);

            var padded = new string(Start, Order) + name;

            for (int i = 0; i <= name.Length; i++)
            {
                var context = padded.Substring(i, Order);
                var next = i < name.Length ? padded[i + Order] : End;

                if (!model.Transitions.TryGetValue(context, out var list))
                    model.Transitions[context] = list = new List<char>();

                list.Add(next);
            }
        }

        if (model.Transitions.Count == 0)
            throw new ArgumentException($"No usable names in {file}.");

        return model;
    }

    private static string Generate(Model model, int minLength = 3, int maxLength = 12, bool allowExisting = false)
    {
        var rng = Random.Shared;

        for (int attempt = 0; attempt < 100; attempt++)
        {
            var sb = new StringBuilder();
            var context = new string(Start, Order);
            var ended = false;

            while (sb.Length < maxLength)
            {
                var options = model.Transitions[context];
                var next = options[rng.Next(options.Count)];

                if (next == End) { ended = true; break; }

                sb.Append(next);
                context = context[1..] + next;
            }

            if (!ended || sb.Length < minLength) continue;

            var name = sb.ToString();
            if (!allowExisting && model.Known.Contains(name)) continue;

            return char.ToUpperInvariant(name[0]) + name[1..];
        }

        throw new InvalidOperationException("Could not generate a name within the constraints.");
    }
}