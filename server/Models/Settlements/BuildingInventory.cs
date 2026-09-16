
using Solace.Models.Items;

namespace Solace.Models.Buildings;

public class BuildingInventory
{
    public int Id { get; set; }
    public int BuildingId { get; set; }
    public BuildingModel Building { get; set; } = null!;
    public int ItemId { get; set; }
    public ItemModel Item { get; set; } = null!;
    public int Quantity { get; set; }
}