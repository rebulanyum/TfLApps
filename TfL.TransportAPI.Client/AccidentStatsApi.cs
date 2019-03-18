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
    public interface IAccidentStatsApi
    {
        /// <summary>
        /// Gets all accident details for accidents occuring in the specified year 
        /// </summary>
        /// <param name="year">The year for which to filter the accidents on.</param>
        /// <returns>List&lt;TflApiPresentationEntitiesAccidentStatsAccidentDetail&gt;</returns>
        List<TflApiPresentationEntitiesAccidentStatsAccidentDetail> AccidentStatsGet (int? year);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class AccidentStatsApi : IAccidentStatsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccidentStatsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public AccidentStatsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccidentStatsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccidentStatsApi(String basePath)
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
        /// Gets all accident details for accidents occuring in the specified year 
        /// </summary>
        /// <param name="year">The year for which to filter the accidents on.</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesAccidentStatsAccidentDetail&gt;</returns>            
        public List<TflApiPresentationEntitiesAccidentStatsAccidentDetail> AccidentStatsGet (int? year)
        {
            
            // verify the required parameter 'year' is set
            if (year == null) throw new ApiException(400, "Missing required parameter 'year' when calling AccidentStatsGet");
            
    
            var path = "/AccidentStats/{year}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "year" + "}", ApiClient.ParameterToString(year));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling AccidentStatsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AccidentStatsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesAccidentStatsAccidentDetail>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesAccidentStatsAccidentDetail>), response.Headers);
        }
    
    }
}
