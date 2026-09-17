using Solace.Models.Player;

namespace Solace.Models.Settlements;

public class BuildingDefinitionAction
{
    public int BuildingDefinitionId { get; set; }
    public BuildingDefinition BuildingDefinition { get; set; } = null!;
    public int ActionDefinitionId { get; set; }
    public ActionDefinition ActionDefinition { get; set; } = null!;
}