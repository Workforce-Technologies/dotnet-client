# Workforce.Api.EmploymentTypeApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmploymentTypeById**](EmploymentTypeApi.md#employmenttypebyid) | **GET** /v1/EmploymentType/{id} | Get a specific Employment Type from Workforce
[**V1EmploymentTypeGet**](EmploymentTypeApi.md#v1employmenttypeget) | **GET** /v1/EmploymentType | Get all Employment Types within Workforce
[**V1EmploymentTypePost**](EmploymentTypeApi.md#v1employmenttypepost) | **POST** /v1/EmploymentType | Add a new Employment Type to the Workforce system


<a name="employmenttypebyid"></a>
# **EmploymentTypeById**
> EmploymentType EmploymentTypeById (Guid id)

Get a specific Employment Type from Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class EmploymentTypeByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmploymentTypeApi(config);
            var id = new Guid(); // Guid | Unique ID of the Employment Type

            try
            {
                // Get a specific Employment Type from Workforce
                EmploymentType result = apiInstance.EmploymentTypeById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentTypeApi.EmploymentTypeById: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| Unique ID of the Employment Type | 

### Return type

[**EmploymentType**](EmploymentType.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Employment Type |  -  |
| **404** | If the Employment Type doesn&#39;t exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1employmenttypeget"></a>
# **V1EmploymentTypeGet**
> List&lt;EmploymentType&gt; V1EmploymentTypeGet ()

Get all Employment Types within Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1EmploymentTypeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmploymentTypeApi(config);

            try
            {
                // Get all Employment Types within Workforce
                List<EmploymentType> result = apiInstance.V1EmploymentTypeGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentTypeApi.V1EmploymentTypeGet: " + e.Message );
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
| **200** | Returns the Employment Type list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1employmenttypepost"></a>
# **V1EmploymentTypePost**
> void V1EmploymentTypePost (EmploymentType employmentType = null)

Add a new Employment Type to the Workforce system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1EmploymentTypePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmploymentTypeApi(config);
            var employmentType = new EmploymentType(); // EmploymentType |  (optional) 

            try
            {
                // Add a new Employment Type to the Workforce system
                apiInstance.V1EmploymentTypePost(employmentType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentTypeApi.V1EmploymentTypePost: " + e.Message );
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
 **employmentType** | [**EmploymentType**](EmploymentType.md)|  | [optional] 

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
| **201** | Returns the newly created Employment Type |  -  |
| **400** | If the Employment Type is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

