using Microsoft.Extensions.DependencyInjection;
using Quantum.Application.Services.Contracts;
using Quantum.Application.Services.Implementations;

namespace Quantum.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ISetsSetvice, SetsService>();
            services.AddTransient<ICardsService, CardsService>();

            return services;
        }
    }
}
