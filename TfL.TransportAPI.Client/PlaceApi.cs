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
    public interface IPlaceApi
    {
        /// <summary>
        /// Gets the place with the given id. 
        /// </summary>
        /// <param name="id">The id of the place, you can use the /Place/Types/{types} endpoint to get a list of places for a given type including their ids</param>
        /// <param name="includeChildren">Defaults to false. If true child places e.g. individual charging stations at a charge point while be included, otherwise just the URLs of any child places will be returned</param>
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>
        List<TflApiPresentationEntitiesPlace> PlaceGet (string id, bool? includeChildren);
        /// <summary>
        /// Gets any places of the given type whose geography intersects the given latitude and longitude. In practice this means the Place              must be polygonal e.g. a BoroughBoundary. 
        /// </summary>
        /// <param name="type">The place type (a valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint)</param>
        /// <param name="lat"></param>
        /// <param name="lon"></param>
        /// <param name="locationLat"></param>
        /// <param name="locationLon"></param>
        /// <returns>SystemObject</returns>
        SystemObject PlaceGetAt (List<string> type, string lat, string lon, double? locationLat, double? locationLon);
        /// <summary>
        /// Gets the places that lie within the bounding box defined by the lat/lon of its north-west and south-east corners. Optionally filters              on type and can strip properties for a smaller payload. 
        /// </summary>
        /// <param name="bbBoxpointsSwLat"></param>
        /// <param name="bbBoxpointsSwLon"></param>
        /// <param name="bbBoxpointsNeLat"></param>
        /// <param name="bbBoxpointsNeLon"></param>
        /// <param name="categories">an optional list of comma separated property categories to return in the Place&#39;s property bag. If null or empty, all categories of property are returned. Pass the keyword \&quot;none\&quot; to return no properties (a valid list of categories can be obtained from the /Place/Meta/categories endpoint)</param>
        /// <param name="includeChildren">Defaults to false. If true child places e.g. individual charging stations at a charge point while be included, otherwise just the URLs of any child places will be returned</param>
        /// <param name="type">place types to filter on, or null to return all types</param>
        /// <param name="activeOnly">An optional parameter to limit the results to active records only (Currently only the &#39;VariableMessageSign&#39; place type is supported)</param>
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>
        List<TflApiPresentationEntitiesStopPoint> PlaceGetByGeoBox (double? bbBoxpointsSwLat, double? bbBoxpointsSwLon, double? bbBoxpointsNeLat, double? bbBoxpointsNeLon, List<string> categories, bool? includeChildren, List<string> type, bool? activeOnly);
        /// <summary>
        /// Gets all places of a given type 
        /// </summary>
        /// <param name="types">A comma-separated list of the types to return. Max. approx 12 types.              A valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint.</param>
        /// <param name="activeOnly">An optional parameter to limit the results to active records only (Currently only the &#39;VariableMessageSign&#39; place type is supported)</param>
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>
        List<TflApiPresentationEntitiesPlace> PlaceGetByType (List<string> types, bool? activeOnly);
        /// <summary>
        /// Gets the place overlay for a given set of co-ordinates and a given width/height. 
        /// </summary>
        /// <param name="z">The zoom level</param>
        /// <param name="type">The place type (a valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint)</param>
        /// <param name="width">The width of the requested overlay.</param>
        /// <param name="height">The height of the requested overlay.</param>
        /// <param name="lat"></param>
        /// <param name="lon"></param>
        /// <param name="locationLat"></param>
        /// <param name="locationLon"></param>
        /// <returns>SystemObject</returns>
        SystemObject PlaceGetOverlay (int? z, List<string> type, int? width, int? height, string lat, string lon, double? locationLat, double? locationLon);
        /// <summary>
        /// Gets the set of streets associated with a post code. 
        /// </summary>
        /// <param name="postcode"></param>
        /// <param name="postcodeInputPostcode"></param>
        /// <returns>SystemObject</returns>
        SystemObject PlaceGetStreetsByPostCode (string postcode, string postcodeInputPostcode);
        /// <summary>
        /// Gets a list of all of the available place property categories and keys. 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesPlaceCategory&gt;</returns>
        List<TflApiPresentationEntitiesPlaceCategory> PlaceMetaCategories ();
        /// <summary>
        /// Gets a list of the available types of Place. 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesPlaceCategory&gt;</returns>
        List<TflApiPresentationEntitiesPlaceCategory> PlaceMetaPlaceTypes ();
        /// <summary>
        /// Gets all places that matches the given query 
        /// </summary>
        /// <param name="name">The name of the place, you can use the /Place/Types/{types} endpoint to get a list of places for a given type including their names.</param>
        /// <param name="types">A comma-separated list of the types to return. Max. approx 12 types.</param>
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>
        List<TflApiPresentationEntitiesPlace> PlaceSearch (string name, List<string> types);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PlaceApi : IPlaceApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PlaceApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PlaceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PlaceApi(String basePath)
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
        /// Gets the place with the given id. 
        /// </summary>
        /// <param name="id">The id of the place, you can use the /Place/Types/{types} endpoint to get a list of places for a given type including their ids</param> 
        /// <param name="includeChildren">Defaults to false. If true child places e.g. individual charging stations at a charge point while be included, otherwise just the URLs of any child places will be returned</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>            
        public List<TflApiPresentationEntitiesPlace> PlaceGet (string id, bool? includeChildren)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling PlaceGet");
            
    
            var path = "/Place/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeChildren != null) queryParams.Add("includeChildren", ApiClient.ParameterToString(includeChildren)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPlace>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPlace>), response.Headers);
        }
    
        /// <summary>
        /// Gets any places of the given type whose geography intersects the given latitude and longitude. In practice this means the Place              must be polygonal e.g. a BoroughBoundary. 
        /// </summary>
        /// <param name="type">The place type (a valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint)</param> 
        /// <param name="lat"></param> 
        /// <param name="lon"></param> 
        /// <param name="locationLat"></param> 
        /// <param name="locationLon"></param> 
        /// <returns>SystemObject</returns>            
        public SystemObject PlaceGetAt (List<string> type, string lat, string lon, double? locationLat, double? locationLon)
        {
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling PlaceGetAt");
            
            // verify the required parameter 'lat' is set
            if (lat == null) throw new ApiException(400, "Missing required parameter 'lat' when calling PlaceGetAt");
            
            // verify the required parameter 'lon' is set
            if (lon == null) throw new ApiException(400, "Missing required parameter 'lon' when calling PlaceGetAt");
            
            // verify the required parameter 'locationLat' is set
            if (locationLat == null) throw new ApiException(400, "Missing required parameter 'locationLat' when calling PlaceGetAt");
            
            // verify the required parameter 'locationLon' is set
            if (locationLon == null) throw new ApiException(400, "Missing required parameter 'locationLon' when calling PlaceGetAt");
            
    
            var path = "/Place/{type}/At/{Lat}/{Lon}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lat != null) queryParams.Add("lat", ApiClient.ParameterToString(lat)); // query parameter
 if (lon != null) queryParams.Add("lon", ApiClient.ParameterToString(lon)); // query parameter
 if (locationLat != null) queryParams.Add("location.lat", ApiClient.ParameterToString(locationLat)); // query parameter
 if (locationLon != null) queryParams.Add("location.lon", ApiClient.ParameterToString(locationLon)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceGetAt: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceGetAt: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SystemObject) ApiClient.Deserialize(response.Content, typeof(SystemObject), response.Headers);
        }
    
        /// <summary>
        /// Gets the places that lie within the bounding box defined by the lat/lon of its north-west and south-east corners. Optionally filters              on type and can strip properties for a smaller payload. 
        /// </summary>
        /// <param name="bbBoxpointsSwLat"></param> 
        /// <param name="bbBoxpointsSwLon"></param> 
        /// <param name="bbBoxpointsNeLat"></param> 
        /// <param name="bbBoxpointsNeLon"></param> 
        /// <param name="categories">an optional list of comma separated property categories to return in the Place&#39;s property bag. If null or empty, all categories of property are returned. Pass the keyword \&quot;none\&quot; to return no properties (a valid list of categories can be obtained from the /Place/Meta/categories endpoint)</param> 
        /// <param name="includeChildren">Defaults to false. If true child places e.g. individual charging stations at a charge point while be included, otherwise just the URLs of any child places will be returned</param> 
        /// <param name="type">place types to filter on, or null to return all types</param> 
        /// <param name="activeOnly">An optional parameter to limit the results to active records only (Currently only the &#39;VariableMessageSign&#39; place type is supported)</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesStopPoint&gt;</returns>            
        public List<TflApiPresentationEntitiesStopPoint> PlaceGetByGeoBox (double? bbBoxpointsSwLat, double? bbBoxpointsSwLon, double? bbBoxpointsNeLat, double? bbBoxpointsNeLon, List<string> categories, bool? includeChildren, List<string> type, bool? activeOnly)
        {
            
            // verify the required parameter 'bbBoxpointsSwLat' is set
            if (bbBoxpointsSwLat == null) throw new ApiException(400, "Missing required parameter 'bbBoxpointsSwLat' when calling PlaceGetByGeoBox");
            
            // verify the required parameter 'bbBoxpointsSwLon' is set
            if (bbBoxpointsSwLon == null) throw new ApiException(400, "Missing required parameter 'bbBoxpointsSwLon' when calling PlaceGetByGeoBox");
            
            // verify the required parameter 'bbBoxpointsNeLat' is set
            if (bbBoxpointsNeLat == null) throw new ApiException(400, "Missing required parameter 'bbBoxpointsNeLat' when calling PlaceGetByGeoBox");
            
            // verify the required parameter 'bbBoxpointsNeLon' is set
            if (bbBoxpointsNeLon == null) throw new ApiException(400, "Missing required parameter 'bbBoxpointsNeLon' when calling PlaceGetByGeoBox");
            
    
            var path = "/Place";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (categories != null) queryParams.Add("categories", ApiClient.ParameterToString(categories)); // query parameter
 if (includeChildren != null) queryParams.Add("includeChildren", ApiClient.ParameterToString(includeChildren)); // query parameter
 if (type != null) queryParams.Add("type", ApiClient.ParameterToString(type)); // query parameter
 if (activeOnly != null) queryParams.Add("activeOnly", ApiClient.ParameterToString(activeOnly)); // query parameter
 if (bbBoxpointsSwLat != null) queryParams.Add("bbBoxpoints.swLat", ApiClient.ParameterToString(bbBoxpointsSwLat)); // query parameter
 if (bbBoxpointsSwLon != null) queryParams.Add("bbBoxpoints.swLon", ApiClient.ParameterToString(bbBoxpointsSwLon)); // query parameter
 if (bbBoxpointsNeLat != null) queryParams.Add("bbBoxpoints.neLat", ApiClient.ParameterToString(bbBoxpointsNeLat)); // query parameter
 if (bbBoxpointsNeLon != null) queryParams.Add("bbBoxpoints.neLon", ApiClient.ParameterToString(bbBoxpointsNeLon)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceGetByGeoBox: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceGetByGeoBox: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesStopPoint>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesStopPoint>), response.Headers);
        }
    
        /// <summary>
        /// Gets all places of a given type 
        /// </summary>
        /// <param name="types">A comma-separated list of the types to return. Max. approx 12 types.              A valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint.</param> 
        /// <param name="activeOnly">An optional parameter to limit the results to active records only (Currently only the &#39;VariableMessageSign&#39; place type is supported)</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>            
        public List<TflApiPresentationEntitiesPlace> PlaceGetByType (List<string> types, bool? activeOnly)
        {
            
            // verify the required parameter 'types' is set
            if (types == null) throw new ApiException(400, "Missing required parameter 'types' when calling PlaceGetByType");
            
    
            var path = "/Place/Type/{types}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "types" + "}", ApiClient.ParameterToString(types));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (activeOnly != null) queryParams.Add("activeOnly", ApiClient.ParameterToString(activeOnly)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceGetByType: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceGetByType: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPlace>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPlace>), response.Headers);
        }
    
        /// <summary>
        /// Gets the place overlay for a given set of co-ordinates and a given width/height. 
        /// </summary>
        /// <param name="z">The zoom level</param> 
        /// <param name="type">The place type (a valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint)</param> 
        /// <param name="width">The width of the requested overlay.</param> 
        /// <param name="height">The height of the requested overlay.</param> 
        /// <param name="lat"></param> 
        /// <param name="lon"></param> 
        /// <param name="locationLat"></param> 
        /// <param name="locationLon"></param> 
        /// <returns>SystemObject</returns>            
        public SystemObject PlaceGetOverlay (int? z, List<string> type, int? width, int? height, string lat, string lon, double? locationLat, double? locationLon)
        {
            
            // verify the required parameter 'z' is set
            if (z == null) throw new ApiException(400, "Missing required parameter 'z' when calling PlaceGetOverlay");
            
            // verify the required parameter 'type' is set
            if (type == null) throw new ApiException(400, "Missing required parameter 'type' when calling PlaceGetOverlay");
            
            // verify the required parameter 'width' is set
            if (width == null) throw new ApiException(400, "Missing required parameter 'width' when calling PlaceGetOverlay");
            
            // verify the required parameter 'height' is set
            if (height == null) throw new ApiException(400, "Missing required parameter 'height' when calling PlaceGetOverlay");
            
            // verify the required parameter 'lat' is set
            if (lat == null) throw new ApiException(400, "Missing required parameter 'lat' when calling PlaceGetOverlay");
            
            // verify the required parameter 'lon' is set
            if (lon == null) throw new ApiException(400, "Missing required parameter 'lon' when calling PlaceGetOverlay");
            
            // verify the required parameter 'locationLat' is set
            if (locationLat == null) throw new ApiException(400, "Missing required parameter 'locationLat' when calling PlaceGetOverlay");
            
            // verify the required parameter 'locationLon' is set
            if (locationLon == null) throw new ApiException(400, "Missing required parameter 'locationLon' when calling PlaceGetOverlay");
            
    
            var path = "/Place/{type}/overlay/{z}/{Lat}/{Lon}/{width}/{height}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "z" + "}", ApiClient.ParameterToString(z));
