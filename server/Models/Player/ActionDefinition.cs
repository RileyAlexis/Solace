namespace Solace.Models.Player;

public class ActionDefinition
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int ActionPoints { get; set; }
    public bool IsCombatAction { get; set; }
    public bool IsItemAction { get; set; }
}