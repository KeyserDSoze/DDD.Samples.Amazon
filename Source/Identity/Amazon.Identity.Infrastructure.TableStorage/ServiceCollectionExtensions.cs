using Amazon.Identity.Domain;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUserStorage(this IServiceCollection services)
        {
            services.AddSingleton<IAppUserStorage, AppUserStorage>();
            return services;
        }
    }
}