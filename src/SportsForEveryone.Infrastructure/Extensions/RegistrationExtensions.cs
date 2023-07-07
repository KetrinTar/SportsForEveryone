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
using SportsForEveryone.Infrastructure.Interfaces;

namespace SportsForEveryone.Infrastructure.Extensions
{
    public static class RegistrationExtensions
    {
        public static void AddStorage(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddDbContext<DataDbContext>(options =>
            {
                options.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

                //options.UseLoggerFactory(LoggerFactory.Create(builder =>
                //{
                //    builder.AddConsole();
                //}));

                //options.EnableDetailedErrors()
                //.EnableSensitiveDataLogging()
                //.LogTo(Console.WriteLine, new List<string> { "Database.Command" }, LogLevel.Information);
            });

            serviceCollection.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            serviceCollection.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
        }
    }
}
