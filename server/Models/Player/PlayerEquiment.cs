using Solace.Models.Items;
namespace Solace.Models.Player;

public class PlayerEquipment
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PlayerId { get; set; }
    public PlayerModel Player { get; set; } = null!;
    public Guid ItemId { get; set; }
    public ItemModel Item { get; set; } = null!;
    public BodyPlacement Placement { get; set; }

}