namespace Solace.Models.HexMaps;

public class SolaceMap
{
    public int Id { get; set; }
    public required int MapWidth { get; set; } = 1000;
    public required int MapHeight { get; set; } = 1000;
    public required int MapLevels { get; set; } = 1;

    public ICollection<HexTile> HexTiles { get; set; } = new List<HexTile>();


}