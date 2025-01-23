using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Project> Project { get; set; }
    }
}
