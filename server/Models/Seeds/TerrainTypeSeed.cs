using Solace.Models.HexMaps;
namespace Solace.Models.Seeds;

public static class TerrainTypeSeed
{
    public static TerrainType[] Data => [
        new TerrainType { Id = 1, Name = "Forest", IsPassable = true, EncounterModifier = 0.5f, EventModifier = 0.1f, TravelModifier = 0.2f },
        new TerrainType { Id = 2, Name = "Plains", IsPassable = true, EncounterModifier = 0.5f, EventModifier = 0.1f, TravelModifier = 0.1f },
        new TerrainType { Id = 3, Name = "Desert", IsPassable = true, EncounterModifier = 0.5f, EventModifier = 0.1f, TravelModifier = 0.3f },
        new TerrainType { Id = 4, Name = "Mountain", IsPassable = true, EncounterModifier = 0.5f, EventModifier = 0.1f, TravelModifier = 1.0f },
        new TerrainType { Id = 5, Name = "Water", IsPassable = false, EncounterModifier = 0.0f, EventModifier = 0.0f, TravelModifier = 0.0f },
        new TerrainType { Id = 6, Name = "Hills", IsPassable = true, EncounterModifier = 0.5f, EventModifier = 0.1f, TravelModifier = 0.5f },
        new TerrainType { Id = 7, Name = "DangerousForest", IsPassable = true, EncounterModifier = 1.5f, EventModifier = 0.4f, TravelModifier = 0.2f },
        new TerrainType { Id = 8, Name = "DangerousPlains", IsPassable = true, EncounterModifier = 1.5f, EventModifier = 0.4f, TravelModifier = 0.1f },
        new TerrainType { Id = 9, Name = "DangerousDesert", IsPassable = true, EncounterModifier = 1.5f, EventModifier = 0.4f, TravelModifier = 0.3f },
        new TerrainType { Id = 10, Name = "DangerousMountain", IsPassable = true, EncounterModifier = 1.5f, EventModifier = 0.4f, TravelModifier = 1.0f },
        new TerrainType { Id = 11, Name = "DangerousWater", IsPassable = false, EncounterModifier = 1.0f, EventModifier = 0.4f, TravelModifier = 0.0f },
        new TerrainType { Id = 12, Name = "DangerousHills", IsPassable = true, EncounterModifier = 1.5f, EventModifier = 0.4f, TravelModifier = 0.5f },
    ];

}