using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SportsForEveryone.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SportsForEveryone.Core.Interfaces;

namespace SportsForEveryone.Infrastructure
{
    public static class RegistrationExtensions
    {
        public static void AddStorage(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<DataDbContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);              
            });

            serviceCollection.AddScoped<IDataDbContext, DataDbContext>();
        }
    }
}
