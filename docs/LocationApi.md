# Workforce.Api.LocationApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LocationById**](LocationApi.md#locationbyid) | **GET** /v1/Location/{id} | Get a specific Location from Workforce
[**V1LocationGet**](LocationApi.md#v1locationget) | **GET** /v1/Location | Get all Locations within Workforce
[**V1LocationPost**](LocationApi.md#v1locationpost) | **POST** /v1/Location | Add a new Location to the Workforce system


<a name="locationbyid"></a>
# **LocationById**
> Location LocationById (Guid id)

Get a specific Location from Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class LocationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi(config);
            var id = new Guid(); // Guid | Unique ID of the Location

            try
            {
                // Get a specific Location from Workforce
                Location result = apiInstance.LocationById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationApi.LocationById: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid**](Guid.md)| Unique ID of the Location | 

### Return type

[**Location**](Location.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Location |  -  |
| **404** | If the Location doesn&#39;t exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1locationget"></a>
# **V1LocationGet**
> List&lt;EmploymentType&gt; V1LocationGet ()

Get all Locations within Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1LocationGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi(config);

            try
            {
                // Get all Locations within Workforce
                List<EmploymentType> result = apiInstance.V1LocationGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationApi.V1LocationGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List&lt;EmploymentType&gt;**](EmploymentType.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Locations list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1locationpost"></a>
# **V1LocationPost**
> void V1LocationPost (Location location = null)

Add a new Location to the Workforce system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1LocationPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new LocationApi(config);
            var location = new Location(); // Location |  (optional) 

            try
            {
                // Add a new Location to the Workforce system
                apiInstance.V1LocationPost(location);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LocationApi.V1LocationPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **location** | [**Location**](Location.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json, application/json-patch+json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the newly created Location |  -  |
| **400** | If the Location is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

