using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Scrutor;
using System.Reflection;

namespace HotelAPI.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.Scan(
                scan =>
                    scan.FromAssemblies(typeof(IApplicationAssemblyMarker).Assembly)
                        .AddClasses(
                            @class =>
                                @class.Where(
                                    type => !type.Name.StartsWith('I') && type.Name.EndsWith("Service")))
                        .UsingRegistrationStrategy(RegistrationStrategy.Skip)
                        .AsImplementedInterfaces()
                        .WithScopedLifetime()
            );


            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;

        }
    }
}
