using STEMWars.Server.Services.AuthService;

namespace STEMWars.Server.Utils.ServiceRegistration
{
    public static class ServiceCollectionEx
    {
        public static IServiceCollection AddSTEMWarsServices(this IServiceCollection @this) =>
            @this
                .AddServices();

        private static IServiceCollection AddServices(this IServiceCollection @this) =>
            @this
                .AddScoped<IAuthService, AuthService>();
    }
}
