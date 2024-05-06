using FridgeApp_API.Models;
using FridgeApp_API.Repository.Configuration;
using Microsoft.EntityFrameworkCore;

namespace FridgeApp_API.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FridgeConfiguration());
            modelBuilder.ApplyConfiguration(new Fridge_ModelConfiguration());
            modelBuilder.ApplyConfiguration(new Fridge_ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<Fridge_Model> Fridge_Models { get; set; }
        public DbSet<Fridge_Product> Fridge_Products { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
