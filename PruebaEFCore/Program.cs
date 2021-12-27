using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PruebaEFCore.Domain.Utilidades;

namespace PruebaEFCore
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = new HostBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    ConfigureServices(hostContext.Configuration, services);
                }).Build();


            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    ApplicationConfiguration.Initialize();
                    var form = services.GetRequiredService<Form1>();
                    Application.Run(form);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ha ocurrido un error.\r\nError: {ex.Message}");
                }
            }

        }

        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            services.AddDatabase(configuration)
                .AddForms()
                .AddServices()
                .AddRepositories();

            services.AddAutoMapper(typeof(AutoMapperProfiles));
        }
    }
}