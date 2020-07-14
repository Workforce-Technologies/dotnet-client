# Workforce.Api.JobRoleApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**JobRoleById**](JobRoleApi.md#jobrolebyid) | **GET** /v1/JobRole/{id} | Get a specific Job Role from Workforce
[**V1JobRoleGet**](JobRoleApi.md#v1jobroleget) | **GET** /v1/JobRole | Get all Job Roles within Workforce
[**V1JobRolePost**](JobRoleApi.md#v1jobrolepost) | **POST** /v1/JobRole | Add a new Job Role to the Workforce system


<a name="jobrolebyid"></a>
# **JobRoleById**
> JobRole JobRoleById (Guid id)

Get a specific Job Role from Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class JobRoleByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobRoleApi(config);
            var id = new Guid(); // Guid | Unique ID of the Job Role

            try
            {
                // Get a specific Job Role from Workforce
                JobRole result = apiInstance.JobRoleById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobRoleApi.JobRoleById: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| Unique ID of the Job Role | 

### Return type

[**JobRole**](JobRole.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Job Role |  -  |
| **404** | If the Job roLE doesn&#39;t exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1jobroleget"></a>
# **V1JobRoleGet**
> List&lt;JobRole&gt; V1JobRoleGet ()

Get all Job Roles within Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1JobRoleGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobRoleApi(config);

            try
            {
                // Get all Job Roles within Workforce
                List<JobRole> result = apiInstance.V1JobRoleGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobRoleApi.V1JobRoleGet: " + e.Message );
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

[**List&lt;JobRole&gt;**](JobRole.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Job Role list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="v1jobrolepost"></a>
# **V1JobRolePost**
> void V1JobRolePost (JobRole jobRole = null)

Add a new Job Role to the Workforce system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1JobRolePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobRoleApi(config);
            var jobRole = new JobRole(); // JobRole |  (optional) 

            try
            {
                // Add a new Job Role to the Workforce system
                apiInstance.V1JobRolePost(jobRole);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobRoleApi.V1JobRolePost: " + e.Message );
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
 **jobRole** | [**JobRole**](JobRole.md)|  | [optional] 

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
| **201** | Returns the newly created Jobb Role |  -  |
| **400** | If the Job Role is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

