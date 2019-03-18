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
    public interface IStopPointApi
    {
        /// <summary>
        /// Gets the list of arrival predictions for the given stop point id 
        /// </summary>
        /// <param name="id">A StopPoint id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <returns>List&lt;TflApiPresentationEntitiesPrediction&gt;</returns>
        List<TflApiPresentationEntitiesPrediction> StopPointArrivals (string id);
        /// <summary>
        /// Gets all the Crowding data (static) for the StopPointId, plus crowding data for a given line and optionally a particular direction. 
        /// </summary>
        /// <param name="id">The Naptan id of the stop</param>
        /// <param name="line">A particular line e.g. victoria, circle, northern etc.</param>
        /// <param name="direction">The direction of travel. Can be inbound or outbound.</param>
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>
        List<TflApiPresentationEntitiesStopPoint> StopPointCrowding (string id, string line, string direction);
        /// <summary>
        /// Returns the canonical direction, \&quot;inbound\&quot; or \&quot;outbound\&quot;, for a given pair of stop point Ids in the direction from -&amp;gt; to. 
        /// </summary>
        /// <param name="id">Originating stop id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="toStopPointId">Destination stop id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="lineId">Optional line id filter e.g. victoria</param>
        /// <returns>string</returns>
        string StopPointDirection (string id, string toStopPointId, string lineId);
        /// <summary>
        /// Gets all disruptions for the specified StopPointId, plus disruptions for any child Naptan records it may have. 
        /// </summary>
        /// <param name="ids">A comma-seperated list of stop point ids. Max. approx. 20 ids.              You can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name.</param>
        /// <param name="getFamily">Specify true to return disruptions for entire family, or false to return disruptions for just this stop point. Defaults to false.</param>
        /// <param name="includeRouteBlockedStops"></param>
        /// <param name="flattenResponse">Specify true to associate all disruptions with parent stop point. (Only applicable when getFamily is true).</param>
        /// <returns>List&lt;TflApiPresentationEntitiesDisruptedPoint&gt;</returns>
        List<TflApiPresentationEntitiesDisruptedPoint> StopPointDisruption (List<string> ids, bool? getFamily, bool? includeRouteBlockedStops, bool? flattenResponse);
        /// <summary>
        /// Gets a distinct list of disrupted stop points for the given modes 
        /// </summary>
        /// <param name="modes">A comma-seperated list of modes e.g. tube,dlr</param>
        /// <param name="includeRouteBlockedStops"></param>
        /// <returns>List&lt;TflApiPresentationEntitiesDisruptedPoint&gt;</returns>
        List<TflApiPresentationEntitiesDisruptedPoint> StopPointDisruptionByMode (List<string> modes, bool? includeRouteBlockedStops);
        /// <summary>
        /// Gets a list of StopPoints corresponding to the given list of stop ids. 
        /// </summary>
        /// <param name="ids">A comma-separated list of stop point ids (station naptan code e.g. 940GZZLUASL). Max. approx. 20 ids.              You can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name.</param>
        /// <param name="includeCrowdingData">Include the crowding data (static). To Filter further use: /StopPoint/{ids}/Crowding/{line}</param>
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>
        List<TflApiPresentationEntitiesStopPoint> StopPointGet (List<string> ids, bool? includeCrowdingData);
        /// <summary>
        /// Gets a list of StopPoints within {radius} by the specified criteria 
        /// </summary>
        /// <param name="stopTypes">a list of stopTypes that should be returned (a list of valid stop types can be obtained from the StopPoint/meta/stoptypes endpoint)</param>
        /// <param name="locationLat"></param>
        /// <param name="locationLon"></param>
        /// <param name="radius">the radius of the bounding circle in metres (default : 200)</param>
        /// <param name="useStopPointHierarchy">Re-arrange the output into a parent/child hierarchy</param>
        /// <param name="modes">the list of modes to search (comma separated mode names e.g. tube,dlr)</param>
        /// <param name="categories">an optional list of comma separated property categories to return in the StopPoint&#39;s property bag. If null or empty, all categories of property are returned. Pass the keyword \&quot;none\&quot; to return no properties (a valid list of categories can be obtained from the /StopPoint/Meta/categories endpoint)</param>
        /// <param name="returnLines">true to return the lines that each stop point serves as a nested resource</param>
        /// <returns>TflApiPresentationEntitiesStopPointsResponse</returns>
        TflApiPresentationEntitiesStopPointsResponse StopPointGetByGeoPoint (List<string> stopTypes, double? locationLat, double? locationLon, int? radius, bool? useStopPointHierarchy, List<string> modes, List<string> categories, bool? returnLines);
        /// <summary>
        /// Gets a list of StopPoints filtered by the modes available at that StopPoint. 
        /// </summary>
        /// <param name="modes">A comma-seperated list of modes e.g. tube,dlr</param>
        /// <param name="page">The data set page to return. Page 1 equates to the first 1000 stop points, page 2 equates to 1001-2000 etc. Must be entered for bus mode as data set is too large.</param>
        /// <returns>TflApiPresentationEntitiesStopPointsResponse</returns>
        TflApiPresentationEntitiesStopPointsResponse StopPointGetByMode (List<string> modes, int? page);
        /// <summary>
        /// Gets a StopPoint for a given sms code. 
        /// </summary>
        /// <param name="id">A 5-digit Countdown Bus Stop Code e.g. 73241, 50435, 56334.</param>
        /// <param name="output">If set to \&quot;web\&quot;, a 302 redirect to relevant website bus stop page is returned. Valid values are : web. All other values are ignored.</param>
        /// <returns>SystemObject</returns>
        SystemObject StopPointGetBySms (string id, string output);
        /// <summary>
        /// Gets all stop points of a given type 
        /// </summary>
        /// <param name="types">A comma-separated list of the types to return. Max. approx. 12 types.               A list of valid stop types can be obtained from the StopPoint/meta/stoptypes endpoint.</param>
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>
        List<TflApiPresentationEntitiesStopPoint> StopPointGetByType (List<string> types);
        /// <summary>
        /// Gets all the stop points of given type(s) with a page number 
        /// </summary>
        /// <param name="types"></param>
        /// <param name="page"></param>
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>
        List<TflApiPresentationEntitiesStopPoint> StopPointGetByTypeWithPagination (List<string> types, int? page);
        /// <summary>
        /// Get car parks corresponding to the given stop point id. 
        /// </summary>
        /// <param name="stopPointId">stopPointId is required to get the car parks.</param>
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>
        List<TflApiPresentationEntitiesPlace> StopPointGetCarParksById (string stopPointId);
        /// <summary>
        /// Gets the service types for a given stoppoint 
        /// </summary>
        /// <param name="id">The Naptan id of the stop</param>
        /// <param name="lineIds">The lines which contain the given Naptan id (all lines relevant to the given stoppoint if empty)</param>
        /// <param name="modes">The modes which the lines are relevant to (all if empty)</param>
        /// <returns>List&lt;TflApiPresentationEntitiesLineServiceType&gt;</returns>
        List<TflApiPresentationEntitiesLineServiceType> StopPointGetServiceTypes (string id, List<string> lineIds, List<string> modes);
        /// <summary>
        /// Gets a list of taxi ranks corresponding to the given stop point id. 
        /// </summary>
        /// <param name="stopPointId">stopPointId is required to get the taxi ranks.</param>
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>
        List<TflApiPresentationEntitiesPlace> StopPointGetTaxiRanksByIds (string stopPointId);
        /// <summary>
        /// Get a list of places corresponding to a given id and place types. 
        /// </summary>
        /// <param name="id">A naptan id for a stop point (station naptan code e.g. 940GZZLUASL).</param>
        /// <param name="placeTypes">A comcomma-separated value representing the place types.</param>
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>
        List<TflApiPresentationEntitiesPlace> StopPointGet_1 (string id, List<string> placeTypes);
        /// <summary>
        /// Gets the list of available StopPoint additional information categories 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesStopPointCategory&gt;</returns>
        List<TflApiPresentationEntitiesStopPointCategory> StopPointMetaCategories ();
        /// <summary>
        /// Gets the list of available StopPoint modes 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesMode&gt;</returns>
        List<TflApiPresentationEntitiesMode> StopPointMetaModes ();
        /// <summary>
        /// Gets the list of available StopPoint types 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>
        List<string> StopPointMetaStopTypes ();
        /// <summary>
        /// Gets Stopoints that are reachable from a station/line combination. 
        /// </summary>
        /// <param name="id">The id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name) of the stop point to filter by</param>
        /// <param name="lineId">Line id of the line to filter by (e.g. victoria)</param>
        /// <param name="serviceTypes">A comma-separated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param>
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>
        List<TflApiPresentationEntitiesStopPoint> StopPointReachableFrom (string id, string lineId, List<string> serviceTypes);
        /// <summary>
        /// Returns the route sections for all the lines that service the given stop point ids 
        /// </summary>
        /// <param name="id">A stop point id (station naptan codes e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param>
        /// <param name="serviceTypes">A comma-separated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param>
        /// <returns>List&lt;TflApiPresentationEntitiesStopPointRouteSection&gt;</returns>
        List<TflApiPresentationEntitiesStopPointRouteSection> StopPointRoute (string id, List<string> serviceTypes);
        /// <summary>
        /// Search StopPoints by their common name, or their 5-digit Countdown Bus Stop Code. 
        /// </summary>
        /// <param name="query">The query string, case-insensitive. Leading and trailing wildcards are applied automatically.</param>
        /// <param name="modes">An optional, parameter separated list of the modes to filter by</param>
        /// <param name="faresOnly">True to only return stations in that have Fares data available for single fares to another station.</param>
        /// <param name="maxResults">An optional result limit, defaulting to and with a maximum of 50. Since children of the stop point heirarchy are returned for matches,              it is possible that the flattened result set will contain more than 50 items.</param>
        /// <param name="lines">An optional, parameter separated list of the lines to filter by</param>
        /// <param name="includeHubs">If true, returns results including HUBs.</param>
        /// <param name="tflOperatedNationalRailStationsOnly">If the national-rail mode is included, this flag will filter the national rail stations so that only those operated by TfL are returned</param>
        /// <returns>TflApiPresentationEntitiesSearchResponse</returns>
        TflApiPresentationEntitiesSearchResponse StopPointSearch (string query, List<string> modes, bool? faresOnly, int? maxResults, List<string> lines, bool? includeHubs, bool? tflOperatedNationalRailStationsOnly);
        /// <summary>
        /// Search StopPoints by their common name, or their 5-digit Countdown Bus Stop Code. 
        /// </summary>
        /// <param name="query">The query string, case-insensitive. Leading and trailing wildcards are applied automatically.</param>
        /// <param name="modes">An optional, parameter separated list of the modes to filter by</param>
        /// <param name="faresOnly">True to only return stations in that have Fares data available for single fares to another station.</param>
        /// <param name="maxResults">An optional result limit, defaulting to and with a maximum of 50. Since children of the stop point heirarchy are returned for matches,              it is possible that the flattened result set will contain more than 50 items.</param>
        /// <param name="lines">An optional, parameter separated list of the lines to filter by</param>
        /// <param name="includeHubs">If true, returns results including HUBs.</param>
        /// <param name="tflOperatedNationalRailStationsOnly">If the national-rail mode is included, this flag will filter the national rail stations so that only those operated by TfL are returned</param>
        /// <returns>TflApiPresentationEntitiesSearchResponse</returns>
        TflApiPresentationEntitiesSearchResponse StopPointSearch_2 (string query, List<string> modes, bool? faresOnly, int? maxResults, List<string> lines, bool? includeHubs, bool? tflOperatedNationalRailStationsOnly);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class StopPointApi : IStopPointApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StopPointApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public StopPointApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StopPointApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StopPointApi(String basePath)
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
        /// Gets the list of arrival predictions for the given stop point id 
        /// </summary>
        /// <param name="id">A StopPoint id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesPrediction&gt;</returns>            
        public List<TflApiPresentationEntitiesPrediction> StopPointArrivals (string id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StopPointArrivals");
            
    
            var path = "/StopPoint/{id}/Arrivals";
            path = path.Replace("{format}", "json");
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
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointArrivals: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointArrivals: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPrediction>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPrediction>), response.Headers);
        }
    
        /// <summary>
        /// Gets all the Crowding data (static) for the StopPointId, plus crowding data for a given line and optionally a particular direction. 
        /// </summary>
        /// <param name="id">The Naptan id of the stop</param> 
        /// <param name="line">A particular line e.g. victoria, circle, northern etc.</param> 
        /// <param name="direction">The direction of travel. Can be inbound or outbound.</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>            
        public List<TflApiPresentationEntitiesStopPoint> StopPointCrowding (string id, string line, string direction)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StopPointCrowding");
            
            // verify the required parameter 'line' is set
            if (line == null) throw new ApiException(400, "Missing required parameter 'line' when calling StopPointCrowding");
            
            // verify the required parameter 'direction' is set
            if (direction == null) throw new ApiException(400, "Missing required parameter 'direction' when calling StopPointCrowding");
            
    
            var path = "/StopPoint/{id}/Crowding/{line}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "line" + "}", ApiClient.ParameterToString(line));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointCrowding: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointCrowding: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesStopPoint>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesStopPoint>), response.Headers);
        }
    
        /// <summary>
        /// Returns the canonical direction, \&quot;inbound\&quot; or \&quot;outbound\&quot;, for a given pair of stop point Ids in the direction from -&amp;gt; to. 
        /// </summary>
        /// <param name="id">Originating stop id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param> 
        /// <param name="toStopPointId">Destination stop id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param> 
        /// <param name="lineId">Optional line id filter e.g. victoria</param> 
        /// <returns>string</returns>            
        public string StopPointDirection (string id, string toStopPointId, string lineId)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StopPointDirection");
            
            // verify the required parameter 'toStopPointId' is set
            if (toStopPointId == null) throw new ApiException(400, "Missing required parameter 'toStopPointId' when calling StopPointDirection");
            
    
            var path = "/StopPoint/{id}/DirectionTo/{toStopPointId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "toStopPointId" + "}", ApiClient.ParameterToString(toStopPointId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lineId != null) queryParams.Add("lineId", ApiClient.ParameterToString(lineId)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointDirection: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointDirection: " + response.ErrorMessage, response.ErrorMessage);
    
            return (string) ApiClient.Deserialize(response.Content, typeof(string), response.Headers);
        }
    
        /// <summary>
        /// Gets all disruptions for the specified StopPointId, plus disruptions for any child Naptan records it may have. 
        /// </summary>
        /// <param name="ids">A comma-seperated list of stop point ids. Max. approx. 20 ids.              You can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name.</param> 
        /// <param name="getFamily">Specify true to return disruptions for entire family, or false to return disruptions for just this stop point. Defaults to false.</param> 
        /// <param name="includeRouteBlockedStops"></param> 
        /// <param name="flattenResponse">Specify true to associate all disruptions with parent stop point. (Only applicable when getFamily is true).</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesDisruptedPoint&gt;</returns>            
        public List<TflApiPresentationEntitiesDisruptedPoint> StopPointDisruption (List<string> ids, bool? getFamily, bool? includeRouteBlockedStops, bool? flattenResponse)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling StopPointDisruption");
            
    
            var path = "/StopPoint/{ids}/Disruption";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ids" + "}", ApiClient.ParameterToString(ids));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (getFamily != null) queryParams.Add("getFamily", ApiClient.ParameterToString(getFamily)); // query parameter
 if (includeRouteBlockedStops != null) queryParams.Add("includeRouteBlockedStops", ApiClient.ParameterToString(includeRouteBlockedStops)); // query parameter
 if (flattenResponse != null) queryParams.Add("flattenResponse", ApiClient.ParameterToString(flattenResponse)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointDisruption: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointDisruption: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesDisruptedPoint>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesDisruptedPoint>), response.Headers);
        }
    
        /// <summary>
        /// Gets a distinct list of disrupted stop points for the given modes 
        /// </summary>
        /// <param name="modes">A comma-seperated list of modes e.g. tube,dlr</param> 
        /// <param name="includeRouteBlockedStops"></param> 
        /// <returns>List&lt;TflApiPresentationEntitiesDisruptedPoint&gt;</returns>            
        public List<TflApiPresentationEntitiesDisruptedPoint> StopPointDisruptionByMode (List<string> modes, bool? includeRouteBlockedStops)
        {
            
            // verify the required parameter 'modes' is set
            if (modes == null) throw new ApiException(400, "Missing required parameter 'modes' when calling StopPointDisruptionByMode");
            
    
            var path = "/StopPoint/Mode/{modes}/Disruption";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "modes" + "}", ApiClient.ParameterToString(modes));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeRouteBlockedStops != null) queryParams.Add("includeRouteBlockedStops", ApiClient.ParameterToString(includeRouteBlockedStops)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointDisruptionByMode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointDisruptionByMode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesDisruptedPoint>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesDisruptedPoint>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of StopPoints corresponding to the given list of stop ids. 
        /// </summary>
        /// <param name="ids">A comma-separated list of stop point ids (station naptan code e.g. 940GZZLUASL). Max. approx. 20 ids.              You can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name.</param> 
        /// <param name="includeCrowdingData">Include the crowding data (static). To Filter further use: /StopPoint/{ids}/Crowding/{line}</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>            
        public List<TflApiPresentationEntitiesStopPoint> StopPointGet (List<string> ids, bool? includeCrowdingData)
        {
            
            // verify the required parameter 'ids' is set
            if (ids == null) throw new ApiException(400, "Missing required parameter 'ids' when calling StopPointGet");
            
    
            var path = "/StopPoint/{ids}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "ids" + "}", ApiClient.ParameterToString(ids));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeCrowdingData != null) queryParams.Add("includeCrowdingData", ApiClient.ParameterToString(includeCrowdingData)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesStopPoint>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesStopPoint>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of StopPoints within {radius} by the specified criteria 
        /// </summary>
        /// <param name="stopTypes">a list of stopTypes that should be returned (a list of valid stop types can be obtained from the StopPoint/meta/stoptypes endpoint)</param> 
        /// <param name="locationLat"></param> 
        /// <param name="locationLon"></param> 
        /// <param name="radius">the radius of the bounding circle in metres (default : 200)</param> 
        /// <param name="useStopPointHierarchy">Re-arrange the output into a parent/child hierarchy</param> 
        /// <param name="modes">the list of modes to search (comma separated mode names e.g. tube,dlr)</param> 
        /// <param name="categories">an optional list of comma separated property categories to return in the StopPoint&#39;s property bag. If null or empty, all categories of property are returned. Pass the keyword \&quot;none\&quot; to return no properties (a valid list of categories can be obtained from the /StopPoint/Meta/categories endpoint)</param> 
        /// <param name="returnLines">true to return the lines that each stop point serves as a nested resource</param> 
        /// <returns>TflApiPresentationEntitiesStopPointsResponse</returns>            
        public TflApiPresentationEntitiesStopPointsResponse StopPointGetByGeoPoint (List<string> stopTypes, double? locationLat, double? locationLon, int? radius, bool? useStopPointHierarchy, List<string> modes, List<string> categories, bool? returnLines)
        {
            
            // verify the required parameter 'stopTypes' is set
            if (stopTypes == null) throw new ApiException(400, "Missing required parameter 'stopTypes' when calling StopPointGetByGeoPoint");
            
            // verify the required parameter 'locationLat' is set
            if (locationLat == null) throw new ApiException(400, "Missing required parameter 'locationLat' when calling StopPointGetByGeoPoint");
            
            // verify the required parameter 'locationLon' is set
            if (locationLon == null) throw new ApiException(400, "Missing required parameter 'locationLon' when calling StopPointGetByGeoPoint");
            
    
            var path = "/StopPoint";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (stopTypes != null) queryParams.Add("stopTypes", ApiClient.ParameterToString(stopTypes)); // query parameter
 if (radius != null) queryParams.Add("radius", ApiClient.ParameterToString(radius)); // query parameter
 if (useStopPointHierarchy != null) queryParams.Add("useStopPointHierarchy", ApiClient.ParameterToString(useStopPointHierarchy)); // query parameter
 if (modes != null) queryParams.Add("modes", ApiClient.ParameterToString(modes)); // query parameter
 if (categories != null) queryParams.Add("categories", ApiClient.ParameterToString(categories)); // query parameter
 if (returnLines != null) queryParams.Add("returnLines", ApiClient.ParameterToString(returnLines)); // query parameter
 if (locationLat != null) queryParams.Add("location.lat", ApiClient.ParameterToString(locationLat)); // query parameter
 if (locationLon != null) queryParams.Add("location.lon", ApiClient.ParameterToString(locationLon)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetByGeoPoint: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetByGeoPoint: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesStopPointsResponse) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesStopPointsResponse), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of StopPoints filtered by the modes available at that StopPoint. 
        /// </summary>
        /// <param name="modes">A comma-seperated list of modes e.g. tube,dlr</param> 
        /// <param name="page">The data set page to return. Page 1 equates to the first 1000 stop points, page 2 equates to 1001-2000 etc. Must be entered for bus mode as data set is too large.</param> 
        /// <returns>TflApiPresentationEntitiesStopPointsResponse</returns>            
        public TflApiPresentationEntitiesStopPointsResponse StopPointGetByMode (List<string> modes, int? page)
        {
            
            // verify the required parameter 'modes' is set
            if (modes == null) throw new ApiException(400, "Missing required parameter 'modes' when calling StopPointGetByMode");
            
    
            var path = "/StopPoint/Mode/{modes}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "modes" + "}", ApiClient.ParameterToString(modes));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetByMode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetByMode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesStopPointsResponse) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesStopPointsResponse), response.Headers);
        }
    
        /// <summary>
        /// Gets a StopPoint for a given sms code. 
        /// </summary>
        /// <param name="id">A 5-digit Countdown Bus Stop Code e.g. 73241, 50435, 56334.</param> 
        /// <param name="output">If set to \&quot;web\&quot;, a 302 redirect to relevant website bus stop page is returned. Valid values are : web. All other values are ignored.</param> 
        /// <returns>SystemObject</returns>            
        public SystemObject StopPointGetBySms (string id, string output)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StopPointGetBySms");
            
    
            var path = "/StopPoint/Sms/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (output != null) queryParams.Add("output", ApiClient.ParameterToString(output)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetBySms: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetBySms: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SystemObject) ApiClient.Deserialize(response.Content, typeof(SystemObject), response.Headers);
        }
    
        /// <summary>
        /// Gets all stop points of a given type 
        /// </summary>
        /// <param name="types">A comma-separated list of the types to return. Max. approx. 12 types.               A list of valid stop types can be obtained from the StopPoint/meta/stoptypes endpoint.</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>            
        public List<TflApiPresentationEntitiesStopPoint> StopPointGetByType (List<string> types)
        {
            
            // verify the required parameter 'types' is set
            if (types == null) throw new ApiException(400, "Missing required parameter 'types' when calling StopPointGetByType");
            
    
            var path = "/StopPoint/Type/{types}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "types" + "}", ApiClient.ParameterToString(types));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetByType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetByType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesStopPoint>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesStopPoint>), response.Headers);
        }
    
        /// <summary>
        /// Gets all the stop points of given type(s) with a page number 
        /// </summary>
        /// <param name="types"></param> 
        /// <param name="page"></param> 
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>            
        public List<TflApiPresentationEntitiesStopPoint> StopPointGetByTypeWithPagination (List<string> types, int? page)
        {
            
            // verify the required parameter 'types' is set
            if (types == null) throw new ApiException(400, "Missing required parameter 'types' when calling StopPointGetByTypeWithPagination");
            
            // verify the required parameter 'page' is set
            if (page == null) throw new ApiException(400, "Missing required parameter 'page' when calling StopPointGetByTypeWithPagination");
            
    
            var path = "/StopPoint/Type/{types}/page/{page}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "types" + "}", ApiClient.ParameterToString(types));
