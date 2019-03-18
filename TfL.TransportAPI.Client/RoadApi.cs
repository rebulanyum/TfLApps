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
    public interface IRoadApi
    {
        /// <summary>
        /// Gets a list of disrupted streets. If no date filters are provided, current disruptions are returned. 
        /// </summary>
        /// <param name="startDate">Optional, the start time to filter on.</param>
        /// <param name="endDate">Optional, The end time to filter on.</param>
        /// <returns>SystemObject</returns>
        SystemObject RoadDisruptedStreets (DateTime? startDate, DateTime? endDate);
        /// <summary>
        /// Get active disruptions, filtered by road ids 
        /// </summary>
        /// <param name="ids">Comma-separated list of road identifiers e.g. \&quot;A406, A2\&quot; use all for all to ignore id filter (a full list of supported road identifiers can be found at the /Road/ endpoint)</param>
        /// <param name="stripContent">Optional, defaults to false. When true, removes every property/node except for id, point, severity, severityDescription, startDate, endDate, corridor details, location, comments and streets</param>
        /// <param name="severities">an optional list of Severity names to filter on (a valid list of severities can be obtained from the /Road/Meta/severities endpoint)</param>
        /// <param name="categories">an optional list of category names to filter on (a valid list of categories can be obtained from the /Road/Meta/categories endpoint)</param>
        /// <param name="closures">Optional, defaults to true. When true, always includes disruptions that have road closures, regardless of the severity filter. When false, the severity filter works as normal.</param>
        /// <returns>List&lt;TflApiPresentationEntitiesRoadDisruption&gt;</returns>
        List<TflApiPresentationEntitiesRoadDisruption> RoadDisruption (List<string> ids, bool? stripContent, List<string> severities, List<string> categories, bool? closures);
        /// <summary>
        /// Gets a list of active disruptions filtered by disruption Ids. 
        /// </summary>
        /// <param name="disruptionIds">Comma-separated list of disruption identifiers to filter by.</param>
        /// <param name="stripContent">Optional, defaults to false. When true, removes every property/node except for id, point, severity, severityDescription, startDate, endDate, corridor details, location and comments.</param>
        /// <returns>TflApiPresentationEntitiesRoadDisruption</returns>
        TflApiPresentationEntitiesRoadDisruption RoadDisruptionById (List<string> disruptionIds, bool? stripContent);
        /// <summary>
        /// Gets all roads managed by TfL 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesRoadCorridor&gt;</returns>
        List<TflApiPresentationEntitiesRoadCorridor> RoadGet ();
        /// <summary>
        /// Gets the road with the specified id (e.g. A1) 
        /// </summary>
        /// <param name="ids">Comma-separated list of road identifiers e.g. \&quot;A406, A2\&quot; (a full list of supported road identifiers can be found at the /Road/ endpoint)</param>
        /// <returns>List&lt;TflApiPresentationEntitiesRoadCorridor&gt;</returns>
        List<TflApiPresentationEntitiesRoadCorridor> RoadGet_1 (List<string> ids);
        /// <summary>
        /// Gets a list of valid RoadDisruption categories 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> RoadMetaCategories ();
        /// <summary>
        /// Gets a list of valid RoadDisruption severity codes 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesStatusSeverity&gt;</returns>
        List<TflApiPresentationEntitiesStatusSeverity> RoadMetaSeverities ();
        /// <summary>
        /// Gets the specified roads with the status aggregated over the date range specified, or now until the end of today if no dates are passed. 
        /// </summary>
        /// <param name="ids">Comma-separated list of road identifiers e.g. \&quot;A406, A2\&quot; or use \&quot;all\&quot; to ignore id filter (a full list of supported road identifiers can be found at the /Road/ endpoint)</param>
        /// <param name="dateRangeNullableStartDate"></param>
        /// <param name="dateRangeNullableEndDate"></param>
        /// <returns>List&lt;TflApiPresentationEntitiesRoadCorridor&gt;</returns>
        List<TflApiPresentationEntitiesRoadCorridor> RoadStatus (List<string> ids, DateTime? dateRangeNullableStartDate, DateTime? dateRangeNullableEndDate);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class RoadApi : IRoadApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoadApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public RoadApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoadApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RoadApi(String basePath)
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
        /// Gets a list of disrupted streets. If no date filters are provided, current disruptions are returned. 
        /// </summary>
        /// <param name="startDate">Optional, the start time to filter on.</param> 
        /// <param name="endDate">Optional, The end time to filter on.</param> 
        /// <returns>SystemObject</returns>            
        public SystemObject RoadDisruptedStreets (DateTime? startDate, DateTime? endDate)
        {
            
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling RoadDisruptedStreets");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling RoadDisruptedStreets");
            
    
            var path = "/Road/all/Street/Disruption";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RoadDisruptedStreets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RoadDisruptedStreets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SystemObject) ApiClient.Deserialize(response.Content, typeof(SystemObject), response.Headers);
        }
    
        /// <summary>
        /// Get active disruptions, filtered by road ids 
        /// </summary>
        /// <param name="ids">Comma-separated list of road identifiers e.g. \&quot;A406, A2\&quot; use all for all to ignore id filter (a full list of supported road identifiers can be found at the /Road/ endpoint)</param> 
        /// <param name="stripContent">Optional, defaults to false. When true, removes every property/node except for id, point, severity, severityDescription, startDate, endDate, corridor details, location, comments and streets</param> 
        /// <param name="severities">an optional list of Severity names to filter on (a valid list of severities can be obtained from the /Road/Meta/severities endpoint)</param> 
        /// <param name="categories">an optional list of category names to filter on (a valid list of categories can be obtained from the /Road/Meta/categories endpoint)</param> 
        /// <param name="closures">Optional, defaults to true. When true, always includes disruptions that have road closures, regardless of the severity filter. When false, the severity filter works as normal.</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesRoadDisruption&gt;</returns>            
        public List<TflApiPresentationEntitiesRoadDisruption> RoadDisruption (List<string> ids, bool? stripContent, List<string> severities, List<string> categories, bool? closures)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling RoadDisruption");
            
    
            var path = "/Road/{ids}/Disruption";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ids" + "}", ApiClient.ParameterToString(ids));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (stripContent != null) queryParams.Add("stripContent", ApiClient.ParameterToString(stripContent)); // query parameter
 if (severities != null) queryParams.Add("severities", ApiClient.ParameterToString(severities)); // query parameter
 if (categories != null) queryParams.Add("categories", ApiClient.ParameterToString(categories)); // query parameter
 if (closures != null) queryParams.Add("closures", ApiClient.ParameterToString(closures)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RoadDisruption: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RoadDisruption: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesRoadDisruption>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesRoadDisruption>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of active disruptions filtered by disruption Ids. 
        /// </summary>
        /// <param name="disruptionIds">Comma-separated list of disruption identifiers to filter by.</param> 
        /// <param name="stripContent">Optional, defaults to false. When true, removes every property/node except for id, point, severity, severityDescription, startDate, endDate, corridor details, location and comments.</param> 
        /// <returns>TflApiPresentationEntitiesRoadDisruption</returns>            
        public TflApiPresentationEntitiesRoadDisruption RoadDisruptionById (List<string> disruptionIds, bool? stripContent)
        {
            
            // verify the required parameter 'disruptionIds' is set
            if (disruptionIds == null) throw new ApiException(400, "Missing required parameter 'disruptionIds' when calling RoadDisruptionById");
            
    
            var path = "/Road/all/Disruption/{disruptionIds}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "disruptionIds" + "}", ApiClient.ParameterToString(disruptionIds));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (stripContent != null) queryParams.Add("stripContent", ApiClient.ParameterToString(stripContent)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RoadDisruptionById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RoadDisruptionById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesRoadDisruption) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesRoadDisruption), response.Headers);
        }
    
        /// <summary>
        /// Gets all roads managed by TfL 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesRoadCorridor&gt;</returns>            
        public List<TflApiPresentationEntitiesRoadCorridor> RoadGet ()
        {
            
    
            var path = "/Road";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RoadGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RoadGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesRoadCorridor>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesRoadCorridor>), response.Headers);
        }
    
        /// <summary>
        /// Gets the road with the specified id (e.g. A1) 
        /// </summary>
        /// <param name="ids">Comma-separated list of road identifiers e.g. \&quot;A406, A2\&quot; (a full list of supported road identifiers can be found at the /Road/ endpoint)</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesRoadCorridor&gt;</returns>            
        public List<TflApiPresentationEntitiesRoadCorridor> RoadGet_1 (List<string> ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling RoadGet_1");
            
    
            var path = "/Road/{ids}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ids" + "}", ApiClient.ParameterToString(ids));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling RoadGet_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RoadGet_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesRoadCorridor>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesRoadCorridor>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of valid RoadDisruption categories 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> RoadMetaCategories ()
        {
            
    
            var path = "/Road/Meta/Categories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RoadMetaCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RoadMetaCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of valid RoadDisruption severity codes 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesStatusSeverity&gt;</returns>            
        public List<TflApiPresentationEntitiesStatusSeverity> RoadMetaSeverities ()
        {
            
    
            var path = "/Road/Meta/Severities";
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
                throw new ApiException ((int)response.StatusCode, "Error calling RoadMetaSeverities: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RoadMetaSeverities: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesStatusSeverity>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesStatusSeverity>), response.Headers);
        }
    
        /// <summary>
        /// Gets the specified roads with the status aggregated over the date range specified, or now until the end of today if no dates are passed. 
        /// </summary>
        /// <param name="ids">Comma-separated list of road identifiers e.g. \&quot;A406, A2\&quot; or use \&quot;all\&quot; to ignore id filter (a full list of supported road identifiers can be found at the /Road/ endpoint)</param> 
        /// <param name="dateRangeNullableStartDate"></param> 
        /// <param name="dateRangeNullableEndDate"></param> 
        /// <returns>List&lt;TflApiPresentationEntitiesRoadCorridor&gt;</returns>            
        public List<TflApiPresentationEntitiesRoadCorridor> RoadStatus (List<string> ids, DateTime? dateRangeNullableStartDate, DateTime? dateRangeNullableEndDate)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling RoadStatus");
            
    
            var path = "/Road/{ids}/Status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ids" + "}", ApiClient.ParameterToString(ids));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (dateRangeNullableStartDate != null) queryParams.Add("dateRangeNullable.startDate", ApiClient.ParameterToString(dateRangeNullableStartDate)); // query parameter
 if (dateRangeNullableEndDate != null) queryParams.Add("dateRangeNullable.endDate", ApiClient.ParameterToString(dateRangeNullableEndDate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling RoadStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling RoadStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesRoadCorridor>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesRoadCorridor>), response.Headers);
        }
    
    }
}
