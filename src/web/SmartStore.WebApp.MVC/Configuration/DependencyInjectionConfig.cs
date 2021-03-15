using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using SmartStore.WebApp.MVC.Extensions;
using SmartStore.WebApp.MVC.Services;
using SmartStore.WebApp.MVC.Services.Interface;

namespace SmartStore.WebApp.MVC.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddHttpClient<IAuthService, AuthService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();
        }
    }
}
