using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Teleperformance.Final.Project.Logging
{
    public static class LogServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection services, IConfiguration iConfig)
        {


            var logger = new LoggerConfiguration()
               .ReadFrom.Configuration(iConfig.GetSection("SeriLog"));
            return services;
        }
    }
}
