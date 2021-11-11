using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReactStore.Infrastructure;

namespace ReactStore.API.Extensions
{
    public static class DatabaseExtensions
    {
        public static IServiceCollection AddAppDbContext(this IServiceCollection services, string connectionString)
        {
            return services
                .AddDbContext<ReactStoreContext>(contextOptions =>
                {
                    contextOptions.UseNpgsql(
                        connectionString,
                        serverOptions =>
                        {
                            serverOptions.MigrationsAssembly(typeof(Startup).Assembly.FullName);
                        }
                    );
                });
        }
    }
}