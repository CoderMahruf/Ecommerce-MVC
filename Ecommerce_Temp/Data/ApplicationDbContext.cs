using EcommerceBook_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceBook_Temp.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {

        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Ornult", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Bugatti", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Porche", DisplayOrder = 3 }
                );
        }
    }
}
