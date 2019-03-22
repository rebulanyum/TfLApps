using RoadStatus.Test.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace RoadStatus.Test
{
    internal class SampleData
    {
        static readonly Lazy<List<TflApiPresentationEntitiesRoadCorridor>> _Get_Road_A1_Response;
        public List<TflApiPresentationEntitiesRoadCorridor> Get_Road_A1_Response { get => _Get_Road_A1_Response.Value; }

        static readonly Lazy<ApiException> _Get_Road_Invalid_Response;
        public ApiException Get_Road_Invalid_Response { get => _Get_Road_Invalid_Response.Value; }

        static SampleData()
        {
            _Get_Road_A1_Response = new Lazy<List<TflApiPresentationEntitiesRoadCorridor>>(() =>
            {
                List<TflApiPresentationEntitiesRoadCorridor> result;

                byte[] data = (byte[])Resources.ResourceManager.GetObject(nameof(Get_Road_A1_Response));
                using (var stream = new MemoryStream(data))
                using (var reader = new StreamReader(stream))
                {
                    var jsonData = reader.ReadToEnd();
                    result = (List<TflApiPresentationEntitiesRoadCorridor>)new ApiClient().Deserialize(jsonData, typeof(List<TflApiPresentationEntitiesRoadCorridor>));
                }

                return result;
            });

            _Get_Road_Invalid_Response = new Lazy<ApiException>(() =>
            {
                ApiException result;

                byte[] data = (byte[])Resources.ResourceManager.GetObject(nameof(Get_Road_Invalid_Response));
                using (var stream = new MemoryStream(data))
                using (var reader = new StreamReader(stream))
                {
                    var jsonData = reader.ReadToEnd();
                    result = new ApiException(404, "Error calling RoadGet_1: " + jsonData, jsonData);
                }

                return result;
            });
        }
    }
}