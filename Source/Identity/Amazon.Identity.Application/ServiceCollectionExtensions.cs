using Amazon.Identity.Domain;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddUserManager(this IServiceCollection services)
        {
            services.AddTransient<IAppUserManager, AppUserManager>();
            return services;
        }
    }
}