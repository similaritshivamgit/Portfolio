using Microsoft.EntityFrameworkCore;
using Portfolio_Backend.Models;
namespace Portfolio_Backend.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<NavbarDetails> NavbarDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("Portfolio");
        }
    }
}
