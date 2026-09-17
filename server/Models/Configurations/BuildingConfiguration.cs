using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Solace.Models.Settlements;
using Solace.Models.Seeds;
namespace Solace.Models.Configurations;

public class BuildingModelConfiguration : IEntityTypeConfiguration<BuildingModel>
{
    public void Configure(EntityTypeBuilder<BuildingModel> builder)
    {
        builder.HasOne(b => b.BuildingType)
        .WithMany()
        .HasForeignKey(b => b.BuildingTypeId)
        .IsRequired();

        builder.HasOne<SettlementModel>()
            .WithMany()
            .HasForeignKey(p => p.SettlementId);
    }
}

public class BuildingDefinitionConfiguration : IEntityTypeConfiguration<BuildingDefinition>
{
    public void Configure(EntityTypeBuilder<BuildingDefinition> builder)
    {
        builder.HasData(BuildingDefinitionSeed.Data);
    }
}

public class BuildingDefinitionActionConfiguration : IEntityTypeConfiguration<BuildingDefinitionAction>
{
    public void Configure(EntityTypeBuilder<BuildingDefinitionAction> builder)
    {
        builder.HasKey(a => new { a.BuildingDefinitionId, a.ActionDefinitionId });

        builder.HasOne(a => a.BuildingDefinition)
            .WithMany(b => b.AvailableActions)
            .HasForeignKey(a => a.BuildingDefinitionId);

        builder.HasOne(a => a.ActionDefinition)
            .WithMany()
            .HasForeignKey(a => a.ActionDefinitionId);

        builder.HasData(BuildingDefinitionActionSeed.Data);
    }
}

public class BuildingInventoryConfiguration : IEntityTypeConfiguration<BuildingInventory>
{
    public void Configure(EntityTypeBuilder<BuildingInventory> builder)
    {
        builder.HasOne(e => e.Building)
            .WithMany(p => p.Inventory)
            .HasForeignKey(e => e.BuildingId);

        builder.HasOne(e => e.Item)
        .WithMany()
        .HasForeignKey(e => e.ItemId);
    }
}