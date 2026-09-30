using Solace.Models.Player;

namespace Solace.Models.Effects;

public class EffectAffectedAbility
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid EffectId { get; set; }
    public EffectsModel Effect { get; set; } = null!;
    public Guid ActionId { get; set; }
    public ActionDefinition ActionDefinition { get; set; } = null!;
}