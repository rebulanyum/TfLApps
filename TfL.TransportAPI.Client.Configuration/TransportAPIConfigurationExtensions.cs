using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace TfL.TransportAPI.Client.Configuration
{
    public static class TransportAPIConfigurationExtensions 
    {
        public static IConfiguration GetTfLTransportAPIClient(this IConfiguration configuration)
        {
            var section = configuration.GetSection("TfL:TransportAPI:Client");
            return section;
        }
    }
}
