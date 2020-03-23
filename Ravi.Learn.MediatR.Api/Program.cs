
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using Serilog;
using System;

namespace Ravi.Learn.MediatR.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var configuration = new ConfigurationBuilder()
            //                        .AddJsonFile("appsettings.json")
            //                        .Build();

            //Log.Logger = new LoggerConfiguration()
            //                .ReadFrom.Configuration(configuration)
            //                .Enrich.WithProperty("App Name", "Ravi.Learn.MediatR")
            //                .CreateLogger();
            var hostBuilder = CreateHostBuilder(args).Build();
            hostBuilder.Run();
            //try
            //{
            //    var hostBuilder = CreateHostBuilder(args).Build();
            //    //Log.Information("Host is built.");
            //    hostBuilder.Run();
            //}
            //catch (Exception exception)
            //{
            //   // Log.Fatal(exception, "App terminated unexpectedly");
            //}
            //finally
            //{
            //    Log.CloseAndFlush();
            //}
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                //.UseSerilog()
                //.ConfigureLogging((builderContext, loggingBuilder) =>
                //{
                //    loggingBuilder.ClearProviders();
                //    loggingBuilder.AddConfiguration(builderContext.Configuration.GetSection("Logging"));
                //    loggingBuilder.AddDebug();
                //    loggingBuilder.AddConsole();
                //    loggingBuilder.AddSerilog();
                //})
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
