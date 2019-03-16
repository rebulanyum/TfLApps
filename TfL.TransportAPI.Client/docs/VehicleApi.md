# TfL.TransportAPI.Client.VehicleApi

All URIs are relative to *https://push-api-argon.tfl.gov.uk:8001*

Method | HTTP request | Description
------------- | ------------- | -------------
[**VehicleGet**](VehicleApi.md#vehicleget) | **GET** /Vehicle/{ids}/Arrivals | Gets the predictions for a given list of vehicle Id&#39;s.
[**VehicleGetEmissionsSurchargeCompliance**](VehicleApi.md#vehiclegetemissionssurchargecompliance) | **GET** /Vehicle/EmissionSurcharge | Gets the Emissions Surcharge compliance for the Vehicle
[**VehicleGetUlezCompliance**](VehicleApi.md#vehiclegetulezcompliance) | **GET** /Vehicle/UlezCompliance | Gets the Ulez Surcharge compliance for the Vehicle


<a name="vehicleget"></a>
# **VehicleGet**
> List<TflApiPresentationEntitiesPrediction> VehicleGet (List<string> ids)

Gets the predictions for a given list of vehicle Id's.

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class VehicleGetExample
    {
        public void main()
        {
            
            var apiInstance = new VehicleApi();
            var ids = new List<string>(); // List<string> | A comma-separated list of vehicle ids e.g. LX58CFV,LX11AZB,LX58CFE. Max approx. 25 ids.

            try
            {
                // Gets the predictions for a given list of vehicle Id's.
                List&lt;TflApiPresentationEntitiesPrediction&gt; result = apiInstance.VehicleGet(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VehicleApi.VehicleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<string>**](string.md)| A comma-separated list of vehicle ids e.g. LX58CFV,LX11AZB,LX58CFE. Max approx. 25 ids. | 

### Return type

[**List<TflApiPresentationEntitiesPrediction>**](TflApiPresentationEntitiesPrediction.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vehiclegetemissionssurchargecompliance"></a>
# **VehicleGetEmissionsSurchargeCompliance**
> TflApiPresentationEntitiesVehicleMatch VehicleGetEmissionsSurchargeCompliance (string vrm)

Gets the Emissions Surcharge compliance for the Vehicle

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class VehicleGetEmissionsSurchargeComplianceExample
    {
        public void main()
        {
            
            var apiInstance = new VehicleApi();
            var vrm = vrm_example;  // string | The Vehicle Registration Mark

            try
            {
                // Gets the Emissions Surcharge compliance for the Vehicle
                TflApiPresentationEntitiesVehicleMatch result = apiInstance.VehicleGetEmissionsSurchargeCompliance(vrm);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VehicleApi.VehicleGetEmissionsSurchargeCompliance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vrm** | **string**| The Vehicle Registration Mark | 

### Return type

[**TflApiPresentationEntitiesVehicleMatch**](TflApiPresentationEntitiesVehicleMatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="vehiclegetulezcompliance"></a>
# **VehicleGetUlezCompliance**
> TflApiPresentationEntitiesVehicleMatch VehicleGetUlezCompliance (string vrm)

Gets the Ulez Surcharge compliance for the Vehicle

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class VehicleGetUlezComplianceExample
    {
        public void main()
        {
            
            var apiInstance = new VehicleApi();
            var vrm = vrm_example;  // string | The Vehicle Registration Mark

            try
            {
                // Gets the Ulez Surcharge compliance for the Vehicle
                TflApiPresentationEntitiesVehicleMatch result = apiInstance.VehicleGetUlezCompliance(vrm);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VehicleApi.VehicleGetUlezCompliance: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **vrm** | **string**| The Vehicle Registration Mark | 

### Return type

[**TflApiPresentationEntitiesVehicleMatch**](TflApiPresentationEntitiesVehicleMatch.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

