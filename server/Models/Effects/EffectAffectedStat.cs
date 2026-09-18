using Solace.Models.Player;
namespace Solace.Models.Effects;

public class EffectAffectedStat
{
    public int Id { get; set; }
    public int EffectId { get; set; }
    public EffectsModel Effect { get; set; } = null!;
    public int StatDefinitionId { get; set; }
    public StatDefinition StatDefinition { get; set; } = null!;
}