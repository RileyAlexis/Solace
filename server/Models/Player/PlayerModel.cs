
using Solace.Models.Class;
using Solace.Models.Settlements;
namespace Solace.Models.Player;

public class PlayerModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public bool IsNPC { get; set; }
    public required string Name { get; set; }
    public string Title { get; set; } = "";
    public Guid SpeciesId { get; set; }
    public Guid SettlementLocationId { get; set; }
    public required Guid ClassId { get; set; }
    public required ClassModel Class { get; set; }
    public ICollection<PlayerStatValue> Stats { get; set; } = new List<PlayerStatValue>();
    public ICollection<PlayerEquipment> EquippedItems { get; set; } = new List<PlayerEquipment>();
    public ICollection<PlayerInventory> PlayerInventory { get; set; } = new List<PlayerInventory>();
    public ICollection<SettlementModel> OwnedSettlements { get; set; } = new List<SettlementModel>();
}