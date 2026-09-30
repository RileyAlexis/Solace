using Solace.Models.Player;

namespace Solace.Models.Settlements;

public class BuildingDefinitionAction
{
    public Guid BuildingDefinitionId { get; set; }
    public BuildingDefinition BuildingDefinition { get; set; } = null!;
    public Guid ActionDefinitionId { get; set; }
    public ActionDefinition ActionDefinition { get; set; } = null!;
}