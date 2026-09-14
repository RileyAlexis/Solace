
namespace Solace.Models;

public class SolaceServer
{
    public int Id { get; set; }
    public required string ServerId { get; set; }
    public string? ServerTitle { get; set; }
    public string? MapName { get; set; } = null;
    public required int DefaultMapHeight { get; set; } = 1000;
    public required int DefaultMapWidth { get; set; } = 1000;
    public string CodeOfConduct { get; set; } = string.Empty;
    public int ConcurrentUserLimit { get; set; } = 0;
    public bool AllowNewUsers { get; set; } = true;
}