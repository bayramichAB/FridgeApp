using FridgeApp_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FridgeApp_API.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {}

        public DbSet<Fridge>? Fridges { get; set; }
        public DbSet<Fridge_Model>? Fridge_Models { get; set; }
        public DbSet<Fridge_Product>? Fridge_Products { get; set; }
        public DbSet<Product>? Products { get; set; }
    }
}
