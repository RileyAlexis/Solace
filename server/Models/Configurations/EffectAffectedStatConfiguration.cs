using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Solace.Models.Effects;
namespace Solace.Models.Configurations;

public class EffectAffectStatConfiguration : IEntityTypeConfiguration<EffectAffectedStat>
{
    public void Configure(EntityTypeBuilder<EffectAffectedStat> builder)
    {
        builder.HasIndex(e => new { e.EffectId, e.StatDefinitionId }).IsUnique();
        builder.HasOne(e => e.Effect)
            .WithMany(f => f.AffectedStats)
            .HasForeignKey(e => e.EffectId);

        builder.HasOne(e => e.StatDefinition)
            .WithMany()
            .HasForeignKey(e => e.StatDefinitionId);
    }
}