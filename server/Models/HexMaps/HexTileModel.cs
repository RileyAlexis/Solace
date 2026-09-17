using Solace.Models.Settlements;
namespace Solace.Models.HexMaps;

public class HexTile
{
    public int Id { get; set; }
    public int MapId { get; set; }
    public required SolaceMap Map { get; set; }
    public int Q { get; set; }
    public int R { get; set; }
    public int S { get; set; }
    public int Level { get; set; }
    public HexTileType HexTileType { get; set; }
    public int TerrainTypeId { get; set; }
    public required TerrainType TerrainType { get; set; }
    public int? SettlementId { get; set; }
    public SettlementModel? Settlement { get; set; }
}