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
    public interface ICabwiseApi
    {
        /// <summary>
        /// Gets taxis and minicabs contact information 
        /// </summary>
        /// <param name="lat">Latitude</param>
        /// <param name="lon">Longitude</param>
        /// <param name="optype">Operator Type e.g Minicab, Executive, Limousine</param>
        /// <param name="wc">Wheelchair accessible</param>
        /// <param name="radius">The radius of the bounding circle in metres</param>
        /// <param name="name">Trading name of operating company</param>
        /// <param name="maxResults">An optional parameter to limit the number of results return. Default and maximum is 20.</param>
        /// <param name="legacyFormat">Legacy Format</param>
        /// <param name="forceXml">Force Xml</param>
        /// <param name="twentyFourSevenOnly">Twenty Four Seven Only</param>
        /// <returns>SystemObject</returns>
        SystemObject CabwiseGet (double? lat, double? lon, string optype, string wc, double? radius, string name, int? maxResults, bool? legacyFormat, bool? forceXml, bool? twentyFourSevenOnly);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CabwiseApi : ICabwiseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CabwiseApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CabwiseApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CabwiseApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CabwiseApi(String basePath)
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
        /// Gets taxis and minicabs contact information 
        /// </summary>
        /// <param name="lat">Latitude</param> 
        /// <param name="lon">Longitude</param> 
        /// <param name="optype">Operator Type e.g Minicab, Executive, Limousine</param> 
        /// <param name="wc">Wheelchair accessible</param> 
        /// <param name="radius">The radius of the bounding circle in metres</param> 
        /// <param name="name">Trading name of operating company</param> 
        /// <param name="maxResults">An optional parameter to limit the number of results return. Default and maximum is 20.</param> 
        /// <param name="legacyFormat">Legacy Format</param> 
        /// <param name="forceXml">Force Xml</param> 
        /// <param name="twentyFourSevenOnly">Twenty Four Seven Only</param> 
        /// <returns>SystemObject</returns>            
        public SystemObject CabwiseGet (double? lat, double? lon, string optype, string wc, double? radius, string name, int? maxResults, bool? legacyFormat, bool? forceXml, bool? twentyFourSevenOnly)
        {
            
            // verify the required parameter 'lat' is set
            if (lat == null) throw new ApiException(400, "Missing required parameter 'lat' when calling CabwiseGet");
            
            // verify the required parameter 'lon' is set
            if (lon == null) throw new ApiException(400, "Missing required parameter 'lon' when calling CabwiseGet");
            
    
            var path = "/Cabwise/search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (lat != null) queryParams.Add("lat", ApiClient.ParameterToString(lat)); // query parameter
 if (lon != null) queryParams.Add("lon", ApiClient.ParameterToString(lon)); // query parameter
 if (optype != null) queryParams.Add("optype", ApiClient.ParameterToString(optype)); // query parameter
 if (wc != null) queryParams.Add("wc", ApiClient.ParameterToString(wc)); // query parameter
 if (radius != null) queryParams.Add("radius", ApiClient.ParameterToString(radius)); // query parameter
 if (name != null) queryParams.Add("name", ApiClient.ParameterToString(name)); // query parameter
 if (maxResults != null) queryParams.Add("maxResults", ApiClient.ParameterToString(maxResults)); // query parameter
 if (legacyFormat != null) queryParams.Add("legacyFormat", ApiClient.ParameterToString(legacyFormat)); // query parameter
 if (forceXml != null) queryParams.Add("forceXml", ApiClient.ParameterToString(forceXml)); // query parameter
 if (twentyFourSevenOnly != null) queryParams.Add("twentyFourSevenOnly", ApiClient.ParameterToString(twentyFourSevenOnly)); // query parameter
                                        
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling CabwiseGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CabwiseGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (SystemObject) ApiClient.Deserialize(response.Content, typeof(SystemObject), response.Headers);
        }
    
    }
}
