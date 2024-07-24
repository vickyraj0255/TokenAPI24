using Microsoft.EntityFrameworkCore;

namespace TokenAPI24.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> states { get; set; }

    }
}
