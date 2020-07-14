# Workforce.Api.NoticePeriodApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NoticePeriodById**](NoticePeriodApi.md#noticeperiodbyid) | **GET** /v1/NoticePeriod/{id} | Get a specific Notice Period from Workforce
[**V1NoticePeriodGet**](NoticePeriodApi.md#v1noticeperiodget) | **GET** /v1/NoticePeriod | Get all Notice Periods within Workforce
[**V1NoticePeriodPost**](NoticePeriodApi.md#v1noticeperiodpost) | **POST** /v1/NoticePeriod | Add a new Notice Period to the Workforce system


<a name="noticeperiodbyid"></a>
# **NoticePeriodById**
> NoticePeriod NoticePeriodById (Guid id)

Get a specific Notice Period from Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class NoticePeriodByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NoticePeriodApi(config);
            var id = new Guid(); // Guid | Unique ID of the Notice Period

            try
            {
                // Get a specific Notice Period from Workforce
                NoticePeriod result = apiInstance.NoticePeriodById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NoticePeriodApi.NoticePeriodById: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| Unique ID of the Notice Period | 

### Return type

[**NoticePeriod**](NoticePeriod.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Notice Period |  -  |
| **404** | If the Notice Period doesn&#39;t exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1noticeperiodget"></a>
# **V1NoticePeriodGet**
> List&lt;NoticePeriod&gt; V1NoticePeriodGet ()

Get all Notice Periods within Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1NoticePeriodGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NoticePeriodApi(config);

            try
            {
                // Get all Notice Periods within Workforce
                List<NoticePeriod> result = apiInstance.V1NoticePeriodGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NoticePeriodApi.V1NoticePeriodGet: " + e.Message );
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

[**List&lt;NoticePeriod&gt;**](NoticePeriod.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Notice Period list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1noticeperiodpost"></a>
# **V1NoticePeriodPost**
> void V1NoticePeriodPost (NoticePeriod noticePeriod = null)

Add a new Notice Period to the Workforce system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1NoticePeriodPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NoticePeriodApi(config);
            var noticePeriod = new NoticePeriod(); // NoticePeriod |  (optional) 

            try
            {
                // Add a new Notice Period to the Workforce system
                apiInstance.V1NoticePeriodPost(noticePeriod);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NoticePeriodApi.V1NoticePeriodPost: " + e.Message );
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
 **noticePeriod** | [**NoticePeriod**](NoticePeriod.md)|  | [optional] 

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
| **201** | Returns the newly created Notice Period |  -  |
| **400** | If the Notice Period is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

