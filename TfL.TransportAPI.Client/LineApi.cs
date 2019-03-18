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
    public interface ILineApi
    {
        /// <summary>
        /// Get the list of arrival predictions for given line ids based at the given stop 
        /// </summary>
        /// <param name="ids">A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids.</param>
        /// <param name="stopPointId">Optional. Id of stop to get arrival predictions for (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="direction">Optional. The direction of travel. Can be inbound or outbound or all. If left blank, and destinationStopId is set, will default to all</param>
        /// <param name="destinationStationId">Optional. Id of destination stop</param>
        /// <returns>List&lt;TflApiPresentationEntitiesPrediction&gt;</returns>
        List<TflApiPresentationEntitiesPrediction> LineArrivals (List<string> ids, string stopPointId, string direction, string destinationStationId);
        /// <summary>
        /// Get disruptions for the given line ids 
        /// </summary>
        /// <param name="ids">A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids.</param>
        /// <returns>List&lt;TflApiPresentationEntitiesDisruption&gt;</returns>
        List<TflApiPresentationEntitiesDisruption> LineDisruption (List<string> ids);
        /// <summary>
        /// Get disruptions for all lines of the given modes. 
        /// </summary>
        /// <param name="modes">A comma-separated list of modes e.g. tube,dlr</param>
        /// <returns>List&lt;TflApiPresentationEntitiesDisruption&gt;</returns>
        List<TflApiPresentationEntitiesDisruption> LineDisruptionByMode (List<string> modes);
        /// <summary>
        /// Gets lines that match the specified line ids. 
        /// </summary>
        /// <param name="ids">A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids.</param>
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>
        List<TflApiPresentationEntitiesLine> LineGet (List<string> ids);
        /// <summary>
        /// Gets lines that serve the given modes. 
        /// </summary>
        /// <param name="modes">A comma-separated list of modes e.g. tube,dlr</param>
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>
        List<TflApiPresentationEntitiesLine> LineGetByMode (List<string> modes);
        /// <summary>
        /// Get all valid routes for given line ids, including the name and id of the originating and terminating stops for each route. 
        /// </summary>
        /// <param name="ids">A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids.</param>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param>
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>
        List<TflApiPresentationEntitiesLine> LineLineRoutesByIds (List<string> ids, List<string> serviceTypes);
        /// <summary>
        /// Gets a list of valid disruption categories 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> LineMetaDisruptionCategories ();
        /// <summary>
        /// Gets a list of valid modes 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesMode&gt;</returns>
        List<TflApiPresentationEntitiesMode> LineMetaModes ();
        /// <summary>
        /// Gets a list of valid ServiceTypes to filter on 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> LineMetaServiceTypes ();
        /// <summary>
        /// Gets a list of valid severity codes 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesStatusSeverity&gt;</returns>
        List<TflApiPresentationEntitiesStatusSeverity> LineMetaSeverity ();
        /// <summary>
        /// Get all valid routes for all lines, including the name and id of the originating and terminating stops for each route. 
        /// </summary>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param>
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>
        List<TflApiPresentationEntitiesLine> LineRoute (List<string> serviceTypes);
        /// <summary>
        /// Gets all lines and their valid routes for given modes, including the name and id of the originating and terminating stops for each route 
        /// </summary>
        /// <param name="modes">A comma-separated list of modes e.g. tube,dlr</param>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param>
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>
        List<TflApiPresentationEntitiesLine> LineRouteByMode (List<string> modes, List<string> serviceTypes);
        /// <summary>
        /// Gets all valid routes for given line id, including the sequence of stops on each route. 
        /// </summary>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <param name="direction">The direction of travel. Can be inbound or outbound.</param>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param>
        /// <param name="excludeCrowding">That excludes crowding from line disruptions. Can be true or false.</param>
        /// <returns>TflApiPresentationEntitiesRouteSequence</returns>
        TflApiPresentationEntitiesRouteSequence LineRouteSequence (string id, string direction, List<string> serviceTypes, bool? excludeCrowding);
        /// <summary>
        /// Search for lines or routes matching the query string 
        /// </summary>
        /// <param name="query">Search term e.g victoria</param>
        /// <param name="modes">Optionally filter by the specified modes</param>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param>
        /// <returns>TflApiPresentationEntitiesRouteSearchResponse</returns>
        TflApiPresentationEntitiesRouteSearchResponse LineSearch (string query, List<string> modes, List<string> serviceTypes);
        /// <summary>
        /// Gets the line status for given line ids during the provided dates e.g Minor Delays 
        /// </summary>
        /// <param name="ids">A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids.</param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param>
        /// <param name="dateRangeStartDate"></param>
        /// <param name="dateRangeEndDate"></param>
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>
        List<TflApiPresentationEntitiesLine> LineStatus (List<string> ids, string startDate, string endDate, bool? detail, DateTime? dateRangeStartDate, DateTime? dateRangeEndDate);
        /// <summary>
        /// Gets the line status of for given line ids e.g Minor Delays 
        /// </summary>
        /// <param name="ids">A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids.</param>
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param>
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>
        List<TflApiPresentationEntitiesLine> LineStatusByIds (List<string> ids, bool? detail);
        /// <summary>
        /// Gets the line status of for all lines for the given modes 
        /// </summary>
        /// <param name="modes">A comma-separated list of modes to filter by. e.g. tube,dlr</param>
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param>
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>
        List<TflApiPresentationEntitiesLine> LineStatusByMode (List<string> modes, bool? detail);
        /// <summary>
        /// Gets the line status for all lines with a given severity              A list of valid severity codes can be obtained from a call to Line/Meta/Severity 
        /// </summary>
        /// <param name="severity">The level of severity (eg: a number from 0 to 14)</param>
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>
        List<TflApiPresentationEntitiesLine> LineStatusBySeverity (int? severity);
        /// <summary>
        /// Gets a list of the stations that serve the given line id 
        /// </summary>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <param name="tflOperatedNationalRailStationsOnly">If the national-rail line is requested, this flag will filter the national rail stations so that only those operated by TfL are returned</param>
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>
        List<TflApiPresentationEntitiesStopPoint> LineStopPoints (string id, bool? tflOperatedNationalRailStationsOnly);
        /// <summary>
        /// Gets the timetable for a specified station on the give line 
        /// </summary>
        /// <param name="fromStopPointId">The originating station&#39;s stop point id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <returns>TflApiPresentationEntitiesTimetableResponse</returns>
        TflApiPresentationEntitiesTimetableResponse LineTimetable (string fromStopPointId, string id);
        /// <summary>
        /// Gets the timetable for a specified station on the give line with specified destination 
        /// </summary>
        /// <param name="fromStopPointId">The originating station&#39;s stop point id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="id">A single line id e.g. victoria</param>
        /// <param name="toStopPointId">The destination stations&#39;s Naptan code</param>
        /// <returns>TflApiPresentationEntitiesTimetableResponse</returns>
        TflApiPresentationEntitiesTimetableResponse LineTimetableTo (string fromStopPointId, string id, string toStopPointId);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class LineApi : ILineApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LineApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public LineApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LineApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LineApi(String basePath)
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
        /// Get the list of arrival predictions for given line ids based at the given stop 
        /// </summary>
        /// <param name="ids">A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids.</param> 
        /// <param name="stopPointId">Optional. Id of stop to get arrival predictions for (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param> 
        /// <param name="direction">Optional. The direction of travel. Can be inbound or outbound or all. If left blank, and destinationStopId is set, will default to all</param> 
        /// <param name="destinationStationId">Optional. Id of destination stop</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesPrediction&gt;</returns>            
        public List<TflApiPresentationEntitiesPrediction> LineArrivals (List<string> ids, string stopPointId, string direction, string destinationStationId)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling LineArrivals");
            
            // verify the required parameter 'stopPointId' is set
            if (stopPointId == null) throw new ApiException(400, "Missing required parameter 'stopPointId' when calling LineArrivals");
            
    
            var path = "/Line/{ids}/Arrivals/{stopPointId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ids" + "}", ApiClient.ParameterToString(ids));
