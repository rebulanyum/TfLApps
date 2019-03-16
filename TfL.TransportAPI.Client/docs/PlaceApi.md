# TfL.TransportAPI.Client.PlaceApi

All URIs are relative to *https://push-api-argon.tfl.gov.uk:8001*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PlaceGet**](PlaceApi.md#placeget) | **GET** /Place/{id} | Gets the place with the given id.
[**PlaceGetAt**](PlaceApi.md#placegetat) | **GET** /Place/{type}/At/{Lat}/{Lon} | Gets any places of the given type whose geography intersects the given latitude and longitude. In practice this means the Place              must be polygonal e.g. a BoroughBoundary.
[**PlaceGetByGeoBox**](PlaceApi.md#placegetbygeobox) | **GET** /Place | Gets the places that lie within the bounding box defined by the lat/lon of its north-west and south-east corners. Optionally filters              on type and can strip properties for a smaller payload.
[**PlaceGetByType**](PlaceApi.md#placegetbytype) | **GET** /Place/Type/{types} | Gets all places of a given type
[**PlaceGetOverlay**](PlaceApi.md#placegetoverlay) | **GET** /Place/{type}/overlay/{z}/{Lat}/{Lon}/{width}/{height} | Gets the place overlay for a given set of co-ordinates and a given width/height.
[**PlaceGetStreetsByPostCode**](PlaceApi.md#placegetstreetsbypostcode) | **GET** /Place/Address/Streets/{Postcode} | Gets the set of streets associated with a post code.
[**PlaceMetaCategories**](PlaceApi.md#placemetacategories) | **GET** /Place/Meta/Categories | Gets a list of all of the available place property categories and keys.
[**PlaceMetaPlaceTypes**](PlaceApi.md#placemetaplacetypes) | **GET** /Place/Meta/PlaceTypes | Gets a list of the available types of Place.
[**PlaceSearch**](PlaceApi.md#placesearch) | **GET** /Place/Search | Gets all places that matches the given query


<a name="placeget"></a>
# **PlaceGet**
> List<TflApiPresentationEntitiesPlace> PlaceGet (string id, bool? includeChildren)

Gets the place with the given id.

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class PlaceGetExample
    {
        public void main()
        {
            
            var apiInstance = new PlaceApi();
            var id = id_example;  // string | The id of the place, you can use the /Place/Types/{types} endpoint to get a list of places for a given type including their ids
            var includeChildren = true;  // bool? | Defaults to false. If true child places e.g. individual charging stations at a charge point while be included, otherwise just the URLs of any child places will be returned (optional) 

            try
            {
                // Gets the place with the given id.
                List&lt;TflApiPresentationEntitiesPlace&gt; result = apiInstance.PlaceGet(id, includeChildren);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaceApi.PlaceGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| The id of the place, you can use the /Place/Types/{types} endpoint to get a list of places for a given type including their ids | 
 **includeChildren** | **bool?**| Defaults to false. If true child places e.g. individual charging stations at a charge point while be included, otherwise just the URLs of any child places will be returned | [optional] 

### Return type

[**List<TflApiPresentationEntitiesPlace>**](TflApiPresentationEntitiesPlace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="placegetat"></a>
# **PlaceGetAt**
> SystemObject PlaceGetAt (List<string> type, string lat, string lon, double? locationLat, double? locationLon)

Gets any places of the given type whose geography intersects the given latitude and longitude. In practice this means the Place              must be polygonal e.g. a BoroughBoundary.

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class PlaceGetAtExample
    {
        public void main()
        {
            
            var apiInstance = new PlaceApi();
            var type = new List<string>(); // List<string> | The place type (a valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint)
            var lat = lat_example;  // string | 
            var lon = lon_example;  // string | 
            var locationLat = 1.2;  // double? | 
            var locationLon = 1.2;  // double? | 

            try
            {
                // Gets any places of the given type whose geography intersects the given latitude and longitude. In practice this means the Place              must be polygonal e.g. a BoroughBoundary.
                SystemObject result = apiInstance.PlaceGetAt(type, lat, lon, locationLat, locationLon);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaceApi.PlaceGetAt: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | [**List<string>**](string.md)| The place type (a valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint) | 
 **lat** | **string**|  | 
 **lon** | **string**|  | 
 **locationLat** | **double?**|  | 
 **locationLon** | **double?**|  | 

### Return type

[**SystemObject**](SystemObject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="placegetbygeobox"></a>
# **PlaceGetByGeoBox**
> List<TflApiPresentationEntitiesStopPoint> PlaceGetByGeoBox (double? bbBoxpointsSwLat, double? bbBoxpointsSwLon, double? bbBoxpointsNeLat, double? bbBoxpointsNeLon, List<string> categories, bool? includeChildren, List<string> type, bool? activeOnly)

Gets the places that lie within the bounding box defined by the lat/lon of its north-west and south-east corners. Optionally filters              on type and can strip properties for a smaller payload.

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class PlaceGetByGeoBoxExample
    {
        public void main()
        {
            
            var apiInstance = new PlaceApi();
            var bbBoxpointsSwLat = 1.2;  // double? | 
            var bbBoxpointsSwLon = 1.2;  // double? | 
            var bbBoxpointsNeLat = 1.2;  // double? | 
            var bbBoxpointsNeLon = 1.2;  // double? | 
            var categories = new List<string>(); // List<string> | an optional list of comma separated property categories to return in the Place's property bag. If null or empty, all categories of property are returned. Pass the keyword \"none\" to return no properties (a valid list of categories can be obtained from the /Place/Meta/categories endpoint) (optional) 
            var includeChildren = true;  // bool? | Defaults to false. If true child places e.g. individual charging stations at a charge point while be included, otherwise just the URLs of any child places will be returned (optional) 
            var type = new List<string>(); // List<string> | place types to filter on, or null to return all types (optional) 
            var activeOnly = true;  // bool? | An optional parameter to limit the results to active records only (Currently only the 'VariableMessageSign' place type is supported) (optional) 

            try
            {
                // Gets the places that lie within the bounding box defined by the lat/lon of its north-west and south-east corners. Optionally filters              on type and can strip properties for a smaller payload.
                List&lt;TflApiPresentationEntitiesStopPoint&gt; result = apiInstance.PlaceGetByGeoBox(bbBoxpointsSwLat, bbBoxpointsSwLon, bbBoxpointsNeLat, bbBoxpointsNeLon, categories, includeChildren, type, activeOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaceApi.PlaceGetByGeoBox: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bbBoxpointsSwLat** | **double?**|  | 
 **bbBoxpointsSwLon** | **double?**|  | 
 **bbBoxpointsNeLat** | **double?**|  | 
 **bbBoxpointsNeLon** | **double?**|  | 
 **categories** | [**List<string>**](string.md)| an optional list of comma separated property categories to return in the Place&#39;s property bag. If null or empty, all categories of property are returned. Pass the keyword \&quot;none\&quot; to return no properties (a valid list of categories can be obtained from the /Place/Meta/categories endpoint) | [optional] 
 **includeChildren** | **bool?**| Defaults to false. If true child places e.g. individual charging stations at a charge point while be included, otherwise just the URLs of any child places will be returned | [optional] 
 **type** | [**List<string>**](string.md)| place types to filter on, or null to return all types | [optional] 
 **activeOnly** | **bool?**| An optional parameter to limit the results to active records only (Currently only the &#39;VariableMessageSign&#39; place type is supported) | [optional] 

### Return type

[**List<TflApiPresentationEntitiesStopPoint>**](TflApiPresentationEntitiesStopPoint.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="placegetbytype"></a>
# **PlaceGetByType**
> List<TflApiPresentationEntitiesPlace> PlaceGetByType (List<string> types, bool? activeOnly)

Gets all places of a given type

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class PlaceGetByTypeExample
    {
        public void main()
        {
            
            var apiInstance = new PlaceApi();
            var types = new List<string>(); // List<string> | A comma-separated list of the types to return. Max. approx 12 types.              A valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint.
            var activeOnly = true;  // bool? | An optional parameter to limit the results to active records only (Currently only the 'VariableMessageSign' place type is supported) (optional) 

            try
            {
                // Gets all places of a given type
                List&lt;TflApiPresentationEntitiesPlace&gt; result = apiInstance.PlaceGetByType(types, activeOnly);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaceApi.PlaceGetByType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **types** | [**List<string>**](string.md)| A comma-separated list of the types to return. Max. approx 12 types.              A valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint. | 
 **activeOnly** | **bool?**| An optional parameter to limit the results to active records only (Currently only the &#39;VariableMessageSign&#39; place type is supported) | [optional] 

### Return type

[**List<TflApiPresentationEntitiesPlace>**](TflApiPresentationEntitiesPlace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="placegetoverlay"></a>
# **PlaceGetOverlay**
> SystemObject PlaceGetOverlay (int? z, List<string> type, int? width, int? height, string lat, string lon, double? locationLat, double? locationLon)

Gets the place overlay for a given set of co-ordinates and a given width/height.

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class PlaceGetOverlayExample
    {
        public void main()
        {
            
            var apiInstance = new PlaceApi();
            var z = 56;  // int? | The zoom level
            var type = new List<string>(); // List<string> | The place type (a valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint)
            var width = 56;  // int? | The width of the requested overlay.
            var height = 56;  // int? | The height of the requested overlay.
            var lat = lat_example;  // string | 
            var lon = lon_example;  // string | 
            var locationLat = 1.2;  // double? | 
            var locationLon = 1.2;  // double? | 

            try
            {
                // Gets the place overlay for a given set of co-ordinates and a given width/height.
                SystemObject result = apiInstance.PlaceGetOverlay(z, type, width, height, lat, lon, locationLat, locationLon);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaceApi.PlaceGetOverlay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **z** | **int?**| The zoom level | 
 **type** | [**List<string>**](string.md)| The place type (a valid list of place types can be obtained from the /Place/Meta/placeTypes endpoint) | 
 **width** | **int?**| The width of the requested overlay. | 
 **height** | **int?**| The height of the requested overlay. | 
 **lat** | **string**|  | 
 **lon** | **string**|  | 
 **locationLat** | **double?**|  | 
 **locationLon** | **double?**|  | 

### Return type

[**SystemObject**](SystemObject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="placegetstreetsbypostcode"></a>
# **PlaceGetStreetsByPostCode**
> SystemObject PlaceGetStreetsByPostCode (string postcode, string postcodeInputPostcode)

Gets the set of streets associated with a post code.

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class PlaceGetStreetsByPostCodeExample
    {
        public void main()
        {
            
            var apiInstance = new PlaceApi();
            var postcode = postcode_example;  // string | 
            var postcodeInputPostcode = postcodeInputPostcode_example;  // string |  (optional) 

            try
            {
                // Gets the set of streets associated with a post code.
                SystemObject result = apiInstance.PlaceGetStreetsByPostCode(postcode, postcodeInputPostcode);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaceApi.PlaceGetStreetsByPostCode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postcode** | **string**|  | 
 **postcodeInputPostcode** | **string**|  | [optional] 

### Return type

[**SystemObject**](SystemObject.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="placemetacategories"></a>
# **PlaceMetaCategories**
> List<TflApiPresentationEntitiesPlaceCategory> PlaceMetaCategories ()

Gets a list of all of the available place property categories and keys.

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class PlaceMetaCategoriesExample
    {
        public void main()
        {
            
            var apiInstance = new PlaceApi();

            try
            {
                // Gets a list of all of the available place property categories and keys.
                List&lt;TflApiPresentationEntitiesPlaceCategory&gt; result = apiInstance.PlaceMetaCategories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaceApi.PlaceMetaCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TflApiPresentationEntitiesPlaceCategory>**](TflApiPresentationEntitiesPlaceCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="placemetaplacetypes"></a>
# **PlaceMetaPlaceTypes**
> List<TflApiPresentationEntitiesPlaceCategory> PlaceMetaPlaceTypes ()

Gets a list of the available types of Place.

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class PlaceMetaPlaceTypesExample
    {
        public void main()
        {
            
            var apiInstance = new PlaceApi();

            try
            {
                // Gets a list of the available types of Place.
                List&lt;TflApiPresentationEntitiesPlaceCategory&gt; result = apiInstance.PlaceMetaPlaceTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaceApi.PlaceMetaPlaceTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TflApiPresentationEntitiesPlaceCategory>**](TflApiPresentationEntitiesPlaceCategory.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="placesearch"></a>
# **PlaceSearch**
> List<TflApiPresentationEntitiesPlace> PlaceSearch (string name, List<string> types)

Gets all places that matches the given query

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class PlaceSearchExample
    {
        public void main()
        {
            
            var apiInstance = new PlaceApi();
            var name = name_example;  // string | The name of the place, you can use the /Place/Types/{types} endpoint to get a list of places for a given type including their names.
            var types = new List<string>(); // List<string> | A comma-separated list of the types to return. Max. approx 12 types. (optional) 

            try
            {
                // Gets all places that matches the given query
                List&lt;TflApiPresentationEntitiesPlace&gt; result = apiInstance.PlaceSearch(name, types);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlaceApi.PlaceSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the place, you can use the /Place/Types/{types} endpoint to get a list of places for a given type including their names. | 
 **types** | [**List<string>**](string.md)| A comma-separated list of the types to return. Max. approx 12 types. | [optional] 

### Return type

[**List<TflApiPresentationEntitiesPlace>**](TflApiPresentationEntitiesPlace.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

