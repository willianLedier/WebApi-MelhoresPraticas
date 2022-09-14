using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApi_MelhoresPraticas.Extension;

namespace WebApiCore.Swagger
{
    public static class VersioningConfig
    {
        public static void AddVersioningConfig(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1, 0);
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.ReportApiVersions = true;
            });

            services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";
                options.SubstituteApiVersionInUrl = true;
            });

        }

        public static void UseVersioningConfig(this IApplicationBuilder app)
        {
           

        }
    }
}
