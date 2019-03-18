using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace TfLApps.RoadStatus
{
    /// <summary>The Application class: It uses the Dependency Injection container and executes the Run method.</summary>
    public class Application
    {
        protected IRoadApi RoadApi { get; private set; }

        /// <summary>Creates Application instance.</summary>
        /// <param name="roadApi">The TfL's RoadApi</param>
        public Application(IRoadApi roadApi)
        {
            RoadApi = roadApi;
        }

        public void Run(string[] args)
        {
            if (args == null || args.Length != 1)
            {
                Console.WriteLine("Please provide single Road ID.");
                return;
            }

            string roadID = args[0];
            
            try
            {
                TflApiPresentationEntitiesRoadCorridor road = RoadApi.RoadGet_1(new List<string>() { roadID }).SingleOrDefault();

                Console.WriteLine("The status of the {0} is as follows;", road.DisplayName);
                Console.WriteLine("\tRoad Status is {0}", road.StatusSeverity);
                Console.WriteLine("\tRoad Status Description is {0}", road.StatusSeverityDescription);

                Environment.ExitCode = 0;
            }
            catch (ApiException apiException) when (apiException.ErrorCode == 404)
            {
                Console.WriteLine("{0} is not a valid road", roadID);

                Environment.ExitCode = -1;
            }
            catch (Exception exception)
            {
                Environment.ExitCode = -2;
                throw exception;
            }
        }
    }
}
