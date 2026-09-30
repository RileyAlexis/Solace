using Solace.Models.Settlements;
namespace Solace.Models.Seeds;

public static class BuildingDefinitionSeed
{
    public static readonly Guid StoreId = new Guid("b1111111-2020-3030-4040-5060708090a1");
    public static readonly Guid GuildId = new Guid("b1111111-2020-3030-4040-5060708090a2");
    public static readonly Guid InnId = new Guid("b1111111-2020-3030-4040-5060708090a3");
    public static readonly Guid TavernId = new Guid("b1111111-2020-3030-4040-5060708090a4");
    public static readonly Guid BankId = new Guid("b1111111-2020-3030-4040-5060708090a5");
    public static readonly Guid StorageId = new Guid("b1111111-2020-3030-4040-5060708090a6");
    public static readonly Guid ArenaId = new Guid("b1111111-2020-3030-4040-5060708090a7");
    public static readonly Guid HouseId = new Guid("b1111111-2020-3030-4040-5060708090a8");
    public static readonly Guid TrainingHallId = new Guid("b1111111-2020-3030-4040-5060708090a9");
    public static readonly Guid ServiceProviderId = new Guid("b1111111-2020-3030-4040-5060708090aa");

    public static BuildingDefinition[] Data =>
    [
        new BuildingDefinition { Id = StoreId, Name = "Store", AllowsCombat = false, HasInventory = true},
        new BuildingDefinition { Id = GuildId, Name = "Guild", AllowsCombat = true, HasInventory = true},
        new BuildingDefinition { Id = InnId, Name = "Inn", AllowsCombat = false, HasInventory = true},
        new BuildingDefinition { Id = TavernId, Name = "Tavern", AllowsCombat = false, HasInventory = true},
        new BuildingDefinition { Id = BankId, Name = "Bank", AllowsCombat = false, HasInventory = true},
        new BuildingDefinition { Id = StorageId, Name = "Storage", AllowsCombat = false, HasInventory = true},
        new BuildingDefinition { Id = ArenaId, Name = "Arena", AllowsCombat = true, HasInventory = false},
        new BuildingDefinition { Id = HouseId, Name = "House", AllowsCombat = false, HasInventory = true},
        new BuildingDefinition { Id = TrainingHallId, Name = "Training Hall", AllowsCombat = true, HasInventory = true},
        new BuildingDefinition { Id = ServiceProviderId, Name = "Service Provider", AllowsCombat = false, HasInventory = false},
    ];
}