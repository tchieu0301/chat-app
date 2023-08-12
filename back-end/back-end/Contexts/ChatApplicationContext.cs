namespace back_end.Contexts;
using Microsoft.EntityFrameworkCore;
using back_end.Entities;

public class ChatApplicationContext : DbContext
{
    protected readonly IConfiguration _configuration;
    public ChatApplicationContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("ChatApplicationCS"));
    }
    public DbSet<Account> Accounts { get; set; }
}
