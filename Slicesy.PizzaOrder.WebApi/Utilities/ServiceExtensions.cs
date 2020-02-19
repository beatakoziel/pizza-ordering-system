using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore.AutoRegisterDi;
using Slicesy.PizzaOrder.WebApi.Repositories;

namespace Slicesy.PizzaOrder.WebApi.Utilities
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
        }

        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<RepositoryContext>(optionsAction =>
                optionsAction.UseNpgsql(config["databaseConnection:connectionString"]));
        }

        public static void ConfigureRepositories(this IServiceCollection services)
        {
            services.RegisterAssemblyPublicNonGenericClasses(Assembly.GetExecutingAssembly())
                .Where(e => e.Name.EndsWith("Repository"))
                .AsPublicImplementedInterfaces();
        }
    }
}