path = path.Replace("{" + "type" + "}", ApiClient.ParameterToString(type));
path = path.Replace("{" + "width" + "}", ApiClient.ParameterToString(width));
path = path.Replace("{" + "height" + "}", ApiClient.ParameterToString(height));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lat != null) queryParams.Add("lat", ApiClient.ParameterToString(lat)); // query parameter
 if (lon != null) queryParams.Add("lon", ApiClient.ParameterToString(lon)); // query parameter
 if (locationLat != null) queryParams.Add("location.lat", ApiClient.ParameterToString(locationLat)); // query parameter
 if (locationLon != null) queryParams.Add("location.lon", ApiClient.ParameterToString(locationLon)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceGetOverlay: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceGetOverlay: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SystemObject) ApiClient.Deserialize(response.Content, typeof(SystemObject), response.Headers);
        }
    
        /// <summary>
        /// Gets the set of streets associated with a post code. 
        /// </summary>
        /// <param name="postcode"></param> 
        /// <param name="postcodeInputPostcode"></param> 
        /// <returns>SystemObject</returns>            
        public SystemObject PlaceGetStreetsByPostCode (string postcode, string postcodeInputPostcode)
        {
            
            // verify the required parameter 'postcode' is set
            if (postcode == null) throw new ApiException(400, "Missing required parameter 'postcode' when calling PlaceGetStreetsByPostCode");
            
    
            var path = "/Place/Address/Streets/{Postcode}";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (postcode != null) queryParams.Add("postcode", ApiClient.ParameterToString(postcode)); // query parameter
 if (postcodeInputPostcode != null) queryParams.Add("postcodeInput.postcode", ApiClient.ParameterToString(postcodeInputPostcode)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceGetStreetsByPostCode: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceGetStreetsByPostCode: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SystemObject) ApiClient.Deserialize(response.Content, typeof(SystemObject), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of all of the available place property categories and keys. 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesPlaceCategory&gt;</returns>            
        public List<TflApiPresentationEntitiesPlaceCategory> PlaceMetaCategories ()
        {
            
    
            var path = "/Place/Meta/Categories";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceMetaCategories: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceMetaCategories: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPlaceCategory>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPlaceCategory>), response.Headers);
        }
    
        /// <summary>
        /// Gets a list of the available types of Place. 
        /// </summary>
        /// <returns>List&lt;TflApiPresentationEntitiesPlaceCategory&gt;</returns>            
        public List<TflApiPresentationEntitiesPlaceCategory> PlaceMetaPlaceTypes ()
        {
            
    
            var path = "/Place/Meta/PlaceTypes";
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
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceMetaPlaceTypes: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceMetaPlaceTypes: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPlaceCategory>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPlaceCategory>), response.Headers);
        }
    
        /// <summary>
        /// Gets all places that matches the given query 
        /// </summary>
        /// <param name="name">The name of the place, you can use the /Place/Types/{types} endpoint to get a list of places for a given type including their names.</param> 
        /// <param name="types">A comma-separated list of the types to return. Max. approx 12 types.</param> 
        /// <returns>List&lt;TflApiPresentationEntitiesPlace&gt;</returns>            
        public List<TflApiPresentationEntitiesPlace> PlaceSearch (string name, List<string> types)
        {
            
            // verify the required parameter 'name' is set
            if (name == null) throw new ApiException(400, "Missing required parameter 'name' when calling PlaceSearch");
            
    
            var path = "/Place/Search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (types != null) queryParams.Add("types", ApiClient.ParameterToString(types)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceSearch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PlaceSearch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (List<TflApiPresentationEntitiesPlace>) ApiClient.Deserialize(response.Content, typeof(List<TflApiPresentationEntitiesPlace>), response.Headers);
        }
    
    }
}
