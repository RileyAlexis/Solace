using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solace.Models.Items;
using Solace.Models.Seeds;

namespace Solace.Models.Configurations;

public class ItemTypeModelConfiguration : IEntityTypeConfiguration<ItemTypeModel>
{
    public void Configure(EntityTypeBuilder<ItemTypeModel> builder)
    {
        builder.Property(t => t.ElligiblePlacement)
            .HasColumnType("integer[]");

        builder.HasData(ItemTypeSeedData.Data);
    }
}

public class ItemModelConfiguration : IEntityTypeConfiguration<ItemModel>
{
    public void Configure(EntityTypeBuilder<ItemModel> builder)
    {
        builder.HasOne(i => i.Type)
        .WithMany()
        .HasForeignKey(i => i.ItemTypeId)
        .IsRequired();
    }
}

public class ItemEffectConfiguration : IEntityTypeConfiguration<ItemEffect>
{
    public void Configure(EntityTypeBuilder<ItemEffect> builder)
    {
        builder.HasIndex(e => new { e.ItemId, e.EffectId }).IsUnique();

        builder.HasOne(e => e.Item)
            .WithMany(i => i.Effects)
            .HasForeignKey(e => e.ItemId);

        builder.HasOne(e => e.Effect)
            .WithMany()
            .HasForeignKey(e => e.EffectId);
    }
}