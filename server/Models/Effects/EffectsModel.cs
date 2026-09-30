namespace Solace.Models.Effects;

public class EffectsModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";

    public Guid AbilityAffectedId { get; set; }
    public List<BodyPlacement>? AffectedBodyPart { get; set; }
    public bool IsInstant { get; set; }

    public ICollection<EffectAffectedStat> AffectedStats { get; set; } = new List<EffectAffectedStat>();
    public ICollection<EffectAffectedAbility> DeniedActions { get; set; } = new List<EffectAffectedAbility>();

}