namespace Solace.Models.Effects;

public class EffectsModel
{
    public int Id { get; set; }
    public string Name { get; set; } = "";

    public int AbilityAffectedId { get; set; }
    public List<BodyPlacement>? AffectedBodyPart { get; set; }
    public bool IsInstant { get; set; }

    public ICollection<EffectAffectedStat> AffectedStats { get; set; } = new List<EffectAffectedStat>();
    public ICollection<EffectAffectedAbility> DeniedActions { get; set; } = new List<EffectAffectedAbility>();

}