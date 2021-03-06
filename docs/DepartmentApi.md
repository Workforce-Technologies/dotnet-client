# Workforce.Api.DepartmentApi

All URIs are relative to *https://api.workforcehr.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateDepartment**](DepartmentApi.md#createorupdatedepartment) | **POST** /v1/Department | Add a new Department to the Workforce system
[**DeleteDepartment**](DepartmentApi.md#deletedepartment) | **DELETE** /v1/Department | Delete a Department from the Workforce system
[**GetDepartment**](DepartmentApi.md#getdepartment) | **GET** /v1/Department/{id} | Get a specific Department from Workforce
[**GetDepartments**](DepartmentApi.md#getdepartments) | **GET** /v1/Department | Get all Departments within Workforce


<a name="createorupdatedepartment"></a>
# **CreateOrUpdateDepartment**
> void CreateOrUpdateDepartment (Department department = null)

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
    public class CreateOrUpdateDepartmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.workforcehr.org";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentApi(config);
            var department = new Department(); // Department |  (optional) 

            try
            {
                // Add a new Department to the Workforce system
                apiInstance.CreateOrUpdateDepartment(department);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentApi.CreateOrUpdateDepartment: " + e.Message );
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

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the newly created Department |  -  |
| **400** | If the Department is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletedepartment"></a>
# **DeleteDepartment**
> void DeleteDepartment (Guid? id = null)

Delete a Department from the Workforce system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class DeleteDepartmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.workforcehr.org";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentApi(config);
            var id = new Guid?(); // Guid? | The Id of the entity to delete (optional) 

            try
            {
                // Delete a Department from the Workforce system
                apiInstance.DeleteDepartment(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentApi.DeleteDepartment: " + e.Message );
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
 **id** | [**Guid?**](Guid?.md)| The Id of the entity to delete | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | If the Department was deleted |  -  |
| **400** | If the Id is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdepartment"></a>
# **GetDepartment**
> Department GetDepartment (Guid id)

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
    public class GetDepartmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.workforcehr.org";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentApi(config);
            var id = new Guid(); // Guid | Unique ID of the Department

            try
            {
                // Get a specific Department from Workforce
                Department result = apiInstance.GetDepartment(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentApi.GetDepartment: " + e.Message );
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

<a name="getdepartments"></a>
# **GetDepartments**
> List&lt;Department&gt; GetDepartments ()

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
    public class GetDepartmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.workforcehr.org";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DepartmentApi(config);

            try
            {
                // Get all Departments within Workforce
                List<Department> result = apiInstance.GetDepartments();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DepartmentApi.GetDepartments: " + e.Message );
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

