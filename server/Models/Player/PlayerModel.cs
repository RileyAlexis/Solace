using Solace.Models.Items;

namespace Solace.Models.Player;

public class PlayerModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string Title { get; set; } = "";
    public int SpeciesId { get; set; }
    public int ClassId { get; set; }
    public ICollection<PlayerStatValue> StatValues { get; set; } = new List<PlayerStatValue>();
    public ICollection<PlayerEquipment> EquippedItems { get; set; } = new List<PlayerEquipment>();
    public ICollection<PlayerInventory> PlayerInventory { get; set; } = new List<PlayerInventory>();


}