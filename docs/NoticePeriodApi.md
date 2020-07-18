# Workforce.Api.NoticePeriodApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateNoticePeriod**](NoticePeriodApi.md#createorupdatenoticeperiod) | **POST** /v1/NoticePeriod | Add a new Notice Period to the Workforce system
[**GetNoticePeriod**](NoticePeriodApi.md#getnoticeperiod) | **GET** /v1/NoticePeriod/{id} | Get a specific Notice Period from Workforce
[**GetNoticePeriods**](NoticePeriodApi.md#getnoticeperiods) | **GET** /v1/NoticePeriod | Get all Notice Periods within Workforce


<a name="createorupdatenoticeperiod"></a>
# **CreateOrUpdateNoticePeriod**
> void CreateOrUpdateNoticePeriod (NoticePeriod noticePeriod = null)

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
    public class CreateOrUpdateNoticePeriodExample
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
                apiInstance.CreateOrUpdateNoticePeriod(noticePeriod);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NoticePeriodApi.CreateOrUpdateNoticePeriod: " + e.Message );
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

<a name="getnoticeperiod"></a>
# **GetNoticePeriod**
> NoticePeriod GetNoticePeriod (Guid id)

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
    public class GetNoticePeriodExample
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
                NoticePeriod result = apiInstance.GetNoticePeriod(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NoticePeriodApi.GetNoticePeriod: " + e.Message );
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

<a name="getnoticeperiods"></a>
# **GetNoticePeriods**
> List&lt;NoticePeriod&gt; GetNoticePeriods ()

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
    public class GetNoticePeriodsExample
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
                List<NoticePeriod> result = apiInstance.GetNoticePeriods();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NoticePeriodApi.GetNoticePeriods: " + e.Message );
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

