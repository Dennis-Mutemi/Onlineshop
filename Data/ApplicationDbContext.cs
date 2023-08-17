using ecomerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ecomerce.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {


        }
        //create table categories
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { id = 1, name = "Dennis Mutemi", displayorder = 1},
                new Category { id = 2, name = "Dennis Mutemi", displayorder = 2 },
                new Category { id = 3, name = "Dennis Mutemi", displayorder = 3 },
                new Category { id = 4, name = "Dennis Mutemi", displayorder = 4 }

                ); ; 
        }
      


    }
}
