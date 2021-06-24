using System;
using System.IO;
using System.Threading.Tasks;
using HappyTravel.LogEventsScraper.Configurations;
using HappyTravel.LogEventsScraper.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HappyTravel.LogEventsScraper
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var serviceProvider = new ServiceCollection()
                .AddTransient<IGitHubService, GitHubService>()
                .AddTransient<ILogEventsService, LogEventsService>()
                .Configure<Settings>(configuration.GetSection("AppSettings"))
                .BuildServiceProvider();

            Console.WriteLine("Starting update");
            var logEventsService = serviceProvider.GetService<ILogEventsService>();
            var fileUrl = await logEventsService.RefreshEventIds();
            Console.WriteLine("The file has been updated");
            Console.WriteLine(fileUrl);
        }
    }
}