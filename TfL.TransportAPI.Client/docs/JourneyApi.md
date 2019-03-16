# TfL.TransportAPI.Client.JourneyApi

All URIs are relative to *https://push-api-argon.tfl.gov.uk:8001*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JourneyJourneyResults**](JourneyApi.md#journeyjourneyresults) | **GET** /Journey/JourneyResults/{from}/to/{to} | Perform a Journey Planner search from the parameters specified in simple types
[**JourneyMeta**](JourneyApi.md#journeymeta) | **GET** /Journey/Meta/Modes | Gets a list of all of the available journey planner modes


<a name="journeyjourneyresults"></a>
# **JourneyJourneyResults**
> TflApiPresentationEntitiesJourneyPlannerItineraryResult JourneyJourneyResults (string from, string to, string via, bool? nationalSearch, string date, string time, string timeIs, string journeyPreference, List<string> mode, List<string> accessibilityPreference, string fromName, string toName, string viaName, string maxTransferMinutes, string maxWalkingMinutes, string walkingSpeed, string cyclePreference, string adjustment, List<string> bikeProficiency, bool? alternativeCycle, bool? alternativeWalking, bool? applyHtmlMarkup, bool? useMultiModalCall, bool? walkingOptimization, bool? taxiOnlyTrip)

Perform a Journey Planner search from the parameters specified in simple types

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class JourneyJourneyResultsExample
    {
        public void main()
        {
            
            var apiInstance = new JourneyApi();
            var from = from_example;  // string | Origin of the journey. Can be WGS84 coordinates expressed as \"lat,long\", a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).
            var to = to_example;  // string | Destination of the journey. Can be WGS84 coordinates expressed as \"lat,long\", a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name).
            var via = via_example;  // string | Travel through point on the journey. Can be WGS84 coordinates expressed as \"lat,long\", a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name). (optional) 
            var nationalSearch = true;  // bool? | Does the journey cover stops outside London? eg. \"nationalSearch=true\" (optional) 
            var date = date_example;  // string | The date must be in yyyyMMdd format (optional) 
            var time = time_example;  // string | The time must be in HHmm format (optional) 
            var timeIs = timeIs_example;  // string | Does the time given relate to arrival or leaving time? Possible options: \"departing\" | \"arriving\" (optional) 
            var journeyPreference = journeyPreference_example;  // string | The journey preference eg possible options: \"leastinterchange\" | \"leasttime\" | \"leastwalking\" (optional) 
            var mode = new List<string>(); // List<string> | The mode must be a comma separated list of modes. eg possible options: \"public-bus,overground,train,tube,coach,dlr,cablecar,tram,river,walking,cycle\" (optional) 
            var accessibilityPreference = accessibilityPreference_example;  // List<string> | The accessibility preference must be a comma separated list eg. \"noSolidStairs,noEscalators,noElevators,stepFreeToVehicle,stepFreeToPlatform\" (optional) 
            var fromName = fromName_example;  // string | An optional name to associate with the origin of the journey in the results. (optional) 
            var toName = toName_example;  // string | An optional name to associate with the destination of the journey in the results. (optional) 
            var viaName = viaName_example;  // string | An optional name to associate with the via point of the journey in the results. (optional) 
            var maxTransferMinutes = maxTransferMinutes_example;  // string | The max walking time in minutes for transfer eg. \"120\" (optional) 
            var maxWalkingMinutes = maxWalkingMinutes_example;  // string | The max walking time in minutes for journeys eg. \"120\" (optional) 
            var walkingSpeed = walkingSpeed_example;  // string | The walking speed. eg possible options: \"slow\" | \"average\" | \"fast\". (optional) 
            var cyclePreference = cyclePreference_example;  // string | The cycle preference. eg possible options: \"allTheWay\" | \"leaveAtStation\" | \"takeOnTransport\" | \"cycleHire\" (optional) 
            var adjustment = adjustment_example;  // string | Time adjustment command. eg possible options: \"TripFirst\" | \"TripLast\" (optional) 
            var bikeProficiency = bikeProficiency_example;  // List<string> | A comma separated list of cycling proficiency levels. eg possible options: \"easy,moderate,fast\" (optional) 
            var alternativeCycle = true;  // bool? | Option to determine whether to return alternative cycling journey (optional) 
            var alternativeWalking = true;  // bool? | Option to determine whether to return alternative walking journey (optional) 
            var applyHtmlMarkup = true;  // bool? | Flag to determine whether certain text (e.g. walking instructions) should be output with HTML tags or not. (optional) 
            var useMultiModalCall = true;  // bool? | A boolean to indicate whether or not to return 3 public transport journeys, a bus journey, a cycle hire journey, a personal cycle journey and a walking journey (optional) 
            var walkingOptimization = true;  // bool? | A boolean to indicate whether to optimize journeys using walking (optional) 
            var taxiOnlyTrip = true;  // bool? | A boolean to indicate whether to return one or more taxi journeys. Note, setting this to true will override \"useMultiModalCall\". (optional) 

            try
            {
                // Perform a Journey Planner search from the parameters specified in simple types
                TflApiPresentationEntitiesJourneyPlannerItineraryResult result = apiInstance.JourneyJourneyResults(from, to, via, nationalSearch, date, time, timeIs, journeyPreference, mode, accessibilityPreference, fromName, toName, viaName, maxTransferMinutes, maxWalkingMinutes, walkingSpeed, cyclePreference, adjustment, bikeProficiency, alternativeCycle, alternativeWalking, applyHtmlMarkup, useMultiModalCall, walkingOptimization, taxiOnlyTrip);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.JourneyJourneyResults: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **from** | **string**| Origin of the journey. Can be WGS84 coordinates expressed as \&quot;lat,long\&quot;, a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name). | 
 **to** | **string**| Destination of the journey. Can be WGS84 coordinates expressed as \&quot;lat,long\&quot;, a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name). | 
 **via** | **string**| Travel through point on the journey. Can be WGS84 coordinates expressed as \&quot;lat,long\&quot;, a UK postcode, a Naptan (StopPoint) id, an ICS StopId, or a free-text string (will cause disambiguation unless it exactly matches a point of interest name). | [optional] 
 **nationalSearch** | **bool?**| Does the journey cover stops outside London? eg. \&quot;nationalSearch&#x3D;true\&quot; | [optional] 
 **date** | **string**| The date must be in yyyyMMdd format | [optional] 
 **time** | **string**| The time must be in HHmm format | [optional] 
 **timeIs** | **string**| Does the time given relate to arrival or leaving time? Possible options: \&quot;departing\&quot; | \&quot;arriving\&quot; | [optional] 
 **journeyPreference** | **string**| The journey preference eg possible options: \&quot;leastinterchange\&quot; | \&quot;leasttime\&quot; | \&quot;leastwalking\&quot; | [optional] 
 **mode** | [**List<string>**](string.md)| The mode must be a comma separated list of modes. eg possible options: \&quot;public-bus,overground,train,tube,coach,dlr,cablecar,tram,river,walking,cycle\&quot; | [optional] 
 **accessibilityPreference** | **List<string>**| The accessibility preference must be a comma separated list eg. \&quot;noSolidStairs,noEscalators,noElevators,stepFreeToVehicle,stepFreeToPlatform\&quot; | [optional] 
 **fromName** | **string**| An optional name to associate with the origin of the journey in the results. | [optional] 
 **toName** | **string**| An optional name to associate with the destination of the journey in the results. | [optional] 
 **viaName** | **string**| An optional name to associate with the via point of the journey in the results. | [optional] 
 **maxTransferMinutes** | **string**| The max walking time in minutes for transfer eg. \&quot;120\&quot; | [optional] 
 **maxWalkingMinutes** | **string**| The max walking time in minutes for journeys eg. \&quot;120\&quot; | [optional] 
 **walkingSpeed** | **string**| The walking speed. eg possible options: \&quot;slow\&quot; | \&quot;average\&quot; | \&quot;fast\&quot;. | [optional] 
 **cyclePreference** | **string**| The cycle preference. eg possible options: \&quot;allTheWay\&quot; | \&quot;leaveAtStation\&quot; | \&quot;takeOnTransport\&quot; | \&quot;cycleHire\&quot; | [optional] 
 **adjustment** | **string**| Time adjustment command. eg possible options: \&quot;TripFirst\&quot; | \&quot;TripLast\&quot; | [optional] 
 **bikeProficiency** | **List<string>**| A comma separated list of cycling proficiency levels. eg possible options: \&quot;easy,moderate,fast\&quot; | [optional] 
 **alternativeCycle** | **bool?**| Option to determine whether to return alternative cycling journey | [optional] 
 **alternativeWalking** | **bool?**| Option to determine whether to return alternative walking journey | [optional] 
 **applyHtmlMarkup** | **bool?**| Flag to determine whether certain text (e.g. walking instructions) should be output with HTML tags or not. | [optional] 
 **useMultiModalCall** | **bool?**| A boolean to indicate whether or not to return 3 public transport journeys, a bus journey, a cycle hire journey, a personal cycle journey and a walking journey | [optional] 
 **walkingOptimization** | **bool?**| A boolean to indicate whether to optimize journeys using walking | [optional] 
 **taxiOnlyTrip** | **bool?**| A boolean to indicate whether to return one or more taxi journeys. Note, setting this to true will override \&quot;useMultiModalCall\&quot;. | [optional] 

### Return type

[**TflApiPresentationEntitiesJourneyPlannerItineraryResult**](TflApiPresentationEntitiesJourneyPlannerItineraryResult.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="journeymeta"></a>
# **JourneyMeta**
> List<TflApiPresentationEntitiesMode> JourneyMeta ()

Gets a list of all of the available journey planner modes

### Example
```csharp
using System;
using System.Diagnostics;
using TfL.TransportAPI.Client;
using TfL.TransportAPI.Client.Generic;
using TfL.TransportAPI.Client.Model;

namespace Example
{
    public class JourneyMetaExample
    {
        public void main()
        {
            
            var apiInstance = new JourneyApi();

            try
            {
                // Gets a list of all of the available journey planner modes
                List&lt;TflApiPresentationEntitiesMode&gt; result = apiInstance.JourneyMeta();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling JourneyApi.JourneyMeta: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TflApiPresentationEntitiesMode>**](TflApiPresentationEntitiesMode.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

