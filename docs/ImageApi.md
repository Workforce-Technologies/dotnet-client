# Workforce.Api.ImageApi

All URIs are relative to *https://api.workforcehr.org*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1ImagesEmployeeGet**](ImageApi.md#v1imagesemployeeget) | **GET** /v1/images/employee | 


<a name="v1imagesemployeeget"></a>
# **V1ImagesEmployeeGet**
> void V1ImagesEmployeeGet (string id = null, int? width = null, int? height = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Workforce.Api;
using Workforce.Client;
using Workforce.Model;

namespace Example
{
    public class V1ImagesEmployeeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.workforcehr.org";
            // Configure OAuth2 access token for authorization: Bearer
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImageApi(config);
            var id = id_example;  // string |  (optional) 
            var width = 56;  // int? |  (optional) 
            var height = 56;  // int? |  (optional) 

            try
            {
                apiInstance.V1ImagesEmployeeGet(id, width, height);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImageApi.V1ImagesEmployeeGet: " + e.Message );
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
 **id** | **string**|  | [optional] 
 **width** | **int?**|  | [optional] 
 **height** | **int?**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[Bearer](../README.md#Bearer)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

