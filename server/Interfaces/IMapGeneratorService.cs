using Solace.Models;

namespace Solace.Interfaces;

public interface IMapGeneratorService
{
    Task<Result> GenerateNewMap(int population, int difficulty);
}