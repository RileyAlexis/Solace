using Solace.Models.Player;

namespace Solace.Models.Class;

public class ClassBaseStatModel
{
    public int Id { get; set; }
    public int ClassId { get; set; }
    public ClassModel ClassModel { get; set; } = null!;
    public int StatDefinitionId { get; set; }
    public StatDefinition StatDefinition { get; set; } = null!;
    public int Value { get; set; }
}