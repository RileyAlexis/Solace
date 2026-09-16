using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Solace.Models.Effects;
using Solace.Models.Seeds;
namespace Solace.Models.Configurations;


public class EffectsModelConfiguration : IEntityTypeConfiguration<EffectsModel>
{

    public void Configure(EntityTypeBuilder<EffectsModel> builder)
    {
        builder.HasData(EffectsSeed.Data);
    }
}

public class EffectAffectStatConfiguration : IEntityTypeConfiguration<EffectAffectedStat>
{
    public void Configure(EntityTypeBuilder<EffectAffectedStat> builder)
    {
        builder.HasOne(e => e.Effect)
            .WithMany(f => f.AffectedStats)
            .HasForeignKey(e => e.EffectId);

        builder.HasOne(e => e.StatDefinition)
            .WithMany()
            .HasForeignKey(e => e.StatDefinitionId);

        builder.HasData(EffectsAffectedStatSeed.Data);
    }
}

public class EffectAffectedAbilityConfiguration : IEntityTypeConfiguration<EffectAffectedAbility>
{
    public void Configure(EntityTypeBuilder<EffectAffectedAbility> builder)
    {

        builder.HasOne(e => e.Effect)
            .WithMany(f => f.DeniedActions)
            .HasForeignKey(e => e.EffectId);

        builder.HasOne(e => e.ActionDefinition)
            .WithMany()
            .HasForeignKey(e => e.ActionId);

        builder.HasData(EffectAffectedAbilitySeed.Data);
    }
}