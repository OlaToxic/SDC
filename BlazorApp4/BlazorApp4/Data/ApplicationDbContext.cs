using Microsoft.EntityFrameworkCore;
using static BlazorApp4.Pages.Index;

namespace BlazorApp4.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Project { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                    .ToTable("Projekty");

            base.OnModelCreating(modelBuilder);
        }


    }
}
