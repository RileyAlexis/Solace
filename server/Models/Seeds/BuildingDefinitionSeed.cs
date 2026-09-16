using Solace.Models.Buildings;
namespace Solace.Models.Seeds;

public static class BuildingDefinitionSeed
{
    public static BuildingDefinition[] Data =>
    [
        new BuildingDefinition { Id = 1, Name = "Store", AllowsCombat = false, HasInventory = true},
        new BuildingDefinition { Id = 2, Name = "Guild", AllowsCombat = true, HasInventory = true},
        new BuildingDefinition { Id = 3, Name = "Inn", AllowsCombat = false, HasInventory = true},
        new BuildingDefinition { Id = 4, Name = "Tavern", AllowsCombat = false, HasInventory = true},
        new BuildingDefinition { Id = 5, Name = "Bank", AllowsCombat = false, HasInventory = true},
        new BuildingDefinition { Id = 6, Name = "Storage", AllowsCombat = false, HasInventory = true},
        new BuildingDefinition { Id = 7, Name = "Arena", AllowsCombat = true, HasInventory = false},
        new BuildingDefinition { Id = 8, Name = "House", AllowsCombat = false, HasInventory = true},
        new BuildingDefinition { Id = 9, Name = "TrainingHall", AllowsCombat = true, HasInventory = true},
        new BuildingDefinition { Id = 10, Name = "ServiceProvider", AllowsCombat = false, HasInventory = false},
    ];
}