namespace Solace.Models.Class;

public class ClassModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public bool MagicUser { get; set; }
    public bool UseTwoHandedWeapons { get; set; }

    public ICollection<ClassBaseStatModel> ClassBaseStats { get; set; } = new List<ClassBaseStatModel>();
}