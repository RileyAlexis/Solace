using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Solace.Models.HexMaps;
namespace Solace.Models.Configurations;

public class HexTileConfiguration : IEntityTypeConfiguration<HexTile>
{
    public void Configure(EntityTypeBuilder<HexTile> builder)
    {
        builder
            .HasIndex(t => new { t.MapId, t.Q, t.R, t.S, t.Level })
            .IsUnique();

        builder
            .ToTable(t => t.HasCheckConstraint("CK_HexTile_CubeSum", "q + r + s = 0"));

        builder
            .HasOne(t => t.Map)
            .WithMany(m => m.HexTiles)
            .HasForeignKey(t => t.MapId);

        builder
            .HasOne(t => t.TerrainType)
            .WithMany()
            .HasForeignKey(t => t.TerrainTypeId);
    }
}