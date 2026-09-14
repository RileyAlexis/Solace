namespace Solace.Models.Effects;

public class EffectsModel
{
    public int Id { get; set; }
    public string Name { get; set; } = "";

    public int AbilityAffectedId { get; set; }
    public List<BodyPlacement>? AffectedBodyPart { get; set; }
    public int DurationRounds { get; set; }
    public TimeSpan DurationTime { get; set; }
    public bool IsInstant { get; set; }
    public int ReductionRate { get; set; }

    public ICollection<EffectAffectedStat> AffectedStats { get; set; } = new List<EffectAffectedStat>();


}