
using Solace.Models.Items;

namespace Solace.Models.Settlements;

public class BuildingInventory
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid BuildingId { get; set; }
    public BuildingModel Building { get; set; } = null!;
    public Guid ItemId { get; set; }
    public ItemModel Item { get; set; } = null!;
    public int Quantity { get; set; }
}