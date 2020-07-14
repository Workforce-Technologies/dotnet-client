# Workforce.Api.NationalityApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NationalityById**](NationalityApi.md#nationalitybyid) | **GET** /v1/Nationality/{id} | Get a specific Nationality from Workforce
[**V1NationalityGet**](NationalityApi.md#v1nationalityget) | **GET** /v1/Nationality | Get all Nationalities within Workforce
[**V1NationalityPost**](NationalityApi.md#v1nationalitypost) | **POST** /v1/Nationality | Add a new Nationality to the Workforce system


<a name="nationalitybyid"></a>
# **NationalityById**
> Nationality NationalityById (Guid id)

Get a specific Nationality from Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class NationalityByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NationalityApi(config);
            var id = new Guid(); // Guid | Unique ID of the Nationality

            try
            {
                // Get a specific Nationality from Workforce
                Nationality result = apiInstance.NationalityById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NationalityApi.NationalityById: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| Unique ID of the Nationality | 

### Return type

[**Nationality**](Nationality.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Nationality |  -  |
| **404** | If the Nationality doesn&#39;t exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1nationalityget"></a>
# **V1NationalityGet**
> List&lt;Nationality&gt; V1NationalityGet ()

Get all Nationalities within Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1NationalityGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NationalityApi(config);

            try
            {
                // Get all Nationalities within Workforce
                List<Nationality> result = apiInstance.V1NationalityGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NationalityApi.V1NationalityGet: " + e.Message );
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

[**List&lt;Nationality&gt;**](Nationality.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Nationality list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1nationalitypost"></a>
# **V1NationalityPost**
> void V1NationalityPost (Nationality nationality = null)

Add a new Nationality to the Workforce system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1NationalityPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NationalityApi(config);
            var nationality = new Nationality(); // Nationality |  (optional) 

            try
            {
                // Add a new Nationality to the Workforce system
                apiInstance.V1NationalityPost(nationality);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling NationalityApi.V1NationalityPost: " + e.Message );
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
 **nationality** | [**Nationality**](Nationality.md)|  | [optional] 

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
| **201** | Returns the newly created Nationality |  -  |
| **400** | If the Nationality is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
