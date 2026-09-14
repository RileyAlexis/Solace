using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solace.Models.Player;
using Solace.Models.Seeds;

public class StatDefinitionConfiguration : IEntityTypeConfiguration<StatDefinition>
{
    public void Configure(EntityTypeBuilder<StatDefinition> builder)
    {
        builder.HasData(StatsDefinitionSeed.Data);
    }
}