using Microsoft.Extensions.DependencyInjection;
using ReactStore.Domain.Mappers;
using ReactStore.Domain.Services;

namespace ReactStore.Domain.Extensions
{
    public static class DependenciesRegistration
    {
        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services
                .AddSingleton<IProductMappers, ProductMappers>()
                .AddSingleton<IOrderMappers, OrderMappers>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services
                .AddScoped<IProductServices, ProductServices>()
                .AddScoped<IFilterService, FilterService>()
                .AddScoped<IUserService, UserService>()
                .AddScoped<IOrderService, OrderService>();

            return services;
        }
    }
}