path = path.Replace("{" + "page" + "}", ApiClient.ParameterToString(page));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetByTypeWithPagination: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetByTypeWithPagination: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesStopPoint>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesStopPoint>), response.Headers);
        }
    
        /// <summary>
        /// Get car parks corresponding to the given stop point id. 
        /// </summary>
        /// <param name="stopPointId">stopPointId is required to get the car parks.</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>            
        public List<TflApiPresentationEntitiesPlace> StopPointGetCarParksById (string stopPointId)
        {
            
            // verify the required parameter 'stopPointId' is set
            if (stopPointId == null) throw new ApiException(400, "Missing required parameter 'stopPointId' when calling StopPointGetCarParksById");
            
    
            var path = "/StopPoint/{stopPointId}/CarParks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stopPointId" + "}", ApiClient.ParameterToString(stopPointId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetCarParksById: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetCarParksById: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPlace>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPlace>), response.Headers);
        }
    
        /// <summary>
        /// Gets the service types for a given stoppoint 
        /// </summary>
        /// <param name="id">The Naptan id of the stop</param> 
        /// <param name="lineIds">The lines which contain the given Naptan id (all lines relevant to the given stoppoint if empty)</param> 
        /// <param name="modes">The modes which the lines are relevant to (all if empty)</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesLineServiceType&gt;</returns>            
        public List<TflApiPresentationEntitiesLineServiceType> StopPointGetServiceTypes (string id, List<string> lineIds, List<string> modes)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StopPointGetServiceTypes");
            
    
            var path = "/StopPoint/ServiceTypes";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (id != null) queryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
 if (lineIds != null) queryParams.Add("lineIds", ApiClient.ParameterToString(lineIds)); // query parameter
 if (modes != null) queryParams.Add("modes", ApiClient.ParameterToString(modes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetServiceTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetServiceTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesLineServiceType>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesLineServiceType>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of taxi ranks corresponding to the given stop point id. 
        /// </summary>
        /// <param name="stopPointId">stopPointId is required to get the taxi ranks.</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>            
        public List<TflApiPresentationEntitiesPlace> StopPointGetTaxiRanksByIds (string stopPointId)
        {
            
            // verify the required parameter 'stopPointId' is set
            if (stopPointId == null) throw new ApiException(400, "Missing required parameter 'stopPointId' when calling StopPointGetTaxiRanksByIds");
            
    
            var path = "/StopPoint/{stopPointId}/TaxiRanks";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "stopPointId" + "}", ApiClient.ParameterToString(stopPointId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetTaxiRanksByIds: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGetTaxiRanksByIds: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPlace>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPlace>), response.Headers);
        }
    
        /// <summary>
        /// Get a list of places corresponding to a given id and place types. 
        /// </summary>
        /// <param name="id">A naptan id for a stop point (station naptan code e.g. 940GZZLUASL).</param> 
        /// <param name="placeTypes">A comcomma-separated value representing the place types.</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>            
        public List<TflApiPresentationEntitiesPlace> StopPointGet_1 (string id, List<string> placeTypes)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StopPointGet_1");
            
            // verify the required parameter 'placeTypes' is set
            if (placeTypes == null) throw new ApiException(400, "Missing required parameter 'placeTypes' when calling StopPointGet_1");
            
    
            var path = "/StopPoint/{id}/placeTypes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (placeTypes != null) queryParams.Add("placeTypes", ApiClient.ParameterToString(placeTypes)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGet_1: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointGet_1: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPlace>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPlace>), response.Headers);
        }
    
        /// <summary>
        /// Gets the list of available StopPoint additional information categories 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesStopPointCategory&gt;</returns>            
        public List<TflApiPresentationEntitiesStopPointCategory> StopPointMetaCategories ()
        {
            
    
            var path = "/StopPoint/Meta/Categories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointMetaCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointMetaCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesStopPointCategory>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesStopPointCategory>), response.Headers);
        }
    
        /// <summary>
        /// Gets the list of available StopPoint modes 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesMode&gt;</returns>            
        public List<TflApiPresentationEntitiesMode> StopPointMetaModes ()
        {
            
    
            var path = "/StopPoint/Meta/Modes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointMetaModes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointMetaModes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesMode>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesMode>), response.Headers);
        }
    
        /// <summary>
        /// Gets the list of available StopPoint types 
        /// </summary>
        /// <returns>List&lt;string&gt;</returns>            
        public List<string> StopPointMetaStopTypes ()
        {
            
    
            var path = "/StopPoint/Meta/StopTypes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointMetaStopTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointMetaStopTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<string>) ApiClient.Deserialize(response.Content, typeof(List<string>), response.Headers);
        }
    
        /// <summary>
        /// Gets Stopoints that are reachable from a station/line combination. 
        /// </summary>
        /// <param name="id">The id (station naptan code e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name) of the stop point to filter by</param> 
        /// <param name="lineId">Line id of the line to filter by (e.g. victoria)</param> 
        /// <param name="serviceTypes">A comma-separated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>            
        public List<TflApiPresentationEntitiesStopPoint> StopPointReachableFrom (string id, string lineId, List<string> serviceTypes)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StopPointReachableFrom");
            
            // verify the required parameter 'lineId' is set
            if (lineId == null) throw new ApiException(400, "Missing required parameter 'lineId' when calling StopPointReachableFrom");
            
    
            var path = "/StopPoint/{id}/CanReachOnLine/{lineId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
