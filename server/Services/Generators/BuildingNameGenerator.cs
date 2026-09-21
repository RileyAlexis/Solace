using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Solace.Database;
using Solace.Interfaces;
using Solace.Models;

namespace Solace.Services.Generators;

public class BuildingNameGenerator(SolaceDbContext db) : IBuildingNameGenerator
{
    private enum WordType { Adjective, Noun }
    private readonly SolaceDbContext _db = db;

    private struct NamePattern
    {
        public List<WordType> Sequence;
        public double Weight; // Allows weighting specific patterns if desired (e.g., make "Adj-Noun" more common)

        public NamePattern(List<WordType> sequence, double weight = 1.0)
        {
            Sequence = sequence;
            Weight = weight;
        }
    }

    private static readonly List<NamePattern> Patterns = new List<NamePattern>
    {
        // --------------------------------------------
        // GROUP A: CORE IDENTIFIERS (High Chance, Simple, Classic)
        // These are the most natural-sounding titles.
        // --------------------------------------------
        new NamePattern(new List<WordType> { WordType.Adjective, WordType.Noun }),           // Example: Silent Citadel
        // new NamePattern(new List<WordType> { WordType.Noun, WordType.Adjective }),         // Example: Grove-Kept Lore

        // --------------------------------------------
        // GROUP B: LORE & DESCRIPTION (Medium Chance, Flowing)
        // These combine a descriptor with two nouns to feel deep and rich.
        // --------------------------------------------
        new NamePattern(new List<WordType> { WordType.Adjective, WordType.Noun, WordType.Noun }), // Example: Spectral Wyrm Covenant (The most reliable pattern)
        // new NamePattern(new List<WordType> { WordType.Noun, WordType.Noun, WordType.Noun }),     // Example: Wyvern Citadel Archive (Stacking nouns for maximum impact)

        // --------------------------------------------
        // GROUP C: ACADEMIC & GOVERNANCE (Low Chance, Formal/Grand)
        // These patterns build titles to sound like official institutions.
        // --------------------------------------------
        // new NamePattern(new List<WordType> { WordType.Adjective, WordType.Noun, WordType.Adjective }), // Example: Eldritch Crimson Order (Adj-Noun-Adj)
        // new NamePattern(new List<WordType> { WordType.Noun, WordType.Adjective, WordType.Adjective }),   // Example: Citadel Radiant Sovereign (N-Adj-Adj)
    };


    private static string GetRandomWord(WordType type, List<string> adjectives, List<string> nouns)
    {
        Random rand = new Random();
        List<string> array;
        switch (type)
        {
            case WordType.Adjective:
                array = adjectives;
                break;
            case WordType.Noun:
                array = nouns;
                break;
            default:
                return "unknown";
        }

        int randomIndex = rand.Next(0, array.Count);
        return array[randomIndex];
    }

    public async Task<Result<List<string>>> GeneratePatternName(string category, int count = 1)
    {

        var normalized = category.ToLower();

        var result = await _db.BuildingDefinitions
            .Where(l => l.Name.ToLower() == normalized)
            .FirstOrDefaultAsync();

        if (result is null)
        {
            var validCategories = await _db.BuildingDefinitions
                .Select(b => b.Name)
                .ToListAsync();

            return Result<List<string>>.Failure(
                $"Category not found. Valid categories: {string.Join(", ", validCategories)}",
                ErrorType.NotFound);
        }

        var adjectives = File.ReadLines("data/adjectives_solace.csv")
            .Select(l => l.Split(',')[0])
            .ToList();


        var nouns = File.ReadLines("data/nouns_solace.csv")
            .Select(l => l.Split(','))
            .Where(c => c.Length > 1 && c[1].Trim().Equals(category, StringComparison.OrdinalIgnoreCase))
            .Select(c => c[0])
            .ToList();

        var namesList = new List<string>();

        for (int i = 0; i < count; i++)
        {
            Random rand = new Random();
            double totalWeight = Patterns.Sum(p => p.Weight);
            double roll = rand.NextDouble() * totalWeight;

            var selectedPattern = Patterns[^1];
            double cumulativeWeight = 0;

            foreach (var pattern in Patterns)
            {
                cumulativeWeight += pattern.Weight;
                if (roll <= cumulativeWeight)
                {
                    selectedPattern = pattern;
                    break;
                }
            }

            List<string> wordList = new List<string>();

            foreach (var type in selectedPattern.Sequence)
            {
                string word = GetRandomWord(type, adjectives, nouns);
                wordList.Add(word);
            }

            namesList.Add(CultureInfo.InvariantCulture.TextInfo.ToTitleCase("The " + string.Join(" ", wordList)));
        }

        return Result<List<string>>.Success(namesList);
    }

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
            int flip = Random.Shared.Next(2);
            if (flip == 0)
            {
                var adjective = adjectives[Random.Shared.Next(adjectives.Count)];
                var noun = nouns[Random.Shared.Next(nouns.Count)];
                results.Add(CultureInfo.InvariantCulture.TextInfo.ToTitleCase($"The {adjective} {noun}"));

            }
            else
            {
                var color = GetColorName();
                var noun = nouns[Random.Shared.Next(nouns.Count)];
                results.Add(CultureInfo.InvariantCulture.TextInfo.ToTitleCase($"The {color} {noun}"));
            }
        }

        return Task.FromResult(Result<List<string>>.Success(results));
    }

    public string GetColorName()
    {
        var colors = File.ReadLines("data/color_names.csv")
            .Skip(1)
            .Select(l => l.Split(',')[0]).ToList();

        return colors[Random.Shared.Next(colors.Count)];
    }
}