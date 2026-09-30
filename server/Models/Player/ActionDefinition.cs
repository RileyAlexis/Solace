namespace Solace.Models.Player;

public class ActionDefinition
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public int ActionPoints { get; set; }
    public bool IsCombatAction { get; set; }
    public bool IsItemAction { get; set; }
}