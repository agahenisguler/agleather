using AgLeather.Shop.UI.Services.Abstraction;
using AgLeather.Shop.UI.Services.Implementation;

namespace AgLeather.Shop.UI.Configurations
{
    public static class ServiceInjection
    {
        public static IServiceCollection AddDIServices(this IServiceCollection services)
        {
            services.AddScoped<IRestService, RestService>();

            return services;
        }
    }
}
