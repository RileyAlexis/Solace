namespace Solace.Models.Settlements;

public class BuildingModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid SettlementId { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public Guid BuildingTypeId { get; set; }
    public bool IsOpen = true;
    public BuildingDefinition BuildingType { get; set; } = null!;
    public ICollection<BuildingInventory> Inventory { get; set; } = null!;
}