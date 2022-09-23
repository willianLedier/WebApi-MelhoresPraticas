using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace WebApi_MelhoresPraticas.Extension
{
    public class HealthCheckCustom : IHealthCheck
    {
       
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            try
            {

                if (true)
                {
                    return HealthCheckResult.Healthy();
                }
                else
                {
                    HealthCheckResult.Unhealthy();
                }
            }
            catch (Exception)
            {
                return HealthCheckResult.Unhealthy();
            }
        }
    }
}
