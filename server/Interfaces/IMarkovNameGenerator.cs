using Solace.Models;

namespace Solace.Interfaces;

public interface IMarkovNameGenerator
{
    Task<Result<string>> GenerateName();
}