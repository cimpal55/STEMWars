using Microsoft.AspNetCore.Components.Authorization;
using ShopWebsite.Client;
using STEMWars.Client.Services.AuthService;

namespace STEMWars.Client.Utils.ServiceRegistration
{
    public static class ServiceCollectionEx
    {
        public static IServiceCollection AddSTEMWarsServices(this IServiceCollection @this) =>
            @this
                .AddServices();

        private static IServiceCollection AddServices(this IServiceCollection @this) =>
            @this
                .AddScoped<IAuthService, AuthService>()
                .AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
    }
}
