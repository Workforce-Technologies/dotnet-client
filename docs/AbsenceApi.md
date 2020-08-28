# Workforce.Api.AbsenceApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrUpdateAbsence**](AbsenceApi.md#createorupdateabsence) | **POST** /v1/Absence | Add a new Absence to the Workforce system
[**DeleteAbsence**](AbsenceApi.md#deleteabsence) | **DELETE** /v1/Absence | Delete an Absence from the Workforce system
[**GetAbsence**](AbsenceApi.md#getabsence) | **GET** /v1/Absence/{id} | Get a specific Absence from Workforce
[**GetAbsences**](AbsenceApi.md#getabsences) | **GET** /v1/Absence | Get all Absences within Workforce
[**GetAbsencesForEmployee**](AbsenceApi.md#getabsencesforemployee) | **GET** /v1/Absence/Employee/{id} | Get a list of Absences from workforce for a specific Employee
[**SearchAbsences**](AbsenceApi.md#searchabsences) | **GET** /v1/Absence/Search | Get a list of Absences from workforce that match the specified criteria


<a name="createorupdateabsence"></a>
# **CreateOrUpdateAbsence**
> void CreateOrUpdateAbsence (Absence absence = null)

Add a new Absence to the Workforce system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class CreateOrUpdateAbsenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AbsenceApi(config);
            var absence = new Absence(); // Absence |  (optional) 

            try
            {
                // Add a new Absence to the Workforce system
                apiInstance.CreateOrUpdateAbsence(absence);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AbsenceApi.CreateOrUpdateAbsence: " + e.Message );
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
 **absence** | [**Absence**](Absence.md)|  | [optional] 

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
| **201** | Returns the newly created Absence |  -  |
| **400** | If the Absence is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteabsence"></a>
# **DeleteAbsence**
> void DeleteAbsence (Guid? id = null)

Delete an Absence from the Workforce system

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class DeleteAbsenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AbsenceApi(config);
            var id = new Guid?(); // Guid? | The Id of the entity to delete (optional) 

            try
            {
                // Delete an Absence from the Workforce system
                apiInstance.DeleteAbsence(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AbsenceApi.DeleteAbsence: " + e.Message );
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
| **200** | If the Absence was deleted |  -  |
| **400** | If the Id is null |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getabsence"></a>
# **GetAbsence**
> Absence GetAbsence (Guid id)

Get a specific Absence from Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class GetAbsenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AbsenceApi(config);
            var id = new Guid(); // Guid | Unique ID of the Absence

            try
            {
                // Get a specific Absence from Workforce
                Absence result = apiInstance.GetAbsence(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AbsenceApi.GetAbsence: " + e.Message );
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
 **id** | [**Guid**](Guid.md)| Unique ID of the Absence | 

### Return type

[**Absence**](Absence.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Absence |  -  |
| **404** | If the Absence doesn&#39;t exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getabsences"></a>
# **GetAbsences**
> List&lt;Absence&gt; GetAbsences ()

Get all Absences within Workforce

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class GetAbsencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AbsenceApi(config);

            try
            {
                // Get all Absences within Workforce
                List<Absence> result = apiInstance.GetAbsences();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AbsenceApi.GetAbsences: " + e.Message );
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

[**List&lt;Absence&gt;**](Absence.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Absence list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getabsencesforemployee"></a>
# **GetAbsencesForEmployee**
> List&lt;Absence&gt; GetAbsencesForEmployee (Guid id)

Get a list of Absences from workforce for a specific Employee

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class GetAbsencesForEmployeeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AbsenceApi(config);
            var id = new Guid(); // Guid | Unique ID of the Employee

            try
            {
                // Get a list of Absences from workforce for a specific Employee
                List<Absence> result = apiInstance.GetAbsencesForEmployee(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AbsenceApi.GetAbsencesForEmployee: " + e.Message );
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

[**List&lt;Absence&gt;**](Absence.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Absences |  -  |
| **404** | If the Employee doesn&#39;t exist or there are no absences |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchabsences"></a>
# **SearchAbsences**
> List&lt;Absence&gt; SearchAbsences (Guid? employeeId = null, DateTime? dateFrom = null, DateTime? dateTo = null, string notes = null)

Get a list of Absences from workforce that match the specified criteria

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class SearchAbsencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AbsenceApi(config);
            var employeeId = new Guid?(); // Guid? |  (optional) 
            var dateFrom = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var dateTo = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var notes = notes_example;  // string |  (optional) 

            try
            {
                // Get a list of Absences from workforce that match the specified criteria
                List<Absence> result = apiInstance.SearchAbsences(employeeId, dateFrom, dateTo, notes);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AbsenceApi.SearchAbsences: " + e.Message );
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
 **employeeId** | [**Guid?**](Guid?.md)|  | [optional] 
 **dateFrom** | **DateTime?**|  | [optional] 
 **dateTo** | **DateTime?**|  | [optional] 
 **notes** | **string**|  | [optional] 

### Return type

[**List&lt;Absence&gt;**](Absence.md)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the Absences |  -  |
| **404** | If there are no absences |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

