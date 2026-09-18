using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Solace.Models;
using Solace.Models.HexMaps;
using Solace.Models.Player;
using Solace.Models.Effects;
using Solace.Models.Items;
using Solace.Models.Settlements;

namespace Solace.Database;

public class SolaceDbContext(DbContextOptions<SolaceDbContext> options) : IdentityDbContext<IdentityUser>(options)
{
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<SolaceServer> SolaceServer { get; set; }
    public DbSet<SolaceMap> SolaceMap { get; set; }
    public DbSet<HexTile> HexTiles { get; set; }
    public DbSet<TerrainType> TerrainTypes { get; set; }
    public DbSet<PlayerModel> Player { get; set; }
    public DbSet<PlayerEquipment> PlayerEquipment { get; set; }
    public DbSet<PlayerStatValue> PlayerStatValues { get; set; }
    public DbSet<PlayerInventory> PlayerInventories { get; set; }
    public DbSet<StatDefinition> StatDefinitions { get; set; }
    public DbSet<ItemModel> Items { get; set; }
    public DbSet<ItemTypeModel> ItemTypes { get; set; }
    public DbSet<ItemEffect> ItemEffects { get; set; }
    public DbSet<EffectsModel> Effects { get; set; }
    public DbSet<EffectAffectedStat> EffectAffectedStats { get; set; }
    public DbSet<EffectAffectedAbility> EffectAffectedAbilities { get; set; }
    public DbSet<ActionDefinition> ActionDefinitions { get; set; }
    public DbSet<BuildingModel> Buildings { get; set; }
    public DbSet<BuildingDefinition> BuildingDefinitions { get; set; }
    public DbSet<BuildingInventory> BuildingInventory { get; set; }
    public DbSet<BuildingDefinitionAction> BuildingDefinitionActions { get; set; }

    public DbSet<SettlementModel> Settlements { get; set; }




    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<SolaceServer>()
            .Property(e => e.CodeOfConduct)
            .HasColumnType("text");

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(SolaceDbContext).Assembly);
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     // base.OnConfiguring(optionsBuilder);
    //     optionsBuilder.UseAsyncSeeding(async (context, _, cancellationToken) =>
    //     {
    //         if (!await context.Set<StatDefinition>().AnyAsync(cancellationToken))
    //         {
    //             var stats = StatsDefinitionSeed.Data;
    //             await context.Set<StatDefinition>().AddRangeAsync(stats);
    //         }
    //     });
    // }


}