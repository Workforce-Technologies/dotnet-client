# Workforce.Api.JobRoleApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateJobRole**](JobRoleApi.md#createorupdatejobrole) | **POST** /v1/JobRole | Add a new Job Role to the Workforce system
[**GetJobRoleById**](JobRoleApi.md#getjobrolebyid) | **GET** /v1/JobRole/{id} | Get a specific Job Role from Workforce
[**GetJobRoles**](JobRoleApi.md#getjobroles) | **GET** /v1/JobRole | Get all Job Roles within Workforce


<a name="createorupdatejobrole"></a>
# **CreateOrUpdateJobRole**
> void CreateOrUpdateJobRole (JobRole jobRole = null)

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
    public class CreateOrUpdateJobRoleExample
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
                apiInstance.CreateOrUpdateJobRole(jobRole);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobRoleApi.CreateOrUpdateJobRole: " + e.Message );
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

<a name="getjobrolebyid"></a>
# **GetJobRoleById**
> JobRole GetJobRoleById (Guid id)

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
    public class GetJobRoleByIdExample
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
                JobRole result = apiInstance.GetJobRoleById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobRoleApi.GetJobRoleById: " + e.Message );
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

<a name="getjobroles"></a>
# **GetJobRoles**
> List&lt;JobRole&gt; GetJobRoles ()

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
    public class GetJobRolesExample
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
                List<JobRole> result = apiInstance.GetJobRoles();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobRoleApi.GetJobRoles: " + e.Message );
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

