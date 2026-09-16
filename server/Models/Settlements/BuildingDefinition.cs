using Solace.Models.Player;

namespace Solace.Models.Buildings;

public class BuildingDefinition
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public bool HasInventory { get; set; }
    public bool AllowsCombat { get; set; }
    public List<BuildingDefinitionAction> AvailableActions { get; set; } = null!;
}