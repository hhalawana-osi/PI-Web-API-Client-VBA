# EnumerationValueApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](EnumerationValueApi.md#getbypath) | **GET** /enumerationvalues | Retrieve an enumeration value by path.
[**GetByPathWithHttpInfo**](EnumerationValueApi.md#getbypathwithhttpinfo) | **GET** /enumerationvalues | Retrieve an enumeration value by path.
[**Get**](EnumerationValueApi.md#get) | **GET** /enumerationvalues/{webId} | Retrieve an enumeration value mapping
[**GetWithHttpInfo**](EnumerationValueApi.md#getwithhttpinfo) | **GET** /enumerationvalues/{webId} | Retrieve an enumeration value mapping
[**UpdateEnumerationValue**](EnumerationValueApi.md#updateenumerationvalue) | **PATCH** /enumerationvalues/{webId} | Update an enumeration value by replacing items in its definition.
[**UpdateEnumerationValueWithHttpInfo**](EnumerationValueApi.md#updateenumerationvaluewithhttpinfo) | **PATCH** /enumerationvalues/{webId} | Update an enumeration value by replacing items in its definition.
[**DeleteEnumerationValue**](EnumerationValueApi.md#deleteenumerationvalue) | **DELETE** /enumerationvalues/{webId} | Delete an enumeration value from an enumeration set.
[**DeleteEnumerationValueWithHttpInfo**](EnumerationValueApi.md#deleteenumerationvaluewithhttpinfo) | **DELETE** /enumerationvalues/{webId} | Delete an enumeration value from an enumeration set.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an enumeration value by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the target enumeration value.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIEnumerationValue**](../Response/ApiResponsePIEnumerationValue.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve an enumeration value by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the target enumeration value.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIEnumerationValue**](../Model/PIEnumerationValue.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an enumeration value mapping

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration value.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIEnumerationValue**](../Response/ApiResponsePIEnumerationValue.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve an enumeration value mapping

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration value.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIEnumerationValue**](../Model/PIEnumerationValue.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateEnumerationValueWithHttpInfo**
> UpdateEnumerationValueWithHttpInfo(string webId, PIEnumerationValue enumerationValue)

Update an enumeration value by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration value to update.. |
 **enumerationValue** | **PIEnumerationValue**| A partial enumeration value containing the desired changes.. |


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateEnumerationValue**
> UpdateEnumerationValue(string webId, PIEnumerationValue enumerationValue)

Update an enumeration value by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration value to update.. |
 **enumerationValue** | **PIEnumerationValue**| A partial enumeration value containing the desired changes.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteEnumerationValueWithHttpInfo**
> DeleteEnumerationValueWithHttpInfo(string webId)

Delete an enumeration value from an enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration value.. |


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteEnumerationValue**
> DeleteEnumerationValue(string webId)

Delete an enumeration value from an enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration value.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