path = path.Replace("{" + "lineId" + "}", ApiClient.ParameterToString(lineId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointReachableFrom: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointReachableFrom: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesStopPoint>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesStopPoint>), response.Headers);
        }
    
        /// <summary>
        /// Returns the route sections for all the lines that service the given stop point ids 
        /// </summary>
        /// <param name="id">A stop point id (station naptan codes e.g. 940GZZLUASL, you can use /StopPoint/Search/{query} endpoint to find a stop point id from a station name)</param> 
        /// <param name="serviceTypes">A comma-separated list of service types to filter on. If not specified. Supported values: Regular, Night. Defaulted to &#39;Regular&#39; if not specified</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesStopPointRouteSection&gt;</returns>            
        public List<TflApiPresentationEntitiesStopPointRouteSection> StopPointRoute (string id, List<string> serviceTypes)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling StopPointRoute");
            
    
            var path = "/StopPoint/{id}/Route";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointRoute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointRoute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesStopPointRouteSection>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesStopPointRouteSection>), response.Headers);
        }
    
        /// <summary>
        /// Search StopPoints by their common name, or their 5-digit Countdown Bus Stop Code. 
        /// </summary>
        /// <param name="query">The query string, case-insensitive. Leading and trailing wildcards are applied automatically.</param> 
        /// <param name="modes">An optional, parameter separated list of the modes to filter by</param> 
        /// <param name="faresOnly">True to only return stations in that have Fares data available for single fares to another station.</param> 
        /// <param name="maxResults">An optional result limit, defaulting to and with a maximum of 50. Since children of the stop point heirarchy are returned for matches,              it is possible that the flattened result set will contain more than 50 items.</param> 
        /// <param name="lines">An optional, parameter separated list of the lines to filter by</param> 
        /// <param name="includeHubs">If true, returns results including HUBs.</param> 
        /// <param name="tflOperatedNationalRailStationsOnly">If the national-rail mode is included, this flag will filter the national rail stations so that only those operated by TfL are returned</param> 
        /// <returns>TflApiPresentationEntitiesSearchResponse</returns>            
        public TflApiPresentationEntitiesSearchResponse StopPointSearch (string query, List<string> modes, bool? faresOnly, int? maxResults, List<string> lines, bool? includeHubs, bool? tflOperatedNationalRailStationsOnly)
        {
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling StopPointSearch");
            
    
            var path = "/StopPoint/Search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (query != null) queryParams.Add("query", ApiClient.ParameterToString(query)); // query parameter
 if (modes != null) queryParams.Add("modes", ApiClient.ParameterToString(modes)); // query parameter
 if (faresOnly != null) queryParams.Add("faresOnly", ApiClient.ParameterToString(faresOnly)); // query parameter
 if (maxResults != null) queryParams.Add("maxResults", ApiClient.ParameterToString(maxResults)); // query parameter
 if (lines != null) queryParams.Add("lines", ApiClient.ParameterToString(lines)); // query parameter
 if (includeHubs != null) queryParams.Add("includeHubs", ApiClient.ParameterToString(includeHubs)); // query parameter
 if (tflOperatedNationalRailStationsOnly != null) queryParams.Add("tflOperatedNationalRailStationsOnly", ApiClient.ParameterToString(tflOperatedNationalRailStationsOnly)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesSearchResponse) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesSearchResponse), response.Headers);
        }
    
        /// <summary>
        /// Search StopPoints by their common name, or their 5-digit Countdown Bus Stop Code. 
        /// </summary>
        /// <param name="query">The query string, case-insensitive. Leading and trailing wildcards are applied automatically.</param> 
        /// <param name="modes">An optional, parameter separated list of the modes to filter by</param> 
        /// <param name="faresOnly">True to only return stations in that have Fares data available for single fares to another station.</param> 
        /// <param name="maxResults">An optional result limit, defaulting to and with a maximum of 50. Since children of the stop point heirarchy are returned for matches,              it is possible that the flattened result set will contain more than 50 items.</param> 
        /// <param name="lines">An optional, parameter separated list of the lines to filter by</param> 
        /// <param name="includeHubs">If true, returns results including HUBs.</param> 
        /// <param name="tflOperatedNationalRailStationsOnly">If the national-rail mode is included, this flag will filter the national rail stations so that only those operated by TfL are returned</param> 
        /// <returns>TflApiPresentationEntitiesSearchResponse</returns>            
        public TflApiPresentationEntitiesSearchResponse StopPointSearch_2 (string query, List<string> modes, bool? faresOnly, int? maxResults, List<string> lines, bool? includeHubs, bool? tflOperatedNationalRailStationsOnly)
        {
            
            // verify the required parameter 'query' is set
            if (query == null) throw new ApiException(400, "Missing required parameter 'query' when calling StopPointSearch_2");
            
    
            var path = "/StopPoint/Search/{query}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "query" + "}", ApiClient.ParameterToString(query));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (modes != null) queryParams.Add("modes", ApiClient.ParameterToString(modes)); // query parameter
 if (faresOnly != null) queryParams.Add("faresOnly", ApiClient.ParameterToString(faresOnly)); // query parameter
 if (maxResults != null) queryParams.Add("maxResults", ApiClient.ParameterToString(maxResults)); // query parameter
 if (lines != null) queryParams.Add("lines", ApiClient.ParameterToString(lines)); // query parameter
 if (includeHubs != null) queryParams.Add("includeHubs", ApiClient.ParameterToString(includeHubs)); // query parameter
 if (tflOperatedNationalRailStationsOnly != null) queryParams.Add("tflOperatedNationalRailStationsOnly", ApiClient.ParameterToString(tflOperatedNationalRailStationsOnly)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "app_key", "app_id" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointSearch_2: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling StopPointSearch_2: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesSearchResponse) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesSearchResponse), response.Headers);
        }
    
    }
}
