using Solace.Models;

namespace Solace.Interfaces;

public interface IMarkovNameGenerator
{
    Task<Result<List<string>>> GenerateName(int count = 1);
    Task<Result<List<string>>> GenerateCityName(int count = 1);
}