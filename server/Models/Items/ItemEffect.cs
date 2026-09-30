using Solace.Models.Effects;

namespace Solace.Models.Items;

public class ItemEffect
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ItemId { get; set; }
    public ItemModel Item { get; set; } = null!;
    public Guid EffectId { get; set; }
    public EffectsModel Effect { get; set; } = null!;
}