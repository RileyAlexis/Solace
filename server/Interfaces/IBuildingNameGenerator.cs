using Solace.Models;

namespace Solace.Interfaces;

public interface IBuildingNameGenerator
{
    Task<Result<List<string>>> GenerateTavernName(int count = 1);
    Task<Result<List<string>>> GeneratePatternName(string category, int count = 1);
    string GetColorName();
}