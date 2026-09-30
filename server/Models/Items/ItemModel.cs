using Solace.Models.Effects;
namespace Solace.Models.Items;

public class ItemModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public Guid ItemTypeId { get; set; }
    public required ItemTypeModel Type { get; set; }
    public bool IsEnchanted { get; set; }
    public bool IsCursed { get; set; } = false;
    public bool IsRemovable { get; set; } = true;
    public bool IsEphemeral { get; set; } = false;
    public int Level { get; set; } = 1;

    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public int DamageBonus { get; set; }

    public int Uses { get; set; } = 0;

    public ICollection<ItemEffect> Effects { get; set; } = new List<ItemEffect>();


}