using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Solace.Models.Class;
using Solace.Models.Seeds;


public class ClassModelConfiguration : IEntityTypeConfiguration<ClassModel>
{
    public void Configure(EntityTypeBuilder<ClassModel> builder)
    {
        builder.HasData(ClassModelSeed.Data);
    }
}


public class ClassBaseStatConfiguration : IEntityTypeConfiguration<ClassBaseStatModel>
{
    public void Configure(EntityTypeBuilder<ClassBaseStatModel> builder)
    {
        builder.HasOne(c => c.ClassModel)
            .WithMany(m => m.ClassBaseStats)
            .HasForeignKey(p => p.ClassId);

        builder.HasOne(c => c.StatDefinition)
        .WithMany()
        .HasForeignKey(c => c.StatDefinitionId);

        builder.HasData(ClassBaseStatSeed.Data);
    }
}