path = path.Replace("{" + "stopPointId" + "}", ApiClient.ParameterToString(stopPointId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (destinationStationId != null) queryParams.Add("destinationStationId", ApiClient.ParameterToString(destinationStationId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LineArrivals: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineArrivals: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPrediction>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPrediction>), response.Headers);
        }
    
        /// <summary>
        /// Get disruptions for the given line ids 
        /// </summary>
        /// <param name="ids">A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids.</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesDisruption&gt;</returns>            
        public List<TflApiPresentationEntitiesDisruption> LineDisruption (List<string> ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling LineDisruption");
            
    
            var path = "/Line/{ids}/Disruption";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LineDisruption: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineDisruption: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesDisruption>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesDisruption>), response.Headers);
        }
    
        /// <summary>
        /// Get disruptions for all lines of the given modes. 
        /// </summary>
        /// <param name="modes">A comma-separated list of modes e.g. tube,dlr</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesDisruption&gt;</returns>            
        public List<TflApiPresentationEntitiesDisruption> LineDisruptionByMode (List<string> modes)
        {
            
            // verify the required parameter 'modes' is set
            if (modes == null) throw new ApiException(400, "Missing required parameter 'modes' when calling LineDisruptionByMode");
            
    
            var path = "/Line/Mode/{modes}/Disruption";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "modes" + "}", ApiClient.ParameterToString(modes));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling LineDisruptionByMode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineDisruptionByMode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesDisruption>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesDisruption>), response.Headers);
        }
    
        /// <summary>
        /// Gets lines that match the specified line ids. 
        /// </summary>
        /// <param name="ids">A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids.</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>            
        public List<TflApiPresentationEntitiesLine> LineGet (List<string> ids)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling LineGet");
            
    
            var path = "/Line/{ids}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LineGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesLine>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesLine>), response.Headers);
        }
    
        /// <summary>
        /// Gets lines that serve the given modes. 
        /// </summary>
        /// <param name="modes">A comma-separated list of modes e.g. tube,dlr</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>            
        public List<TflApiPresentationEntitiesLine> LineGetByMode (List<string> modes)
        {
            
            // verify the required parameter 'modes' is set
            if (modes == null) throw new ApiException(400, "Missing required parameter 'modes' when calling LineGetByMode");
            
    
            var path = "/Line/Mode/{modes}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "modes" + "}", ApiClient.ParameterToString(modes));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling LineGetByMode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineGetByMode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesLine>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesLine>), response.Headers);
        }
    
        /// <summary>
        /// Get all valid routes for given line ids, including the name and id of the originating and terminating stops for each route. 
        /// </summary>
        /// <param name="ids">A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids.</param> 
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>            
        public List<TflApiPresentationEntitiesLine> LineLineRoutesByIds (List<string> ids, List<string> serviceTypes)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling LineLineRoutesByIds");
            
    
            var path = "/Line/{ids}/Route";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ids" + "}", ApiClient.ParameterToString(ids));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (serviceTypes != null) queryParams.Add("serviceTypes", ApiClient.ParameterToString(serviceTypes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LineLineRoutesByIds: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineLineRoutesByIds: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesLine>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesLine>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of valid disruption categories 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> LineMetaDisruptionCategories ()
        {
            
    
            var path = "/Line/Meta/DisruptionCategories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LineMetaDisruptionCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineMetaDisruptionCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of valid modes 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesMode&gt;</returns>            
        public List<TflApiPresentationEntitiesMode> LineMetaModes ()
        {
            
    
            var path = "/Line/Meta/Modes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LineMetaModes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineMetaModes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesMode>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesMode>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of valid ServiceTypes to filter on 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> LineMetaServiceTypes ()
        {
            
    
            var path = "/Line/Meta/ServiceTypes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LineMetaServiceTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineMetaServiceTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of valid severity codes 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesStatusSeverity&gt;</returns>            
        public List<TflApiPresentationEntitiesStatusSeverity> LineMetaSeverity ()
        {
            
    
            var path = "/Line/Meta/Severity";
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
                throw new ApiException ((int)response.StatusCode, "Error calling LineMetaSeverity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineMetaSeverity: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesStatusSeverity>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesStatusSeverity>), response.Headers);
        }
    
        /// <summary>
        /// Get all valid routes for all lines, including the name and id of the originating and terminating stops for each route. 
        /// </summary>
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>            
        public List<TflApiPresentationEntitiesLine> LineRoute (List<string> serviceTypes)
        {
            
    
            var path = "/Line/Route";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (serviceTypes != null) queryParams.Add("serviceTypes", ApiClient.ParameterToString(serviceTypes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LineRoute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineRoute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesLine>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesLine>), response.Headers);
        }
    
        /// <summary>
        /// Gets all lines and their valid routes for given modes, including the name and id of the originating and terminating stops for each route 
        /// </summary>
        /// <param name="modes">A comma-separated list of modes e.g. tube,dlr</param> 
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>            
        public List<TflApiPresentationEntitiesLine> LineRouteByMode (List<string> modes, List<string> serviceTypes)
        {
            
            // verify the required parameter 'modes' is set
            if (modes == null) throw new ApiException(400, "Missing required parameter 'modes' when calling LineRouteByMode");
            
    
            var path = "/Line/Mode/{modes}/Route";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "modes" + "}", ApiClient.ParameterToString(modes));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (serviceTypes != null) queryParams.Add("serviceTypes", ApiClient.ParameterToString(serviceTypes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LineRouteByMode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineRouteByMode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesLine>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesLine>), response.Headers);
        }
    
        /// <summary>
        /// Gets all valid routes for given line id, including the sequence of stops on each route. 
        /// </summary>
        /// <param name="id">A single line id e.g. victoria</param> 
        /// <param name="direction">The direction of travel. Can be inbound or outbound.</param> 
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param> 
        /// <param name="excludeCrowding">That excludes crowding from line disruptions. Can be true or false.</param> 
        /// <returns>TflApiPresentationEntitiesRouteSequence</returns>            
        public TflApiPresentationEntitiesRouteSequence LineRouteSequence (string id, string direction, List<string> serviceTypes, bool? excludeCrowding)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LineRouteSequence");
            
            // verify the required parameter 'direction' is set
            if (direction == null) throw new ApiException(400, "Missing required parameter 'direction' when calling LineRouteSequence");
            
    
            var path = "/Line/{id}/Route/Sequence/{direction}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "direction" + "}", ApiClient.ParameterToString(direction));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (serviceTypes != null) queryParams.Add("serviceTypes", ApiClient.ParameterToString(serviceTypes)); // query parameter
 if (excludeCrowding != null) queryParams.Add("excludeCrowding", ApiClient.ParameterToString(excludeCrowding)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LineRouteSequence: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineRouteSequence: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesRouteSequence) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesRouteSequence), response.Headers);
        }
    
        /// <summary>
        /// Search for lines or routes matching the query string 
        /// </summary>
        /// <param name="query">Search term e.g victoria</param> 
        /// <param name="modes">Optionally filter by the specified modes</param> 
        /// <param name="serviceTypes">A comma seperated list of service types to filter on. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param> 
        /// <returns>TflApiPresentationEntitiesRouteSearchResponse</returns>            
        public TflApiPresentationEntitiesRouteSearchResponse LineSearch (string query, List<string> modes, List<string> serviceTypes)
        {
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling LineSearch");
            
    
            var path = "/Line/Search/{query}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "query" + "}", ApiClient.ParameterToString(query));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (modes != null) queryParams.Add("modes", ApiClient.ParameterToString(modes)); // query parameter
 if (serviceTypes != null) queryParams.Add("serviceTypes", ApiClient.ParameterToString(serviceTypes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LineSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesRouteSearchResponse) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesRouteSearchResponse), response.Headers);
        }
    
        /// <summary>
        /// Gets the line status for given line ids during the provided dates e.g Minor Delays 
        /// </summary>
        /// <param name="ids">A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids.</param> 
        /// <param name="startDate"></param> 
        /// <param name="endDate"></param> 
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param> 
        /// <param name="dateRangeStartDate"></param> 
        /// <param name="dateRangeEndDate"></param> 
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>            
        public List<TflApiPresentationEntitiesLine> LineStatus (List<string> ids, string startDate, string endDate, bool? detail, DateTime? dateRangeStartDate, DateTime? dateRangeEndDate)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling LineStatus");
            
            // verify the required parameter 'startDate' is set
            if (startDate == null) throw new ApiException(400, "Missing required parameter 'startDate' when calling LineStatus");
            
            // verify the required parameter 'endDate' is set
            if (endDate == null) throw new ApiException(400, "Missing required parameter 'endDate' when calling LineStatus");
            
    
            var path = "/Line/{ids}/Status/{StartDate}/to/{EndDate}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ids" + "}", ApiClient.ParameterToString(ids));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (detail != null) queryParams.Add("detail", ApiClient.ParameterToString(detail)); // query parameter
 if (startDate != null) queryParams.Add("startDate", ApiClient.ParameterToString(startDate)); // query parameter
 if (endDate != null) queryParams.Add("endDate", ApiClient.ParameterToString(endDate)); // query parameter
 if (dateRangeStartDate != null) queryParams.Add("dateRange.startDate", ApiClient.ParameterToString(dateRangeStartDate)); // query parameter
 if (dateRangeEndDate != null) queryParams.Add("dateRange.endDate", ApiClient.ParameterToString(dateRangeEndDate)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LineStatus: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineStatus: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesLine>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesLine>), response.Headers);
        }
    
        /// <summary>
        /// Gets the line status of for given line ids e.g Minor Delays 
        /// </summary>
        /// <param name="ids">A comma-separated list of line ids e.g. victoria,circle,N133. Max. approx. 20 ids.</param> 
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>            
        public List<TflApiPresentationEntitiesLine> LineStatusByIds (List<string> ids, bool? detail)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling LineStatusByIds");
            
    
            var path = "/Line/{ids}/Status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ids" + "}", ApiClient.ParameterToString(ids));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (detail != null) queryParams.Add("detail", ApiClient.ParameterToString(detail)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LineStatusByIds: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineStatusByIds: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesLine>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesLine>), response.Headers);
        }
    
        /// <summary>
        /// Gets the line status of for all lines for the given modes 
        /// </summary>
        /// <param name="modes">A comma-separated list of modes to filter by. e.g. tube,dlr</param> 
        /// <param name="detail">Include details of the disruptions that are causing the line status including the affected stops and routes</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>            
        public List<TflApiPresentationEntitiesLine> LineStatusByMode (List<string> modes, bool? detail)
        {
            
            // verify the required parameter 'modes' is set
            if (modes == null) throw new ApiException(400, "Missing required parameter 'modes' when calling LineStatusByMode");
            
    
            var path = "/Line/Mode/{modes}/Status";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "modes" + "}", ApiClient.ParameterToString(modes));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (detail != null) queryParams.Add("detail", ApiClient.ParameterToString(detail)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LineStatusByMode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineStatusByMode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesLine>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesLine>), response.Headers);
        }
    
        /// <summary>
        /// Gets the line status for all lines with a given severity              A list of valid severity codes can be obtained from a call to Line/Meta/Severity 
        /// </summary>
        /// <param name="severity">The level of severity (eg: a number from 0 to 14)</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesLine&gt;</returns>            
        public List<TflApiPresentationEntitiesLine> LineStatusBySeverity (int? severity)
        {
            
            // verify the required parameter 'severity' is set
            if (severity == null) throw new ApiException(400, "Missing required parameter 'severity' when calling LineStatusBySeverity");
            
    
            var path = "/Line/Status/{severity}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "severity" + "}", ApiClient.ParameterToString(severity));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling LineStatusBySeverity: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineStatusBySeverity: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesLine>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesLine>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of the stations that serve the given line id 
        /// </summary>
        /// <param name="id">A single line id e.g. victoria</param> 
        /// <param name="tflOperatedNationalRailStationsOnly">If the national-rail line is requested, this flag will filter the national rail stations so that only those operated by TfL are returned</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>            
        public List<TflApiPresentationEntitiesStopPoint> LineStopPoints (string id, bool? tflOperatedNationalRailStationsOnly)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LineStopPoints");
            
    
            var path = "/Line/{id}/StopPoints";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (tflOperatedNationalRailStationsOnly != null) queryParams.Add("tflOperatedNationalRailStationsOnly", ApiClient.ParameterToString(tflOperatedNationalRailStationsOnly)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling LineStopPoints: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineStopPoints: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesStopPoint>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesStopPoint>), response.Headers);
        }
    
        /// <summary>
        /// Gets the timetable for a specified station on the give line 
        /// </summary>
        /// <param name="fromStopPointId">The originating station&#39;s stop point id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param> 
        /// <param name="id">A single line id e.g. victoria</param> 
        /// <returns>TflApiPresentationEntitiesTimetableResponse</returns>            
        public TflApiPresentationEntitiesTimetableResponse LineTimetable (string fromStopPointId, string id)
        {
            
            // verify the required parameter 'fromStopPointId' is set
            if (fromStopPointId == null) throw new ApiException(400, "Missing required parameter 'fromStopPointId' when calling LineTimetable");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LineTimetable");
            
    
            var path = "/Line/{id}/Timetable/{fromStopPointId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fromStopPointId" + "}", ApiClient.ParameterToString(fromStopPointId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling LineTimetable: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineTimetable: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesTimetableResponse) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesTimetableResponse), response.Headers);
        }
    
        /// <summary>
        /// Gets the timetable for a specified station on the give line with specified destination 
        /// </summary>
        /// <param name="fromStopPointId">The originating station&#39;s stop point id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param> 
        /// <param name="id">A single line id e.g. victoria</param> 
        /// <param name="toStopPointId">The destination stations&#39;s Naptan code</param> 
        /// <returns>TflApiPresentationEntitiesTimetableResponse</returns>            
        public TflApiPresentationEntitiesTimetableResponse LineTimetableTo (string fromStopPointId, string id, string toStopPointId)
        {
            
            // verify the required parameter 'fromStopPointId' is set
            if (fromStopPointId == null) throw new ApiException(400, "Missing required parameter 'fromStopPointId' when calling LineTimetableTo");
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling LineTimetableTo");
            
            // verify the required parameter 'toStopPointId' is set
            if (toStopPointId == null) throw new ApiException(400, "Missing required parameter 'toStopPointId' when calling LineTimetableTo");
            
    
            var path = "/Line/{id}/Timetable/{fromStopPointId}/to/{toStopPointId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fromStopPointId" + "}", ApiClient.ParameterToString(fromStopPointId));
path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "toStopPointId" + "}", ApiClient.ParameterToString(toStopPointId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling LineTimetableTo: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling LineTimetableTo: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesTimetableResponse) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesTimetableResponse), response.Headers);
        }
    
    }
}
