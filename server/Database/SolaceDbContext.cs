using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Solace.Models;

namespace Solace.Database;

public class SolaceDbContext(DbContextOptions<SolaceDbContext> options) : IdentityDbContext<IdentityUser>(options)
{
    public DbSet<RefreshToken> RefreshTokens { get; set; }

}