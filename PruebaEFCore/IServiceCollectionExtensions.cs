using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PruebaEFCore.DataAccess;
using System.Configuration;
using System.Reflection;
using PruebaEFCore.DataAccess.Intefaces;
using PruebaEFCore.DataAccess.Repositories;
using PruebaEFCore.Domain;
using PruebaEFCore.Domain.Intefaces;
using PruebaEFCore.Domain.Services;
using ConfigurationManager = System.Configuration.ConfigurationManager;

namespace PruebaEFCore;

public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DatabaseDbContext>(options =>
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .AddEnvironmentVariables()
                .Build();
            var connectionStrings = config.GetRequiredSection("ConnectionStrings:DefaultConnection").Value;

            options.UseSqlite(connectionStrings,
                            op =>
                            {
                                op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                            })
                .EnableSensitiveDataLogging(true);
        });

        services.AddSingleton<IUnitOfWork, UnitOfWork>();

        return services;
    }

    public static IServiceCollection AddForms(this IServiceCollection services)
    {
        return services.AddScoped<Form1>();
                    //.AddTransient<Form1>()
                    //.AddTransient<ChildForm1>()
                    //.AddTransient<MainForm>();
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        return services.AddScoped<IBlogRepository, BlogRepository>();
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services.AddTransient<IBlogService, BlogService>();
    }
}