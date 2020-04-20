using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Quantum.API.Infrastructure.Extensions;
using Quantum.DAL.Infrastructure;

namespace Quantum.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.ConfigureSetting<DatabaseSettings>(configuration);

            return services;
        }
    }
}
