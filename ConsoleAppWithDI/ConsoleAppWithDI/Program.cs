using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace ConsoleAppWithDI
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            using var host = CreateHostBuilder(args).Build();

            var testManager = host.Services.GetService<ITestManager>();
            await testManager.Run();

            await Task.CompletedTask;
        }


        public static IHostBuilder CreateHostBuilder(string[] args) =>
          Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddTransient<ITestService, TestService>();
                services.AddTransient<ITestManager, TestManager>();
            });
    }
}
