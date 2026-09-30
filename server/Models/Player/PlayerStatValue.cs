namespace Solace.Models.Player;

public class PlayerStatValue
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PlayerId { get; set; }
    public PlayerModel Player { get; set; } = null!;
    public Guid StatDefinitionId { get; set; }
    public StatDefinition StatDefinition { get; set; } = null!;
    public int Value { get; set; }

}