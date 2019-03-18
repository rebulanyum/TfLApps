using Microsoft.Extensions.Configuration;
using System;

namespace TfL.TransportAPI.Client.Configuration
{
    public sealed class TfLConfig
    {
        public sealed class TransportAPIConfig
        {
            public sealed class ClientConfig
            {
                public string Address { get; set; }
                public string AppKey { get; set; }
                public string AppID{ get; set; }

                public ClientConfig()
                { }
                public ClientConfig(IConfiguration config)
                {
                    Address = config[nameof(Address)];
                    AppKey = config[nameof(AppKey)];
                    AppID = config[nameof(AppID)];
                }
            }

            public ClientConfig Client { get; set; }

            public TransportAPIConfig()
            { }
            public TransportAPIConfig(IConfiguration config)
            {
                Client = new ClientConfig(config.GetSection(nameof(Client)));
            }
        }

        public TransportAPIConfig TransportAPI { get; set; }

        public TfLConfig()
        { }
        public TfLConfig(IConfiguration config)
        {
            TransportAPI = new TransportAPIConfig(config.GetSection(nameof(TransportAPI)));
        }
    }
}
