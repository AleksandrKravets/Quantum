using Microsoft.Extensions.DependencyInjection;
using Quantum.Application.Contracts.Repositories;
using Quantum.DAL.Infrastructure;
using Quantum.DAL.Repositories.Implementations;

namespace Quantum.DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<StoredProcedureExecutor>();
            services.AddTransient<ISetsRepository, SetsRepository>();
            services.AddTransient<ICardsRepository, CardsRepository>();

            return services;
        }
    }
}
