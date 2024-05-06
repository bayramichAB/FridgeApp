using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using FridgeApp_API.Data;
using FridgeApp_API.Repository;

namespace FridgeApp_API.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<ApiDbContext>
    {
        public ApiDbContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();
            var builder = new DbContextOptionsBuilder<ApiDbContext>()
            .UseSqlServer(configuration.GetConnectionString("sqlConnection"), 
            b => b.MigrationsAssembly("FridgeApp_API"));
            return new ApiDbContext(builder.Options);
        }
    }
}
