using Solace.Models.HexMaps;
namespace Solace.Models.Seeds;

public static class TerrainTypeSeed
{
    public static readonly Guid ForestId = new Guid("f01e5872-3b9c-4d6a-9f8e-1029384756af");
    public static readonly Guid PlainsId = new Guid("f02e5872-3b9c-4d6a-9f8e-1029384756b1");
    public static readonly Guid DesertId = new Guid("f03e5872-3b9c-4d6a-9f8e-1029384756c2");
    public static readonly Guid MountainId = new Guid("f04e5872-3b9c-4d6a-9f8e-1029384756d3");
    public static readonly Guid WaterId = new Guid("f05e5872-3b9c-4d6a-9f8e-1029384756e4");
    public static readonly Guid HillsId = new Guid("f06e5872-3b9c-4d6a-9f8e-1029384756f5");
    public static readonly Guid DangerousForestId = new Guid("f07e5872-3b9c-4d6a-9f8e-1029384756a6");
    public static readonly Guid DangerousPlainsId = new Guid("f08e5872-3b9c-4d6a-9f8e-1029384756b7");
    public static readonly Guid DangerousDesertId = new Guid("f09e5872-3b9c-4d6a-9f8e-1029384756c8");
    public static readonly Guid DangerousMountainId = new Guid("f10e5872-3b9c-4d6a-9f8e-1029384756d9");
    public static readonly Guid DangerousWaterId = new Guid("f11e5872-3b9c-4d6a-9f8e-1029384756e0");
    public static readonly Guid DangerousHillsId = new Guid("f12e5872-3b9c-4d6a-9f8e-1029384756f1");

    public static TerrainType[] Data => [
        new TerrainType { Id = ForestId, Name = "Forest", IsPassable = true, EncounterModifier = 0.5f, EventModifier = 0.1f, TravelModifier = 0.2f },
        new TerrainType { Id = PlainsId, Name = "Plains", IsPassable = true, EncounterModifier = 0.5f, EventModifier = 0.1f, TravelModifier = 0.1f },
        new TerrainType { Id = DesertId, Name = "Desert", IsPassable = true, EncounterModifier = 0.5f, EventModifier = 0.1f, TravelModifier = 0.3f },
        new TerrainType { Id = MountainId, Name = "Mountain", IsPassable = true, EncounterModifier = 0.5f, EventModifier = 0.1f, TravelModifier = 1.0f },
        new TerrainType { Id = WaterId, Name = "Water", IsPassable = false, EncounterModifier = 0.0f, EventModifier = 0.0f, TravelModifier = 0.0f },
        new TerrainType { Id = HillsId, Name = "Hills", IsPassable = true, EncounterModifier = 0.5f, EventModifier = 0.1f, TravelModifier = 0.5f },
        new TerrainType { Id = DangerousForestId, Name = "DangerousForest", IsPassable = true, EncounterModifier = 1.5f, EventModifier = 0.4f, TravelModifier = 0.2f },
        new TerrainType { Id = DangerousPlainsId, Name = "DangerousPlains", IsPassable = true, EncounterModifier = 1.5f, EventModifier = 0.4f, TravelModifier = 0.1f },
        new TerrainType { Id = DangerousDesertId, Name = "DangerousDesert", IsPassable = true, EncounterModifier = 1.5f, EventModifier = 0.4f, TravelModifier = 0.3f },
        new TerrainType { Id = DangerousMountainId, Name = "DangerousMountain", IsPassable = true, EncounterModifier = 1.5f, EventModifier = 0.4f, TravelModifier = 1.0f },
        new TerrainType { Id = DangerousWaterId, Name = "DangerousWater", IsPassable = false, EncounterModifier = 1.0f, EventModifier = 0.4f, TravelModifier = 0.0f },
        new TerrainType { Id = DangerousHillsId, Name = "DangerousHills", IsPassable = true, EncounterModifier = 1.5f, EventModifier = 0.4f, TravelModifier = 0.5f },
    ];
}