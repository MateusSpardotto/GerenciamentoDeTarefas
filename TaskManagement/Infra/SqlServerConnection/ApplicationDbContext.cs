using Domain.Entities;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Server=localhost,1433;Database=master;Integrated Security=True;TrustServerCertificate=True;";
        optionsBuilder.UseSqlServer(connectionString);
    }
}
