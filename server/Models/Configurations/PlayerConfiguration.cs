using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Solace.Models.Player;
namespace Solace.Models.Configurations;

public class PlayerEquipmentConfiguration : IEntityTypeConfiguration<PlayerEquipment>
{
    public void Configure(EntityTypeBuilder<PlayerEquipment> builder)
    {
        builder.HasIndex(e => new { e.PlayerId, e.Placement })
            .IsUnique();

        builder.HasOne(e => e.Player)
            .WithMany(p => p.EquippedItems)
            .HasForeignKey(e => e.PlayerId);

        builder.HasOne(e => e.Item)
            .WithMany()
            .HasForeignKey(e => e.ItemId);
    }
}

public class PlayerInventoryConfiguration : IEntityTypeConfiguration<PlayerInventory>
{
    public void Configure(EntityTypeBuilder<PlayerInventory> builder)
    {
        builder.HasOne(e => e.Player)
            .WithMany(p => p.PlayerInventory)
            .HasForeignKey(e => e.PlayerId);

        builder.HasOne(e => e.Item)
            .WithMany()
            .HasForeignKey(e => e.ItemId);


    }
}

public class PlayerStatsValueConfiguration : IEntityTypeConfiguration<PlayerStatValue>
{
    public void Configure(EntityTypeBuilder<PlayerStatValue> builder)
    {
        builder.HasIndex(v => new { v.PlayerId, v.StatDefinitionId }).IsUnique();
        builder.HasOne(v => v.Player)
            .WithMany(p => p.StatValues)
            .HasForeignKey(v => v.PlayerId);

        builder.HasOne(v => v.StatDefinition)
            .WithMany()
            .HasForeignKey(v => v.StatDefinitionId);
    }
}