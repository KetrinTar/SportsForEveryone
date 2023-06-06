using SportsForEveryone.Application.Interfaces;
using SportsForEveryone.Application.Services;
using SportsForEveryone.Infrastructure;

namespace SportsForEveryone.WebUI.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IClubService, ClubService>();
            services.AddScoped<IActivityTypeService, ActivityTypeService>();
            return services;
        }
    }
}
