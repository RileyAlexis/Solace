using Solace.Models.Items;

namespace Solace.Models.Player;

public class PlayerInventory
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public PlayerModel Player { get; set; } = null!;
    public int ItemId { get; set; }
    public ItemModel Item { get; set; } = null!;
    public int Quantity { get; set; }
}