namespace Solace.Models.Player;

public class PlayerStatValue
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public PlayerModel Player { get; set; } = null!;
    public int StatDefinitionId { get; set; }
    public StatDefinition StatDefinition { get; set; } = null!;
    public int Value { get; set; }

}