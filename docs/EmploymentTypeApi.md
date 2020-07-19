# Workforce.Api.EmploymentTypeApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateEmploymentType**](EmploymentTypeApi.md#createorupdateemploymenttype) | **POST** /v1/EmploymentType | Add a new Employment Type to the Workforce system
[**DeleteEmploymentType**](EmploymentTypeApi.md#deleteemploymenttype) | **DELETE** /v1/EmploymentType | Delete an Employment Type from the Workforce system
[**GetEmploymentType**](EmploymentTypeApi.md#getemploymenttype) | **GET** /v1/EmploymentType/{id} | Get a specific Employment Type from Workforce
[**GetEmploymentTypes**](EmploymentTypeApi.md#getemploymenttypes) | **GET** /v1/EmploymentType | Get all Employment Types within Workforce


<a name="createorupdateemploymenttype"></a>
# **CreateOrUpdateEmploymentType**
> void CreateOrUpdateEmploymentType (EmploymentType employmentType = null)

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
    public class CreateOrUpdateEmploymentTypeExample
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
                apiInstance.CreateOrUpdateEmploymentType(employmentType);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentTypeApi.CreateOrUpdateEmploymentType: " + e.Message );
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

<a name="deleteemploymenttype"></a>
# **DeleteEmploymentType**
> void DeleteEmploymentType (Guid? id = null)

Delete an Employment Type from the Workforce system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class DeleteEmploymentTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new EmploymentTypeApi(config);
            var id = new Guid?(); // Guid? | The Id of the entity to delete (optional) 

            try
            {
                // Delete an Employment Type from the Workforce system
                apiInstance.DeleteEmploymentType(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentTypeApi.DeleteEmploymentType: " + e.Message );
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
| **200** | If the Employment Type was deleted |  -  |
| **400** | If the Id is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getemploymenttype"></a>
# **GetEmploymentType**
> EmploymentType GetEmploymentType (Guid id)

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
    public class GetEmploymentTypeExample
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
                EmploymentType result = apiInstance.GetEmploymentType(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentTypeApi.GetEmploymentType: " + e.Message );
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

<a name="getemploymenttypes"></a>
# **GetEmploymentTypes**
> List&lt;EmploymentType&gt; GetEmploymentTypes ()

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
    public class GetEmploymentTypesExample
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
                List<EmploymentType> result = apiInstance.GetEmploymentTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EmploymentTypeApi.GetEmploymentTypes: " + e.Message );
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

