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
    public interface IBikePointApi
    {
        /// <summary>
        /// Gets the bike point with the given id. 
        /// </summary>
        /// <param name="id">A bike point id (a list of ids can be obtained from the above BikePoint call)</param>
        /// <returns>TflApiPresentationEntitiesPlace</returns>
        TflApiPresentationEntitiesPlace BikePointGet (string id);
        /// <summary>
        /// Gets all bike point locations. The Place object has an addtionalProperties array which contains the nbBikes, nbDocks and nbSpaces              numbers which give the status of the BikePoint. A mismatch in these numbers i.e. nbDocks - (nbBikes + nbSpaces) !&#x3D; 0 indicates broken docks. 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>
        List<TflApiPresentationEntitiesPlace> BikePointGetAll ();
        /// <summary>
        /// Search for bike stations by their name, a bike point&#39;s name often contains information about the name of the street              or nearby landmarks, for example. Note that the search result does not contain the PlaceProperties i.e. the status              or occupancy of the BikePoint, to get that information you should retrieve the BikePoint by its id on /BikePoint/id. 
        /// </summary>
        /// <param name="query">The search term e.g. \&quot;St. James\&quot;</param>
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>
        List<TflApiPresentationEntitiesPlace> BikePointSearch (string query);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BikePointApi : IBikePointApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BikePointApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BikePointApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BikePointApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BikePointApi(String basePath)
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
        /// Gets the bike point with the given id. 
        /// </summary>
        /// <param name="id">A bike point id (a list of ids can be obtained from the above BikePoint call)</param> 
        /// <returns>TflApiPresentationEntitiesPlace</returns>            
        public TflApiPresentationEntitiesPlace BikePointGet (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling BikePointGet");
            
    
            var path = "/BikePoint/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BikePointGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BikePointGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesPlace) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesPlace), response.Headers);
        }
    
        /// <summary>
        /// Gets all bike point locations. The Place object has an addtionalProperties array which contains the nbBikes, nbDocks and nbSpaces              numbers which give the status of the BikePoint. A mismatch in these numbers i.e. nbDocks - (nbBikes + nbSpaces) !&#x3D; 0 indicates broken docks. 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>            
        public List<TflApiPresentationEntitiesPlace> BikePointGetAll ()
        {
            
    
            var path = "/BikePoint";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BikePointGetAll: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BikePointGetAll: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPlace>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPlace>), response.Headers);
        }
    
        /// <summary>
        /// Search for bike stations by their name, a bike point&#39;s name often contains information about the name of the street              or nearby landmarks, for example. Note that the search result does not contain the PlaceProperties i.e. the status              or occupancy of the BikePoint, to get that information you should retrieve the BikePoint by its id on /BikePoint/id. 
        /// </summary>
        /// <param name="query">The search term e.g. \&quot;St. James\&quot;</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>            
        public List<TflApiPresentationEntitiesPlace> BikePointSearch (string query)
        {
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling BikePointSearch");
            
    
            var path = "/BikePoint/Search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling BikePointSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling BikePointSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPlace>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPlace>), response.Headers);
        }
    
    }
}
