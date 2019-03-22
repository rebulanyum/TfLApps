using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Configuration;

namespace TfLApps.RoadStatus
{
    public static class ApplicationConfigurator
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<IRoadApi, RoadApi>();
        }
    }
}
