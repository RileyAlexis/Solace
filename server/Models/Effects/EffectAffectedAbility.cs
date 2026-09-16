using Solace.Models.Player;

namespace Solace.Models.Effects;

public class EffectAffectedAbility
{
    public int Id { get; set; }
    public int EffectId { get; set; }
    public EffectsModel Effect { get; set; } = null!;
    public int ActionId { get; set; }
    public ActionDefinition ActionDefinition { get; set; } = null!;
}