using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Teleperformance.Final.Project.Application.Contracts.Cache;

namespace Teleperformance.Final.Project.Caching
{
    public static class CacheServicesRegisttration
    { 
        public static IServiceCollection ConfigureCacheServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddMemoryCache();
            services.AddTransient<IMemoryCacheService, MemoryCacheManager>();
            return services;

        }
         
    }
}
