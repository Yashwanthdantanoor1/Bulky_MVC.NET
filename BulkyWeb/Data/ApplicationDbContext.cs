using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)


        {

        }

        public DbSet<Categorymodel> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorymodel>().HasData(
                new Categorymodel { Id = 4, Name = "Yash", DisplayOrder = 10}
                );
            
        }
    }
}
