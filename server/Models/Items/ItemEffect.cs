using Solace.Models.Effects;

namespace Solace.Models.Items;

public class ItemEffect
{
    public int Id { get; set; }
    public int ItemId { get; set; }
    public ItemModel Item { get; set; } = null!;
    public int EffectId { get; set; }
    public EffectsModel Effect { get; set; } = null!;
}