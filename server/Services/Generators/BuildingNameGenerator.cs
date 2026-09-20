using System.Globalization;
using Solace.Interfaces;
using Solace.Models;

namespace Solace.Services.Generators;

public class BuildingNameGenerator : IBuildingNameGenerator
{
    public Task<Result<List<string>>> GenerateTavernName(int count = 1)
    {
        var adjectives = File.ReadLines("data/adjectives.csv")
            .Skip(1)
            .Select(l => l.Split(',')[0]).ToList();
        var nouns = File.ReadLines("data/nouns.csv")
            .Skip(1)
            .Select(l => l.Split(',')[0]).ToList();

        var results = new List<string>();

        for (int i = 0; i < count; i++)
        {
            var adjective = adjectives[Random.Shared.Next(adjectives.Count)];
            var noun = nouns[Random.Shared.Next(nouns.Count)];

            results.Add(CultureInfo.InvariantCulture.TextInfo.ToTitleCase($"The {adjective} {noun}"));
        }

        return Task.FromResult(Result<List<string>>.Success(results));
    }
}