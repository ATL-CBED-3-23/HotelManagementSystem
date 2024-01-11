using HotelAPI.Domain.Interfaces;
using HotelAPI.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;

namespace HotelAPI.Infrastructure
{
    public static class ConfigureService
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            //services.AddScoped<ICountryRepository, CountryRepository>();
            //services.AddScoped<ICityRepository, CityRepository>();

            services.Scan(scan => scan.FromAssemblies(
            typeof(IInfrastructureAssemblyMarker).Assembly).AddClasses(@class =>
            @class.Where(type =>
            !type.Name.StartsWith('I')
            && type.Name.EndsWith("Repository")))
            .UsingRegistrationStrategy(RegistrationStrategy.Skip)
            .AsImplementedInterfaces()
            .WithScopedLifetime());

            return services;
        }
    }

}
