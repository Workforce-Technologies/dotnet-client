# Workforce.Api.DepartmentApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DepartmentById**](DepartmentApi.md#departmentbyid) | **GET** /v1/Department/{id} | Get a specific Department from Workforce
[**V1DepartmentGet**](DepartmentApi.md#v1departmentget) | **GET** /v1/Department | Get all Departments within Workforce
[**V1DepartmentPost**](DepartmentApi.md#v1departmentpost) | **POST** /v1/Department | Add a new Department to the Workforce system


<a name="departmentbyid"></a>
# **DepartmentById**
> Department DepartmentById (Guid id)

Get a specific Department from Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class DepartmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentApi(config);
            var id = new Guid(); // Guid | Unique ID of the Department

            try
            {
                // Get a specific Department from Workforce
                Department result = apiInstance.DepartmentById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentApi.DepartmentById: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| Unique ID of the Department | 

### Return type

[**Department**](Department.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Department |  -  |
| **404** | If the Department doesn&#39;t exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1departmentget"></a>
# **V1DepartmentGet**
> List&lt;Department&gt; V1DepartmentGet ()

Get all Departments within Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1DepartmentGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentApi(config);

            try
            {
                // Get all Departments within Workforce
                List<Department> result = apiInstance.V1DepartmentGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentApi.V1DepartmentGet: " + e.Message );
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

[**List&lt;Department&gt;**](Department.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Department list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1departmentpost"></a>
# **V1DepartmentPost**
> void V1DepartmentPost (Department department = null)

Add a new Department to the Workforce system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1DepartmentPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentApi(config);
            var department = new Department(); // Department |  (optional) 

            try
            {
                // Add a new Department to the Workforce system
                apiInstance.V1DepartmentPost(department);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentApi.V1DepartmentPost: " + e.Message );
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
 **department** | [**Department**](Department.md)|  | [optional] 

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
| **201** | Returns the newly created Department |  -  |
| **400** | If the Department is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

