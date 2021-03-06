# Workforce.Api.EmployeeApi

All URIs are relative to *https://api.workforcehr.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateEmployee**](EmployeeApi.md#createorupdateemployee) | **POST** /v1/Employee | Add a new Employee to the Workforce system
[**DeleteEmployee**](EmployeeApi.md#deleteemployee) | **DELETE** /v1/Employee | Delete an Employee from the Workforce system
[**GetEmployee**](EmployeeApi.md#getemployee) | **GET** /v1/Employee/{id} | Get a specific Employee from Workforce
[**GetEmployeePhoto**](EmployeeApi.md#getemployeephoto) | **GET** /v1/Employee/employees/{employeeId}/photo | Get a single Employee Photo from Workforce
[**GetEmployees**](EmployeeApi.md#getemployees) | **GET** /v1/Employee | Get all Employees within Workforce
[**SearchEmployees**](EmployeeApi.md#searchemployees) | **GET** /v1/Employee/search | Search for Employees within Workforce


<a name="createorupdateemployee"></a>
# **CreateOrUpdateEmployee**
> Employee CreateOrUpdateEmployee (Employee employee = null)

Add a new Employee to the Workforce system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class CreateOrUpdateEmployeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.workforcehr.org";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeeApi(config);
            var employee = new Employee(); // Employee |  (optional) 

            try
            {
                // Add a new Employee to the Workforce system
                Employee result = apiInstance.CreateOrUpdateEmployee(employee);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.CreateOrUpdateEmployee: " + e.Message );
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
 **employee** | [**Employee**](Employee.md)|  | [optional] 

### Return type

[**Employee**](Employee.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the newly created Employee |  -  |
| **400** | If the Employee is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteemployee"></a>
# **DeleteEmployee**
> void DeleteEmployee (Guid? id = null)

Delete an Employee from the Workforce system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class DeleteEmployeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.workforcehr.org";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeeApi(config);
            var id = new Guid?(); // Guid? | The Id of the entity to delete (optional) 

            try
            {
                // Delete an Employee from the Workforce system
                apiInstance.DeleteEmployee(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.DeleteEmployee: " + e.Message );
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
| **200** | If the Employee was deleted |  -  |
| **400** | If the Id is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemployee"></a>
# **GetEmployee**
> Employee GetEmployee (Guid id)

Get a specific Employee from Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class GetEmployeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.workforcehr.org";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeeApi(config);
            var id = new Guid(); // Guid | Unique ID of the Employee

            try
            {
                // Get a specific Employee from Workforce
                Employee result = apiInstance.GetEmployee(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.GetEmployee: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| Unique ID of the Employee | 

### Return type

[**Employee**](Employee.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Employee |  -  |
| **404** | If the Employee doesn&#39;t exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemployeephoto"></a>
# **GetEmployeePhoto**
> byte[] GetEmployeePhoto (Guid employeeId, int? height = null, int? width = null)

Get a single Employee Photo from Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class GetEmployeePhotoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.workforcehr.org";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeeApi(config);
            var employeeId = new Guid(); // Guid | Unique ID of the Employee
            var height = 56;  // int? | Height in pixels of the image to be returned (optional) 
            var width = 56;  // int? | Width in pixels of the image to be returned (optional) 

            try
            {
                // Get a single Employee Photo from Workforce
                byte[] result = apiInstance.GetEmployeePhoto(employeeId, height, width);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.GetEmployeePhoto: " + e.Message );
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
 **employeeId** | [**Guid**](Guid.md)| Unique ID of the Employee | 
 **height** | **int?**| Height in pixels of the image to be returned | [optional] 
 **width** | **int?**| Width in pixels of the image to be returned | [optional] 

### Return type

**byte[]**

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the image |  -  |
| **404** | If the Employee doesn&#39;t exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemployees"></a>
# **GetEmployees**
> List&lt;Employee&gt; GetEmployees ()

Get all Employees within Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class GetEmployeesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.workforcehr.org";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeeApi(config);

            try
            {
                // Get all Employees within Workforce
                List<Employee> result = apiInstance.GetEmployees();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.GetEmployees: " + e.Message );
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

[**List&lt;Employee&gt;**](Employee.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Employee list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchemployees"></a>
# **SearchEmployees**
> List&lt;Employee&gt; SearchEmployees (string firstName = null, string lastName = null)

Search for Employees within Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class SearchEmployeesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.workforcehr.org";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeeApi(config);
            var firstName = firstName_example;  // string |  (optional) 
            var lastName = lastName_example;  // string |  (optional) 

            try
            {
                // Search for Employees within Workforce
                List<Employee> result = apiInstance.SearchEmployees(firstName, lastName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.SearchEmployees: " + e.Message );
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
 **firstName** | **string**|  | [optional] 
 **lastName** | **string**|  | [optional] 

### Return type

[**List&lt;Employee&gt;**](Employee.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Employee |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

