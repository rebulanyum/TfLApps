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
    public interface IJourneyApi
    {
        /// <summary>
        /// Perform a Journey Planner search from the parameters specified in simple types 
        /// </summary>
        /// <param name="from">Origin of the journey. Can be WGS84 coordinates expressed as \&quot;lat,long\&quot;, a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).</param>
        /// <param name="to">Destination of the journey. Can be WGS84 coordinates expressed as \&quot;lat,long\&quot;, a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).</param>
        /// <param name="via">Travel through point on the journey. Can be WGS84 coordinates expressed as \&quot;lat,long\&quot;, a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).</param>
        /// <param name="nationalSearch">Does the journey cover stops outside London? eg. \&quot;nationalSearch&#x3D;true\&quot;</param>
        /// <param name="date">The date must be in yyyyMMdd format</param>
        /// <param name="time">The time must be in HHmm format</param>
        /// <param name="timeIs">Does the time given relate to arrival or leaving time? Possible options: \&quot;departing\&quot; | \&quot;arriving\&quot;</param>
        /// <param name="journeyPreference">The journey preference eg possible options: \&quot;leastinterchange\&quot; | \&quot;leasttime\&quot; | \&quot;leastwalking\&quot;</param>
        /// <param name="mode">The mode must be a comma separated list of modes. eg possible options: \&quot;public-bus,overground,train,tube,coach,dlr,cablecar,tram,river,walking,cycle\&quot;</param>
        /// <param name="accessibilityPreference">The accessibility preference must be a comma separated list eg. \&quot;noSolidStairs,noEscalators,noElevators,stepFreeToVehicle,stepFreeToPlatform\&quot;</param>
        /// <param name="fromName">An optional name to associate with the origin of the journey in the results.</param>
        /// <param name="toName">An optional name to associate with the destination of the journey in the results.</param>
        /// <param name="viaName">An optional name to associate with the via point of the journey in the results.</param>
        /// <param name="maxTransferMinutes">The max walking time in minutes for transfer eg. \&quot;120\&quot;</param>
        /// <param name="maxWalkingMinutes">The max walking time in minutes for journeys eg. \&quot;120\&quot;</param>
        /// <param name="walkingSpeed">The walking speed. eg possible options: \&quot;slow\&quot; | \&quot;average\&quot; | \&quot;fast\&quot;.</param>
        /// <param name="cyclePreference">The cycle preference. eg possible options: \&quot;allTheWay\&quot; | \&quot;leaveAtStation\&quot; | \&quot;takeOnTransport\&quot; | \&quot;cycleHire\&quot;</param>
        /// <param name="adjustment">Time adjustment command. eg possible options: \&quot;TripFirst\&quot; | \&quot;TripLast\&quot;</param>
        /// <param name="bikeProficiency">A comma separated list of cycling proficiency levels. eg possible options: \&quot;easy,moderate,fast\&quot;</param>
        /// <param name="alternativeCycle">Option to determine whether to return alternative cycling journey</param>
        /// <param name="alternativeWalking">Option to determine whether to return alternative walking journey</param>
        /// <param name="applyHtmlMarkup">Flag to determine whether certain text (e.g. walking instructions) should be output with HTML tags or not.</param>
        /// <param name="useMultiModalCall">A boolean to indicate whether or not to return 3 public transport journeys, a bus journey, a cycle hire journey, a personal cycle journey and a walking journey</param>
        /// <param name="walkingOptimization">A boolean to indicate whether to optimize journeys using walking</param>
        /// <param name="taxiOnlyTrip">A boolean to indicate whether to return one or more taxi journeys. Note, setting this to true will override \&quot;useMultiModalCall\&quot;.</param>
        /// <returns>TflApiPresentationEntitiesJourneyPlannerItineraryResult</returns>
        TflApiPresentationEntitiesJourneyPlannerItineraryResult JourneyJourneyResults (string from, string to, string via, bool? nationalSearch, string date, string time, string timeIs, string journeyPreference, List<string> mode, List<string> accessibilityPreference, string fromName, string toName, string viaName, string maxTransferMinutes, string maxWalkingMinutes, string walkingSpeed, string cyclePreference, string adjustment, List<string> bikeProficiency, bool? alternativeCycle, bool? alternativeWalking, bool? applyHtmlMarkup, bool? useMultiModalCall, bool? walkingOptimization, bool? taxiOnlyTrip);
        /// <summary>
        /// Gets a list of all of the available journey planner modes 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesMode&gt;</returns>
        List<TflApiPresentationEntitiesMode> JourneyMeta ();
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class JourneyApi : IJourneyApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public JourneyApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="JourneyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public JourneyApi(String basePath)
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
        /// Perform a Journey Planner search from the parameters specified in simple types 
        /// </summary>
        /// <param name="from">Origin of the journey. Can be WGS84 coordinates expressed as \&quot;lat,long\&quot;, a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).</param> 
        /// <param name="to">Destination of the journey. Can be WGS84 coordinates expressed as \&quot;lat,long\&quot;, a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).</param> 
        /// <param name="via">Travel through point on the journey. Can be WGS84 coordinates expressed as \&quot;lat,long\&quot;, a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).</param> 
        /// <param name="nationalSearch">Does the journey cover stops outside London? eg. \&quot;nationalSearch&#x3D;true\&quot;</param> 
        /// <param name="date">The date must be in yyyyMMdd format</param> 
        /// <param name="time">The time must be in HHmm format</param> 
        /// <param name="timeIs">Does the time given relate to arrival or leaving time? Possible options: \&quot;departing\&quot; | \&quot;arriving\&quot;</param> 
        /// <param name="journeyPreference">The journey preference eg possible options: \&quot;leastinterchange\&quot; | \&quot;leasttime\&quot; | \&quot;leastwalking\&quot;</param> 
        /// <param name="mode">The mode must be a comma separated list of modes. eg possible options: \&quot;public-bus,overground,train,tube,coach,dlr,cablecar,tram,river,walking,cycle\&quot;</param> 
        /// <param name="accessibilityPreference">The accessibility preference must be a comma separated list eg. \&quot;noSolidStairs,noEscalators,noElevators,stepFreeToVehicle,stepFreeToPlatform\&quot;</param> 
        /// <param name="fromName">An optional name to associate with the origin of the journey in the results.</param> 
        /// <param name="toName">An optional name to associate with the destination of the journey in the results.</param> 
        /// <param name="viaName">An optional name to associate with the via point of the journey in the results.</param> 
        /// <param name="maxTransferMinutes">The max walking time in minutes for transfer eg. \&quot;120\&quot;</param> 
        /// <param name="maxWalkingMinutes">The max walking time in minutes for journeys eg. \&quot;120\&quot;</param> 
        /// <param name="walkingSpeed">The walking speed. eg possible options: \&quot;slow\&quot; | \&quot;average\&quot; | \&quot;fast\&quot;.</param> 
        /// <param name="cyclePreference">The cycle preference. eg possible options: \&quot;allTheWay\&quot; | \&quot;leaveAtStation\&quot; | \&quot;takeOnTransport\&quot; | \&quot;cycleHire\&quot;</param> 
        /// <param name="adjustment">Time adjustment command. eg possible options: \&quot;TripFirst\&quot; | \&quot;TripLast\&quot;</param> 
        /// <param name="bikeProficiency">A comma separated list of cycling proficiency levels. eg possible options: \&quot;easy,moderate,fast\&quot;</param> 
        /// <param name="alternativeCycle">Option to determine whether to return alternative cycling journey</param> 
        /// <param name="alternativeWalking">Option to determine whether to return alternative walking journey</param> 
        /// <param name="applyHtmlMarkup">Flag to determine whether certain text (e.g. walking instructions) should be output with HTML tags or not.</param> 
        /// <param name="useMultiModalCall">A boolean to indicate whether or not to return 3 public transport journeys, a bus journey, a cycle hire journey, a personal cycle journey and a walking journey</param> 
        /// <param name="walkingOptimization">A boolean to indicate whether to optimize journeys using walking</param> 
        /// <param name="taxiOnlyTrip">A boolean to indicate whether to return one or more taxi journeys. Note, setting this to true will override \&quot;useMultiModalCall\&quot;.</param> 
        /// <returns>TflApiPresentationEntitiesJourneyPlannerItineraryResult</returns>            
        public TflApiPresentationEntitiesJourneyPlannerItineraryResult JourneyJourneyResults (string from, string to, string via, bool? nationalSearch, string date, string time, string timeIs, string journeyPreference, List<string> mode, List<string> accessibilityPreference, string fromName, string toName, string viaName, string maxTransferMinutes, string maxWalkingMinutes, string walkingSpeed, string cyclePreference, string adjustment, List<string> bikeProficiency, bool? alternativeCycle, bool? alternativeWalking, bool? applyHtmlMarkup, bool? useMultiModalCall, bool? walkingOptimization, bool? taxiOnlyTrip)
        {
            
            // verify the required parameter 'from' is set
            if (from == null) throw new ApiException(400, "Missing required parameter 'from' when calling JourneyJourneyResults");
            
            // verify the required parameter 'to' is set
            if (to == null) throw new ApiException(400, "Missing required parameter 'to' when calling JourneyJourneyResults");
            
    
            var path = "/Journey/JourneyResults/{from}/to/{to}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "from" + "}", ApiClient.ParameterToString(from));
path = path.Replace("{" + "to" + "}", ApiClient.ParameterToString(to));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (via != null) queryParams.Add("via", ApiClient.ParameterToString(via)); // query parameter
 if (nationalSearch != null) queryParams.Add("nationalSearch", ApiClient.ParameterToString(nationalSearch)); // query parameter
 if (date != null) queryParams.Add("date", ApiClient.ParameterToString(date)); // query parameter
 if (time != null) queryParams.Add("time", ApiClient.ParameterToString(time)); // query parameter
 if (timeIs != null) queryParams.Add("timeIs", ApiClient.ParameterToString(timeIs)); // query parameter
 if (journeyPreference != null) queryParams.Add("journeyPreference", ApiClient.ParameterToString(journeyPreference)); // query parameter
 if (mode != null) queryParams.Add("mode", ApiClient.ParameterToString(mode)); // query parameter
 if (accessibilityPreference != null) queryParams.Add("accessibilityPreference", ApiClient.ParameterToString(accessibilityPreference)); // query parameter
 if (fromName != null) queryParams.Add("fromName", ApiClient.ParameterToString(fromName)); // query parameter
 if (toName != null) queryParams.Add("toName", ApiClient.ParameterToString(toName)); // query parameter
 if (viaName != null) queryParams.Add("viaName", ApiClient.ParameterToString(viaName)); // query parameter
 if (maxTransferMinutes != null) queryParams.Add("maxTransferMinutes", ApiClient.ParameterToString(maxTransferMinutes)); // query parameter
 if (maxWalkingMinutes != null) queryParams.Add("maxWalkingMinutes", ApiClient.ParameterToString(maxWalkingMinutes)); // query parameter
 if (walkingSpeed != null) queryParams.Add("walkingSpeed", ApiClient.ParameterToString(walkingSpeed)); // query parameter
 if (cyclePreference != null) queryParams.Add("cyclePreference", ApiClient.ParameterToString(cyclePreference)); // query parameter
 if (adjustment != null) queryParams.Add("adjustment", ApiClient.ParameterToString(adjustment)); // query parameter
 if (bikeProficiency != null) queryParams.Add("bikeProficiency", ApiClient.ParameterToString(bikeProficiency)); // query parameter
 if (alternativeCycle != null) queryParams.Add("alternativeCycle", ApiClient.ParameterToString(alternativeCycle)); // query parameter
 if (alternativeWalking != null) queryParams.Add("alternativeWalking", ApiClient.ParameterToString(alternativeWalking)); // query parameter
 if (applyHtmlMarkup != null) queryParams.Add("applyHtmlMarkup", ApiClient.ParameterToString(applyHtmlMarkup)); // query parameter
 if (useMultiModalCall != null) queryParams.Add("useMultiModalCall", ApiClient.ParameterToString(useMultiModalCall)); // query parameter
 if (walkingOptimization != null) queryParams.Add("walkingOptimization", ApiClient.ParameterToString(walkingOptimization)); // query parameter
 if (taxiOnlyTrip != null) queryParams.Add("taxiOnlyTrip", ApiClient.ParameterToString(taxiOnlyTrip)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKey", "appId" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling JourneyJourneyResults: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling JourneyJourneyResults: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TflApiPresentationEntitiesJourneyPlannerItineraryResult) ApiClient.Deserialize(response.Content, typeof(TflApiPresentationEntitiesJourneyPlannerItineraryResult), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of all of the available journey planner modes 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesMode&gt;</returns>            
        public List<TflApiPresentationEntitiesMode> JourneyMeta ()
        {
            
    
            var path = "/Journey/Meta/Modes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling JourneyMeta: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling JourneyMeta: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesMode>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesMode>), response.Headers);
        }
    
    }
}
