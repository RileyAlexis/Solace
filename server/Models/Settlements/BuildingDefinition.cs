using Solace.Models.Player;

namespace Solace.Models.Settlements;

public class BuildingDefinition
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public bool HasInventory { get; set; }
    public bool AllowsCombat { get; set; }
    public List<BuildingDefinitionAction> AvailableActions { get; set; } = null!;
}