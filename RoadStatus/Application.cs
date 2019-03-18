using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using TfL.TransportAPI.Client;

namespace TfLApps.RoadStatus
{
    /// <summary>The Application class: It uses the Dependency Injection container and executes the Run method.</summary>
    public class Application
    {
        protected IRoadApi RoadApi { get; private set; }

        /// <summary>Creates Application instance.</summary>
        /// <param name="services"></param>
        public Application(IRoadApi roadApi)
        {
            RoadApi = roadApi;
        }

        public void Run(string[] args)
        {
            //TODO
        }
    }
}
