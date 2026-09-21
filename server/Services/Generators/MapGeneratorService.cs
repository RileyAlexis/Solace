using Solace.Database;
using Solace.Interfaces;
using Solace.Models;

namespace Solace.Services.Generators;

public class MapGenerator(SolaceDbContext db) : IMapGeneratorService
{
    private readonly SolaceDbContext _db = db;

    public Task<Result> GenerateNewMap(int population, int difficulty)
    {
        throw new NotImplementedException();
    }
}