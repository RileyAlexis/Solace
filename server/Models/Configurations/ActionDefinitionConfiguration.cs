using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Solace.Models.Player;
using Solace.Models.Seeds;
namespace Solace.Models.Configurations;

public class ActionDefinitionConfiguration : IEntityTypeConfiguration<ActionDefinition>
{
    public void Configure(EntityTypeBuilder<ActionDefinition> builder)
    {
        builder.HasData(ActionDefinitionSeed.Data);
    }
}