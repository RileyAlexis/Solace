using Solace.Models.Player;
namespace Solace.Models.Effects;

public class EffectAffectedStat
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid EffectId { get; set; }
    public EffectsModel Effect { get; set; } = null!;
    public Guid StatDefinitionId { get; set; }
    public StatDefinition StatDefinition { get; set; } = null!;
}