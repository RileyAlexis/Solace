using Solace.Models.Player;

namespace Solace.Models.Settlements;

public class SettlementModel
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public int? LeaderId { get; set; }
    public PlayerModel? Leader { get; set; }

    public ICollection<BuildingModel> Buildings { get; set; } = null!;
}