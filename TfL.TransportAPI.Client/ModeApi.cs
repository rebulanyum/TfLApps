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
    public interface IModeApi
    {
        /// <summary>
        /// Gets the next arrival predictions for all stops of a given mode 
        /// </summary>
        /// <param name="mode">A mode name e.g. tube, dlr</param>
        /// <param name="count">A number of arrivals to return for each stop, -1 to return all available.</param>
        /// <returns>List&lt;TflApiPresentationEntitiesPrediction&gt;</returns>
        List<TflApiPresentationEntitiesPrediction> ModeArrivals (string mode, int? count);
        /// <summary>
        /// Returns the service type active for a mode.              Currently only supports tube 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesActiveServiceType&gt;</returns>
        List<TflApiPresentationEntitiesActiveServiceType> ModeGetActiveServiceTypes ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ModeApi : IModeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ModeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ModeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ModeApi(String basePath)
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
        /// Gets the next arrival predictions for all stops of a given mode 
        /// </summary>
        /// <param name="mode">A mode name e.g. tube, dlr</param> 
        /// <param name="count">A number of arrivals to return for each stop, -1 to return all available.</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesPrediction&gt;</returns>            
        public List<TflApiPresentationEntitiesPrediction> ModeArrivals (string mode, int? count)
        {
            
            // verify the required parameter 'mode' is set
            if (mode == null) throw new ApiException(400, "Missing required parameter 'mode' when calling ModeArrivals");
            
    
            var path = "/Mode/{mode}/Arrivals";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "mode" + "}", ApiClient.ParameterToString(mode));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (count != null) queryParams.Add("count", ApiClient.ParameterToString(count)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ModeArrivals: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ModeArrivals: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPrediction>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPrediction>), response.Headers);
        }
    
        /// <summary>
        /// Returns the service type active for a mode.              Currently only supports tube 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesActiveServiceType&gt;</returns>            
        public List<TflApiPresentationEntitiesActiveServiceType> ModeGetActiveServiceTypes ()
        {
            
    
            var path = "/Mode/ActiveServiceTypes";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ModeGetActiveServiceTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ModeGetActiveServiceTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesActiveServiceType>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesActiveServiceType>), response.Headers);
        }
    
    }
}
