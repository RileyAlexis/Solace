using Solace.Models;

namespace Solace.Interfaces;

public interface IBuildingNameGenerator
{
    Task<Result<List<string>>> GenerateTavernName(int count = 1);
}