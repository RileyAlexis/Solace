namespace Solace.Models.Items;

public class ItemTypeModel
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public List<BodyPlacement>? ElligiblePlacement { get; set; } = null;
    public int SlotsRequired { get; set; } = 1;
    public bool PlayerEquippable { get; set; }
    public bool IsLimitedUse { get; set; } = false;
}