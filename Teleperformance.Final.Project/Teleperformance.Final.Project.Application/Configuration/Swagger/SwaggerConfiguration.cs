using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using Teleperformance.Final.Project.Application.Constants;

namespace Teleperformance.Final.Project.Application.Configuration.Swagger
{
    public class SwaggerConfiguration : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;
        private readonly IApplicationBuilder _builder;
       

        public SwaggerConfiguration(IApiVersionDescriptionProvider provider, IApplicationBuilder builder)
        {
            _provider = provider;
            _builder = builder;
        }

        public static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new OpenApiInfo()
            {
                Title = SwaggerConstant.Title,
                Version = description.ApiVersion.ToString(),
                Description = SwaggerConstant.Description,
                Contact = new OpenApiContact()
                {
                    Name = SwaggerConstant.ContactName,
                    Email = SwaggerConstant.ContactEmail,
                    Url = new Uri(SwaggerConstant.ContactURL)
                },
                License = new OpenApiLicense()
                {
                    Name = "MIT",
                    Url = new Uri(SwaggerConstant.LicenceURL)
                }
            };

            if (description.IsDeprecated)
            {
                info.Description += " Bu Version kullanımdan kaldırılmıştır.";
            }

            


            return info;
        }
        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
            }
        }
    }
}
