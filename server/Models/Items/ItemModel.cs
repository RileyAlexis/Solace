using Solace.Models.Effects;
namespace Solace.Models.Items;

public class ItemModel
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int ItemTypeId { get; set; }
    public required ItemTypeModel Type { get; set; }
    public bool IsEnchanted { get; set; }
    public bool IsCursed { get; set; } = false;
    public bool IsRemovable { get; set; } = true;
    public bool IsEphemeral { get; set; } = false;

    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public int DamageBonus { get; set; }

    public int Uses { get; set; } = 0;

    public ICollection<ItemEffect> Effects { get; set; } = new List<ItemEffect>();


}