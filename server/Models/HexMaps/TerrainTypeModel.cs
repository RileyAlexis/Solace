namespace Solace.Models.HexMaps;

public class TerrainType
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public bool IsPassable { get; set; } = true;
    public float TravelModifier { get; set; } = 0;
    public float EncounterModifier { get; set; } = 0;
    public float EventModifier { get; set; } = 0;
}