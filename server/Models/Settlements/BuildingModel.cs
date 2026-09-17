namespace Solace.Models.Settlements;

public class BuildingModel
{
    public int Id { get; set; }
    public int SettlementId { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public int BuildingTypeId { get; set; }
    public bool IsOpen = true;
    public BuildingDefinition BuildingType { get; set; } = null!;
    public ICollection<BuildingInventory> Inventory { get; set; } = null!;
}