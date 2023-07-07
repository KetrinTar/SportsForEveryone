using SportsForEveryone.Application.Helpers;
using SportsForEveryone.Application.Interfaces;
using SportsForEveryone.Application.Services;

using SportsForEveryone.Infrastructure;

namespace SportsForEveryone.WebUI.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingProfiles));
            services.AddScoped<IFileService, FileService>();
            services.AddHttpContextAccessor();
            services.AddScoped<IClubService, ClubService>();
            services.AddScoped<IActivityTypeService, ActivityTypeService>();
            services.AddScoped<IActivityService, ActivityService>();
            services.AddScoped<IReviewService, ReviewService>();
            services.AddScoped<IPostService, PostService>();
            services.AddScoped<ITrainerService, TrainerService>();
            services.AddScoped<IRateService, RateService>();
            return services;
        }
    }
}
