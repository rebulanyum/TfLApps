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
    public interface ITravelTimeApi
    {
        /// <summary>
        /// Gets the TravelTime overlay. 
        /// </summary>
        /// <param name="z">The zoom level.</param>
        /// <param name="pinLat">The latitude of the pin.</param>
        /// <param name="pinLon">The longitude of the pin.</param>
        /// <param name="mapCenterLat">The map center latitude.</param>
        /// <param name="mapCenterLon">The map center longitude.</param>
        /// <param name="scenarioTitle">The title of the scenario.</param>
        /// <param name="timeOfDayId">The id for the time of day (AM/INTER/PM)</param>
        /// <param name="modeId">The id of the mode.</param>
        /// <param name="width">The width of the requested overlay.</param>
        /// <param name="height">The height of the requested overlay.</param>
        /// <param name="direction">The direction of travel.</param>
        /// <param name="travelTimeInterval">The total minutes between the travel time bands</param>
        /// <param name="compareType"></param>
        /// <param name="compareValue"></param>
        /// <returns>SystemObject</returns>
        SystemObject TravelTimeGetCompareOverlay (int? z, double? pinLat, double? pinLon, double? mapCenterLat, double? mapCenterLon, string scenarioTitle, string timeOfDayId, string modeId, int? width, int? height, string direction, int? travelTimeInterval, string compareType, string compareValue);
        /// <summary>
        /// Gets the TravelTime overlay. 
        /// </summary>
        /// <param name="z">The zoom level.</param>
        /// <param name="pinLat">The latitude of the pin.</param>
        /// <param name="pinLon">The longitude of the pin.</param>
        /// <param name="mapCenterLat">The map center latitude.</param>
        /// <param name="mapCenterLon">The map center longitude.</param>
        /// <param name="scenarioTitle">The title of the scenario.</param>
        /// <param name="timeOfDayId">The id for the time of day (AM/INTER/PM)</param>
        /// <param name="modeId">The id of the mode.</param>
        /// <param name="width">The width of the requested overlay.</param>
        /// <param name="height">The height of the requested overlay.</param>
        /// <param name="direction">The direction of travel.</param>
        /// <param name="travelTimeInterval">The total minutes between the travel time bands</param>
        /// <returns>SystemObject</returns>
        SystemObject TravelTimeGetOverlay (int? z, double? pinLat, double? pinLon, double? mapCenterLat, double? mapCenterLon, string scenarioTitle, string timeOfDayId, string modeId, int? width, int? height, string direction, int? travelTimeInterval);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TravelTimeApi : ITravelTimeApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TravelTimeApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TravelTimeApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TravelTimeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TravelTimeApi(String basePath)
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
        /// Gets the TravelTime overlay. 
        /// </summary>
        /// <param name="z">The zoom level.</param> 
        /// <param name="pinLat">The latitude of the pin.</param> 
        /// <param name="pinLon">The longitude of the pin.</param> 
        /// <param name="mapCenterLat">The map center latitude.</param> 
        /// <param name="mapCenterLon">The map center longitude.</param> 
        /// <param name="scenarioTitle">The title of the scenario.</param> 
        /// <param name="timeOfDayId">The id for the time of day (AM/INTER/PM)</param> 
        /// <param name="modeId">The id of the mode.</param> 
        /// <param name="width">The width of the requested overlay.</param> 
        /// <param name="height">The height of the requested overlay.</param> 
        /// <param name="direction">The direction of travel.</param> 
        /// <param name="travelTimeInterval">The total minutes between the travel time bands</param> 
        /// <param name="compareType"></param> 
        /// <param name="compareValue"></param> 
        /// <returns>SystemObject</returns>            
        public SystemObject TravelTimeGetCompareOverlay (int? z, double? pinLat, double? pinLon, double? mapCenterLat, double? mapCenterLon, string scenarioTitle, string timeOfDayId, string modeId, int? width, int? height, string direction, int? travelTimeInterval, string compareType, string compareValue)
        {
            
            // verify the required parameter 'z' is set
            if (z == null) throw new ApiException(400, "Missing required parameter 'z' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'pinLat' is set
            if (pinLat == null) throw new ApiException(400, "Missing required parameter 'pinLat' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'pinLon' is set
            if (pinLon == null) throw new ApiException(400, "Missing required parameter 'pinLon' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'mapCenterLat' is set
            if (mapCenterLat == null) throw new ApiException(400, "Missing required parameter 'mapCenterLat' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'mapCenterLon' is set
            if (mapCenterLon == null) throw new ApiException(400, "Missing required parameter 'mapCenterLon' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'scenarioTitle' is set
            if (scenarioTitle == null) throw new ApiException(400, "Missing required parameter 'scenarioTitle' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'timeOfDayId' is set
            if (timeOfDayId == null) throw new ApiException(400, "Missing required parameter 'timeOfDayId' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'modeId' is set
            if (modeId == null) throw new ApiException(400, "Missing required parameter 'modeId' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'width' is set
            if (width == null) throw new ApiException(400, "Missing required parameter 'width' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'height' is set
            if (height == null) throw new ApiException(400, "Missing required parameter 'height' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'direction' is set
            if (direction == null) throw new ApiException(400, "Missing required parameter 'direction' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'travelTimeInterval' is set
            if (travelTimeInterval == null) throw new ApiException(400, "Missing required parameter 'travelTimeInterval' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'compareType' is set
            if (compareType == null) throw new ApiException(400, "Missing required parameter 'compareType' when calling TravelTimeGetCompareOverlay");
            
            // verify the required parameter 'compareValue' is set
            if (compareValue == null) throw new ApiException(400, "Missing required parameter 'compareValue' when calling TravelTimeGetCompareOverlay");
            
    
            var path = "/TravelTimes/compareOverlay/{z}/mapcenter/{mapCenterLat}/{mapCenterLon}/pinlocation/{pinLat}/{pinLon}/dimensions/{width}/{height}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "z" + "}", ApiClient.ParameterToString(z));
path = path.Replace("{" + "pinLat" + "}", ApiClient.ParameterToString(pinLat));
path = path.Replace("{" + "pinLon" + "}", ApiClient.ParameterToString(pinLon));
path = path.Replace("{" + "mapCenterLat" + "}", ApiClient.ParameterToString(mapCenterLat));
path = path.Replace("{" + "mapCenterLon" + "}", ApiClient.ParameterToString(mapCenterLon));
path = path.Replace("{" + "width" + "}", ApiClient.ParameterToString(width));
path = path.Replace("{" + "height" + "}", ApiClient.ParameterToString(height));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (scenarioTitle != null) queryParams.Add("scenarioTitle", ApiClient.ParameterToString(scenarioTitle)); // query parameter
 if (timeOfDayId != null) queryParams.Add("timeOfDayId", ApiClient.ParameterToString(timeOfDayId)); // query parameter
 if (modeId != null) queryParams.Add("modeId", ApiClient.ParameterToString(modeId)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (travelTimeInterval != null) queryParams.Add("travelTimeInterval", ApiClient.ParameterToString(travelTimeInterval)); // query parameter
 if (compareType != null) queryParams.Add("compareType", ApiClient.ParameterToString(compareType)); // query parameter
 if (compareValue != null) queryParams.Add("compareValue", ApiClient.ParameterToString(compareValue)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TravelTimeGetCompareOverlay: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TravelTimeGetCompareOverlay: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SystemObject) ApiClient.Deserialize(response.Content, typeof(SystemObject), response.Headers);
        }
    
        /// <summary>
        /// Gets the TravelTime overlay. 
        /// </summary>
        /// <param name="z">The zoom level.</param> 
        /// <param name="pinLat">The latitude of the pin.</param> 
        /// <param name="pinLon">The longitude of the pin.</param> 
        /// <param name="mapCenterLat">The map center latitude.</param> 
        /// <param name="mapCenterLon">The map center longitude.</param> 
        /// <param name="scenarioTitle">The title of the scenario.</param> 
        /// <param name="timeOfDayId">The id for the time of day (AM/INTER/PM)</param> 
        /// <param name="modeId">The id of the mode.</param> 
        /// <param name="width">The width of the requested overlay.</param> 
        /// <param name="height">The height of the requested overlay.</param> 
        /// <param name="direction">The direction of travel.</param> 
        /// <param name="travelTimeInterval">The total minutes between the travel time bands</param> 
        /// <returns>SystemObject</returns>            
        public SystemObject TravelTimeGetOverlay (int? z, double? pinLat, double? pinLon, double? mapCenterLat, double? mapCenterLon, string scenarioTitle, string timeOfDayId, string modeId, int? width, int? height, string direction, int? travelTimeInterval)
        {
            
            // verify the required parameter 'z' is set
            if (z == null) throw new ApiException(400, "Missing required parameter 'z' when calling TravelTimeGetOverlay");
            
            // verify the required parameter 'pinLat' is set
            if (pinLat == null) throw new ApiException(400, "Missing required parameter 'pinLat' when calling TravelTimeGetOverlay");
            
            // verify the required parameter 'pinLon' is set
            if (pinLon == null) throw new ApiException(400, "Missing required parameter 'pinLon' when calling TravelTimeGetOverlay");
            
            // verify the required parameter 'mapCenterLat' is set
            if (mapCenterLat == null) throw new ApiException(400, "Missing required parameter 'mapCenterLat' when calling TravelTimeGetOverlay");
            
            // verify the required parameter 'mapCenterLon' is set
            if (mapCenterLon == null) throw new ApiException(400, "Missing required parameter 'mapCenterLon' when calling TravelTimeGetOverlay");
            
            // verify the required parameter 'scenarioTitle' is set
            if (scenarioTitle == null) throw new ApiException(400, "Missing required parameter 'scenarioTitle' when calling TravelTimeGetOverlay");
            
            // verify the required parameter 'timeOfDayId' is set
            if (timeOfDayId == null) throw new ApiException(400, "Missing required parameter 'timeOfDayId' when calling TravelTimeGetOverlay");
            
            // verify the required parameter 'modeId' is set
            if (modeId == null) throw new ApiException(400, "Missing required parameter 'modeId' when calling TravelTimeGetOverlay");
            
            // verify the required parameter 'width' is set
            if (width == null) throw new ApiException(400, "Missing required parameter 'width' when calling TravelTimeGetOverlay");
            
            // verify the required parameter 'height' is set
            if (height == null) throw new ApiException(400, "Missing required parameter 'height' when calling TravelTimeGetOverlay");
            
            // verify the required parameter 'direction' is set
            if (direction == null) throw new ApiException(400, "Missing required parameter 'direction' when calling TravelTimeGetOverlay");
            
            // verify the required parameter 'travelTimeInterval' is set
            if (travelTimeInterval == null) throw new ApiException(400, "Missing required parameter 'travelTimeInterval' when calling TravelTimeGetOverlay");
            
    
            var path = "/TravelTimes/overlay/{z}/mapcenter/{mapCenterLat}/{mapCenterLon}/pinlocation/{pinLat}/{pinLon}/dimensions/{width}/{height}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "z" + "}", ApiClient.ParameterToString(z));
path = path.Replace("{" + "pinLat" + "}", ApiClient.ParameterToString(pinLat));
path = path.Replace("{" + "pinLon" + "}", ApiClient.ParameterToString(pinLon));
path = path.Replace("{" + "mapCenterLat" + "}", ApiClient.ParameterToString(mapCenterLat));
path = path.Replace("{" + "mapCenterLon" + "}", ApiClient.ParameterToString(mapCenterLon));
path = path.Replace("{" + "width" + "}", ApiClient.ParameterToString(width));
path = path.Replace("{" + "height" + "}", ApiClient.ParameterToString(height));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (scenarioTitle != null) queryParams.Add("scenarioTitle", ApiClient.ParameterToString(scenarioTitle)); // query parameter
 if (timeOfDayId != null) queryParams.Add("timeOfDayId", ApiClient.ParameterToString(timeOfDayId)); // query parameter
 if (modeId != null) queryParams.Add("modeId", ApiClient.ParameterToString(modeId)); // query parameter
 if (direction != null) queryParams.Add("direction", ApiClient.ParameterToString(direction)); // query parameter
 if (travelTimeInterval != null) queryParams.Add("travelTimeInterval", ApiClient.ParameterToString(travelTimeInterval)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TravelTimeGetOverlay: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TravelTimeGetOverlay: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SystemObject) ApiClient.Deserialize(response.Content, typeof(SystemObject), response.Headers);
        }
    
    }
}
