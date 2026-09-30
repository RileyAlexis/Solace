using Solace.Models.Player;

namespace Solace.Models.Class;

public class ClassBaseStatModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid ClassId { get; set; }
    public ClassModel ClassModel { get; set; } = null!;
    public Guid StatDefinitionId { get; set; }
    public StatDefinition StatDefinition { get; set; } = null!;
    public int Value { get; set; }
}