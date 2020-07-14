# Workforce.Api.EmployeeApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmployeeById**](EmployeeApi.md#employeebyid) | **GET** /v1/Employee/{id} | Get a specific Employee from Workforce
[**SearchEmployees**](EmployeeApi.md#searchemployees) | **GET** /v1/Employee/search | Search for Employees within Workforce
[**V1EmployeeGet**](EmployeeApi.md#v1employeeget) | **GET** /v1/Employee | Get all Employees within Workforce
[**V1EmployeePost**](EmployeeApi.md#v1employeepost) | **POST** /v1/Employee | Add a new Employee to the Workforce system


<a name="employeebyid"></a>
# **EmployeeById**
> Employee EmployeeById (Guid id)

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
    public class EmployeeByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeeApi(config);
            var id = new Guid(); // Guid | Unique ID of the Employee

            try
            {
                // Get a specific Employee from Workforce
                Employee result = apiInstance.EmployeeById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.EmployeeById: " + e.Message );
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
            config.BasePath = "http://localhost";
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

<a name="v1employeeget"></a>
# **V1EmployeeGet**
> List&lt;Employee&gt; V1EmployeeGet ()

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
    public class V1EmployeeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeeApi(config);

            try
            {
                // Get all Employees within Workforce
                List<Employee> result = apiInstance.V1EmployeeGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.V1EmployeeGet: " + e.Message );
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

<a name="v1employeepost"></a>
# **V1EmployeePost**
> void V1EmployeePost (Employee employee = null)

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
    public class V1EmployeePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmployeeApi(config);
            var employee = new Employee(); // Employee |  (optional) 

            try
            {
                // Add a new Employee to the Workforce system
                apiInstance.V1EmployeePost(employee);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmployeeApi.V1EmployeePost: " + e.Message );
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

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json, application/json-patch+json
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Returns the newly created Employee |  -  |
| **400** | If the Employee is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

