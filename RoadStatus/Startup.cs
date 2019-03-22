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

            var services = new ServiceCollection();
            services.AddOptions();

            services.AddScoped<Application>();
            services.AddScoped<ApiClient>(sp => {
                var config = Scope.ServiceProvider.GetService<IOptions<TfLConfig>>().Value.TransportAPI.Client;
                return new ApiClient(config.Address);
            });
            services.Configure<TfLConfig>(configuration.GetSection("TfL"));
            ApplicationConfigurator.Configure(services);

            Scope = services.BuildServiceProvider().CreateScope();
        }



        /// <summary>Main method for the application.</summary>
        static int Main(string[] args)
        {
            using (Scope)
            {
                var config = Scope.ServiceProvider.GetService<IOptions<TfLConfig>>().Value.TransportAPI.Client;
                Configuration.ApiKey["app_key"] = config.AppKey;
                Configuration.ApiKey["app_id"] = config.AppID;
                
                ApplicationState result;
                try
                {
                    var app = Scope.ServiceProvider.GetService<Application>();
                    result = app.Run(args);
                }
                catch (Exception e)
                {
                    result = ApplicationState.ApplicationError;
                }
                return (int)result;
            }
        }
    }
}
