using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solace.Models.Player;

public class StatDefinitionConfiguration : IEntityTypeConfiguration<StatDefinition>
{
    public void Configure(EntityTypeBuilder<StatDefinition> builder)
    {
        builder.HasData(
            new StatDefinition { Id = 1, Name = "Health" },
            new StatDefinition { Id = 2, Name = "HealthMax" },
            new StatDefinition { Id = 3, Name = "Stamina" },
            new StatDefinition { Id = 4, Name = "Strength" },
            new StatDefinition { Id = 5, Name = "Intelligence" },
            new StatDefinition { Id = 6, Name = "Education" },
            new StatDefinition { Id = 7, Name = "Mana" },
            new StatDefinition { Id = 8, Name = "ManaMax" },
            new StatDefinition { Id = 9, Name = "MagicLevel" },
            new StatDefinition { Id = 10, Name = "TechLevel" },
            new StatDefinition { Id = 11, Name = "Experience" },
            new StatDefinition { Id = 12, Name = "Level" }
        );
    }
}