using Reactivities.Domain;
using Reactivities.Persistance;

namespace Reactivities.API.Extensions
{
    public static class IdentityServiceExtensions
    {
        public static IServiceCollection AddIdentityServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddIdentityCore<AppUser>(opt => 
            {
                opt.Password.RequireNonAlphanumeric = false;
            });
            //services.AddEntityFrameworkStores<ReactivitiesDataContext>();
            return services;
        }
    }
}
