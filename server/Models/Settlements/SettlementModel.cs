using Solace.Models.Player;

namespace Solace.Models.Settlements;

public class SettlementModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public required string Name { get; set; }
    public string? Description { get; set; }
    public Guid? LeaderId { get; set; }
    public PlayerModel? Leader { get; set; }

    public ICollection<BuildingModel> Buildings { get; set; } = null!;
}