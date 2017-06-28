# ConfigurationApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**List**](ConfigurationApi.md#list) | **GET** /system/configuration | Get the current system configuration.
[**ListWithHttpInfo**](ConfigurationApi.md#listwithhttpinfo) | **GET** /system/configuration | Get the current system configuration.
[**Get**](ConfigurationApi.md#get) | **GET** /system/configuration/{key} | Get the value of a configuration item.
[**GetWithHttpInfo**](ConfigurationApi.md#getwithhttpinfo) | **GET** /system/configuration/{key} | Get the value of a configuration item.
[**Delete**](ConfigurationApi.md#delete) | **DELETE** /system/configuration/{key} | Delete a configuration item.
[**DeleteWithHttpInfo**](ConfigurationApi.md#deletewithhttpinfo) | **DELETE** /system/configuration/{key} | Delete a configuration item.


# **ListWithHttpInfo**
> ListWithHttpInfo()

Get the current system configuration.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **List**
> List()

Get the current system configuration.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string key)

Get the value of a configuration item.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the configuration item.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string key)

Get the value of a configuration item.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the configuration item.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string key)

Delete a configuration item.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the configuration item to remove.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Delete**
> Delete(string key)

Delete a configuration item.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the configuration item to remove.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
