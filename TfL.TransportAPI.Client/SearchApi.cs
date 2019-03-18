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
    public interface ISearchApi
    {
        /// <summary>
        /// Searches the bus schedules folder on S3 for a given bus number. 
        /// </summary>
        /// <param name="query">The search query</param>
        /// <returns>TflApiPresentationEntitiesSearchResponse</returns>
        TflApiPresentationEntitiesSearchResponse SearchBusSchedules (string query);
        /// <summary>
        /// Search the site for occurrences of the query string. The maximum number of results returned is equal to the maximum page size              of 100. To return subsequent pages, use the paginated overload. 
        /// </summary>
        /// <param name="query">The search query</param>
        /// <returns>TflApiPresentationEntitiesSearchResponse</returns>
        TflApiPresentationEntitiesSearchResponse SearchGet (string query);
        /// <summary>
        /// Gets the available search categories. 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> SearchMetaCategories ();
        /// <summary>
        /// Gets the available searchProvider names. 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> SearchMetaSearchProviders ();
        /// <summary>
        /// Gets the available sorting options. 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> SearchMetaSorts ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SearchApi : ISearchApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SearchApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SearchApi(String basePath)
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
        /// Searches the bus schedules folder on S3 for a given bus number. 
        /// </summary>
        /// <param name="query">The search query</param> 
        /// <returns>TflApiPresentationEntitiesSearchResponse</returns>            
        public TflApiPresentationEntitiesSearchResponse SearchBusSchedules (string query)
        {
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling SearchBusSchedules");
            
    
            var path = "/Search/BusSchedules";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey", "appId" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchBusSchedules: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchBusSchedules: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesSearchResponse) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesSearchResponse), response.Headers);
        }
    
        /// <summary>
        /// Search the site for occurrences of the query string. The maximum number of results returned is equal to the maximum page size              of 100. To return subsequent pages, use the paginated overload. 
        /// </summary>
        /// <param name="query">The search query</param> 
        /// <returns>TflApiPresentationEntitiesSearchResponse</returns>            
        public TflApiPresentationEntitiesSearchResponse SearchGet (string query)
        {
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling SearchGet");
            
    
            var path = "/Search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey", "appId" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesSearchResponse) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesSearchResponse), response.Headers);
        }
    
        /// <summary>
        /// Gets the available search categories. 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> SearchMetaCategories ()
        {
            
    
            var path = "/Search/Meta/Categories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchMetaCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchMetaCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Gets the available searchProvider names. 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> SearchMetaSearchProviders ()
        {
            
    
            var path = "/Search/Meta/SearchProviders";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchMetaSearchProviders: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchMetaSearchProviders: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Gets the available sorting options. 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> SearchMetaSorts ()
        {
            
    
            var path = "/Search/Meta/Sorts";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SearchMetaSorts: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SearchMetaSorts: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
    }
}
