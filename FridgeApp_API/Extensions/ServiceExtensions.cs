using FridgeApp_API.Contracts;
using FridgeApp_API.Data;
using FridgeApp_API.Repository;
using Microsoft.EntityFrameworkCore;

namespace FridgeApp_API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<ApiDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
