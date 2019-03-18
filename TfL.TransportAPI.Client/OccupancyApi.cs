using System;
using System.Collections.Generic;
using RestSharp;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace TfL.TransportAPI.Client
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOccupancyApi
    {
        /// <summary>
        /// Gets the occupancy for a car park with a given id 
        /// </summary>
        /// <param name="id"></param>
        /// <returns>TflApiPresentationEntitiesCarParkOccupancy</returns>
        TflApiPresentationEntitiesCarParkOccupancy OccupancyGet (string id);
        /// <summary>
        /// Gets the occupancy for all charge connectors 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesChargeConnectorOccupancy&gt;</returns>
        List<TflApiPresentationEntitiesChargeConnectorOccupancy> OccupancyGetAllChargeConnectorStatus ();
        /// <summary>
        /// Get the occupancy for bike points. 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns>List&lt;TflApiPresentationEntitiesBikePointOccupancy&gt;</returns>
        List<TflApiPresentationEntitiesBikePointOccupancy> OccupancyGetBikePointsOccupancies (List<string> ids);
        /// <summary>
        /// Gets the occupancy for a charge connectors with a given id (sourceSystemPlaceId) 
        /// </summary>
        /// <param name="ids"></param>
        /// <returns>List&lt;TflApiPresentationEntitiesChargeConnectorOccupancy&gt;</returns>
        List<TflApiPresentationEntitiesChargeConnectorOccupancy> OccupancyGetChargeConnectorStatus (List<string> ids);
        /// <summary>
        /// Gets the occupancy for all car parks that have occupancy data 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesCarParkOccupancy&gt;</returns>
        List<TflApiPresentationEntitiesCarParkOccupancy> OccupancyGet_1 ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class OccupancyApi : IOccupancyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OccupancyApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public OccupancyApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OccupancyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OccupancyApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Gets the occupancy for a car park with a given id 
        /// </summary>
        /// <param name="id"></param> 
        /// <returns>TflApiPresentationEntitiesCarParkOccupancy</returns>            
        public TflApiPresentationEntitiesCarParkOccupancy OccupancyGet (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling OccupancyGet");
            
    
            var path = "/Occupancy/CarPark/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey", "appId" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OccupancyGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OccupancyGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesCarParkOccupancy) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesCarParkOccupancy), response.Headers);
        }
    
        /// <summary>
        /// Gets the occupancy for all charge connectors 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesChargeConnectorOccupancy&gt;</returns>            
        public List<TflApiPresentationEntitiesChargeConnectorOccupancy> OccupancyGetAllChargeConnectorStatus ()
        {
            
    
            var path = "/Occupancy/ChargeConnector";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey", "appId" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OccupancyGetAllChargeConnectorStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OccupancyGetAllChargeConnectorStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesChargeConnectorOccupancy>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesChargeConnectorOccupancy>), response.Headers);
        }
    
        /// <summary>
        /// Get the occupancy for bike points. 
        /// </summary>
        /// <param name="ids"></param> 
        /// <returns>List&lt;TflApiPresentationEntitiesBikePointOccupancy&gt;</returns>            
        public List<TflApiPresentationEntitiesBikePointOccupancy> OccupancyGetBikePointsOccupancies (List<string> ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling OccupancyGetBikePointsOccupancies");
            
    
            var path = "/Occupancy/BikePoints/{ids}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ids" + "}", ApiClient.ParameterToString(ids));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey", "appId" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OccupancyGetBikePointsOccupancies: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OccupancyGetBikePointsOccupancies: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesBikePointOccupancy>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesBikePointOccupancy>), response.Headers);
        }
    
        /// <summary>
        /// Gets the occupancy for a charge connectors with a given id (sourceSystemPlaceId) 
        /// </summary>
        /// <param name="ids"></param> 
        /// <returns>List&lt;TflApiPresentationEntitiesChargeConnectorOccupancy&gt;</returns>            
        public List<TflApiPresentationEntitiesChargeConnectorOccupancy> OccupancyGetChargeConnectorStatus (List<string> ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling OccupancyGetChargeConnectorStatus");
            
    
            var path = "/Occupancy/ChargeConnector/{ids}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ids" + "}", ApiClient.ParameterToString(ids));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey", "appId" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OccupancyGetChargeConnectorStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OccupancyGetChargeConnectorStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesChargeConnectorOccupancy>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesChargeConnectorOccupancy>), response.Headers);
        }
    
        /// <summary>
        /// Gets the occupancy for all car parks that have occupancy data 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesCarParkOccupancy&gt;</returns>            
        public List<TflApiPresentationEntitiesCarParkOccupancy> OccupancyGet_1 ()
        {
            
    
            var path = "/Occupancy/CarPark";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey", "appId" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling OccupancyGet_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling OccupancyGet_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesCarParkOccupancy>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesCarParkOccupancy>), response.Headers);
        }
    
    }
}
