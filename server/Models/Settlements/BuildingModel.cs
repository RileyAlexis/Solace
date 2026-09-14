public class BuildingModel
{
    public int Id { get; set; }
    public int SettlementId { get; set; }
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public BuildingType Type { get; set; }



}