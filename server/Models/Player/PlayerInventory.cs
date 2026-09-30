using Solace.Models.Items;

namespace Solace.Models.Player;

public class PlayerInventory
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid PlayerId { get; set; }
    public PlayerModel Player { get; set; } = null!;
    public Guid ItemId { get; set; }
    public ItemModel Item { get; set; } = null!;
    public int Quantity { get; set; }
}