using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Solace.Models.Settlements;
namespace Solace.Models.Configurations;

public class SettlementModelConfiguration : IEntityTypeConfiguration<SettlementModel>
{
    public void Configure(EntityTypeBuilder<SettlementModel> builder)
    {
        builder.HasOne(s => s.Leader)
            .WithMany(p => p.OwnedSettlements)
            .HasForeignKey(s => s.LeaderId)
            .IsRequired(false);
    }
}