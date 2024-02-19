using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using N_tier.Models;
using N_tier.Models.Models;

namespace N_tier.Data
{
    public class AppDbContext:IdentityDbContext
    {
        public DbSet<Category> Category{ get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<ApplicationUser> AppUsers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        }
    }
}
