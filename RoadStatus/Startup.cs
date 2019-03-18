using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Configuration;
using TfL.TransportAPI.Client.Generic;

namespace TfLApps.RoadStatus
{
    /// <summary>The Startup class: This class is for preparing the Dependency Injection for the Application class.</summary>
    public static class Startup
    {
        /// <summary>Dependency Injection cantainer's scope.</summary>
        public static readonly IServiceScope Scope;
        static Startup()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddOptions();

            serviceCollection.AddScoped<Application>();
            serviceCollection.AddScoped<IRoadApi, RoadApi>();
            serviceCollection.Configure<TfLConfig>(configuration.GetSection("TfL"));

            Scope = serviceCollection.BuildServiceProvider().CreateScope();
        }

        /// <summary>Main method for the application.</summary>
        static void Main(string[] args)
        {
            using (Scope)
            {
                var x = Scope.ServiceProvider.GetService<IOptions<TfLConfig>>();
                var config = Scope.ServiceProvider.GetService<IOptions<TfLConfig>>().Value.TransportAPI.Client;
                Configuration.ApiKey.Add("app_key", config.AppKey);
                Configuration.ApiKey.Add("app_id", config.AppID);
                Configuration.DefaultApiClient.BasePath = config.Address;

                var app = Scope.ServiceProvider.GetService<Application>();
                app.Run(args);
            }
        }
    }
}
