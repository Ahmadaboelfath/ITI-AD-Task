using Microsoft.EntityFrameworkCore;

namespace ITI.Product.Task.BackendApi.Entities
{
    /// <summary>
    /// The database context class that manages database transactions
    /// </summary>
    public class ProductDbContext : DbContext
    {
        // Dbsets for the domain classes
        public DbSet<Product> Products { get; set; }

        // Configuring database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Providing connection string
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=ProductsDB;Trusted_Connection=True;");
            
        }
    }

}
