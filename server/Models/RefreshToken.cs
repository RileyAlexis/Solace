using System.ComponentModel.DataAnnotations;

namespace Solace.Models;

public class RefreshToken
{
    [Key]
    public int Id { get; set; }

    public string HashedToken { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public DateTime Expires { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Revoked { get; set; }

    public string? ReplacedByHash { get; set; }

    public bool IsActive => Revoked == null && DateTime.UtcNow < Expires;
}
