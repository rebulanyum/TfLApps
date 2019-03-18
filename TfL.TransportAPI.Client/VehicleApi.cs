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
    public interface IVehicleApi
    {
        /// <summary>
        /// Gets the predictions for a given list of vehicle Id&#39;s. 
        /// </summary>
        /// <param name="ids">A comma-separated list of vehicle ids e.g. LX58CFV,LX11AZB,LX58CFE. Max approx. 25 ids.</param>
        /// <returns>List&lt;TflApiPresentationEntitiesPrediction&gt;</returns>
        List<TflApiPresentationEntitiesPrediction> VehicleGet (List<string> ids);
        /// <summary>
        /// Gets the Emissions Surcharge compliance for the Vehicle 
        /// </summary>
        /// <param name="vrm">The Vehicle Registration Mark</param>
        /// <returns>TflApiPresentationEntitiesVehicleMatch</returns>
        TflApiPresentationEntitiesVehicleMatch VehicleGetEmissionsSurchargeCompliance (string vrm);
        /// <summary>
        /// Gets the Ulez Surcharge compliance for the Vehicle 
        /// </summary>
        /// <param name="vrm">The Vehicle Registration Mark</param>
        /// <returns>TflApiPresentationEntitiesVehicleMatch</returns>
        TflApiPresentationEntitiesVehicleMatch VehicleGetUlezCompliance (string vrm);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VehicleApi : IVehicleApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VehicleApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VehicleApi(String basePath)
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
        /// Gets the predictions for a given list of vehicle Id&#39;s. 
        /// </summary>
        /// <param name="ids">A comma-separated list of vehicle ids e.g. LX58CFV,LX11AZB,LX58CFE. Max approx. 25 ids.</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesPrediction&gt;</returns>            
        public List<TflApiPresentationEntitiesPrediction> VehicleGet (List<string> ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling VehicleGet");
            
    
            var path = "/Vehicle/{ids}/Arrivals";
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
                throw new ApiException ((int)response.StatusCode, "Error calling VehicleGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VehicleGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPrediction>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPrediction>), response.Headers);
        }
    
        /// <summary>
        /// Gets the Emissions Surcharge compliance for the Vehicle 
        /// </summary>
        /// <param name="vrm">The Vehicle Registration Mark</param> 
        /// <returns>TflApiPresentationEntitiesVehicleMatch</returns>            
        public TflApiPresentationEntitiesVehicleMatch VehicleGetEmissionsSurchargeCompliance (string vrm)
        {
            
            // verify the required parameter 'vrm' is set
            if (vrm == null) throw new ApiException(400, "Missing required parameter 'vrm' when calling VehicleGetEmissionsSurchargeCompliance");
            
    
            var path = "/Vehicle/EmissionSurcharge";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (vrm != null) queryParams.Add("vrm", ApiClient.ParameterToString(vrm)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey", "appId" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VehicleGetEmissionsSurchargeCompliance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VehicleGetEmissionsSurchargeCompliance: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesVehicleMatch) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesVehicleMatch), response.Headers);
        }
    
        /// <summary>
        /// Gets the Ulez Surcharge compliance for the Vehicle 
        /// </summary>
        /// <param name="vrm">The Vehicle Registration Mark</param> 
        /// <returns>TflApiPresentationEntitiesVehicleMatch</returns>            
        public TflApiPresentationEntitiesVehicleMatch VehicleGetUlezCompliance (string vrm)
        {
            
            // verify the required parameter 'vrm' is set
            if (vrm == null) throw new ApiException(400, "Missing required parameter 'vrm' when calling VehicleGetUlezCompliance");
            
    
            var path = "/Vehicle/UlezCompliance";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (vrm != null) queryParams.Add("vrm", ApiClient.ParameterToString(vrm)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey", "appId" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling VehicleGetUlezCompliance: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling VehicleGetUlezCompliance: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesVehicleMatch) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesVehicleMatch), response.Headers);
        }
    
    }
}
