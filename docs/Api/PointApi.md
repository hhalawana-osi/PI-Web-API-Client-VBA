# PointApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](PointApi.md#getbypath) | **GET** /points | Get a point by path.
[**GetByPathWithHttpInfo**](PointApi.md#getbypathwithhttpinfo) | **GET** /points | Get a point by path.
[**Get**](PointApi.md#get) | **GET** /points/{webId} | Get a point.
[**GetWithHttpInfo**](PointApi.md#getwithhttpinfo) | **GET** /points/{webId} | Get a point.
[**Update**](PointApi.md#update) | **PATCH** /points/{webId} | Update a point.
[**UpdateWithHttpInfo**](PointApi.md#updatewithhttpinfo) | **PATCH** /points/{webId} | Update a point.
[**Delete**](PointApi.md#delete) | **DELETE** /points/{webId} | Delete a point.
[**DeleteWithHttpInfo**](PointApi.md#deletewithhttpinfo) | **DELETE** /points/{webId} | Delete a point.
[**GetAttributes**](PointApi.md#getattributes) | **GET** /points/{webId}/attributes | Get point attributes.
[**GetAttributesWithHttpInfo**](PointApi.md#getattributeswithhttpinfo) | **GET** /points/{webId}/attributes | Get point attributes.
[**GetAttributeByName**](PointApi.md#getattributebyname) | **GET** /points/{webId}/attributes/{name} | Get a point attribute by name.
[**GetAttributeByNameWithHttpInfo**](PointApi.md#getattributebynamewithhttpinfo) | **GET** /points/{webId}/attributes/{name} | Get a point attribute by name.
[**GetMultiple**](PointApi.md#getmultiple) | **GET** /points/multiple | Retrieve multiple points by web id or path.
[**GetMultipleWithHttpInfo**](PointApi.md#getmultiplewithhttpinfo) | **GET** /points/multiple | Retrieve multiple points by web id or path.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Get a point by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the point.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIPoint**](../Responses/ApiResponsePIPoint.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Get a point by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the point.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIPoint**](../Model/PIPoint.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Get a point.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIPoint**](../Responses/ApiResponsePIPoint.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Get a point.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIPoint**](../Model/PIPoint.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIPoint pointDTO)

Update a point.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. |
 **pointDTO** | **PIPoint**| A partial point containing the desired changes.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Update**
> Update(string webId, PIPoint pointDTO)

Update a point.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. |
 **pointDTO** | **PIPoint**| A partial point containing the desired changes.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete a point.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Delete**
> Delete(string webId)

Delete a point.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAttributesWithHttpInfo**
> GetAttributesWithHttpInfo(string webId, string names = null, string nameFilter = null, string selectedFields = null)

Get point attributes.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. |
 **names** | **string**| The name of a point attribute to be returned. Multiple attributes may be specified with multiple instances of the parameter.. |
 **nameFilter** | **string**| The filter to the names of the list of point attributes to be returned. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsPointAttribute**](../Responses/ApiResponsePIItemsPointAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAttributes**
> GetAttributes(string webId, string names = null, string nameFilter = null, string selectedFields = null)

Get point attributes.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the point.. |
 **names** | **string**| The name of a point attribute to be returned. Multiple attributes may be specified with multiple instances of the parameter.. |
 **nameFilter** | **string**| The filter to the names of the list of point attributes to be returned. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsPointAttribute**](../Model/PIItemsPointAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAttributeByNameWithHttpInfo**
> GetAttributeByNameWithHttpInfo(string name, string webId, string selectedFields = null)

Get a point attribute by name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the attribute.. |
 **webId** | **string**| The ID of the point.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIPointAttribute**](../Responses/ApiResponsePIPointAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAttributeByName**
> GetAttributeByName(string name, string webId, string selectedFields = null)

Get a point attribute by name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the attribute.. |
 **webId** | **string**| The ID of the point.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIPointAttribute**](../Model/PIPointAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetMultipleWithHttpInfo**
> GetMultipleWithHttpInfo(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null)

Retrieve multiple points by web id or path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **asParallel** | **bool**| Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested points. The default is 'false'.. |
 **includeMode** | **string**| The include mode for the return list. The default is 'All'.. |
 **paths** | **string**| The path of a point. Multiple points may be specified with multiple instances of the parameter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **webIds** | **string**| The ID of a point. Multiple points may be specified with multiple instances of the parameter.. |


### Return type

[**ApiResponsePIItemsItemPoint**](../Responses/ApiResponsePIItemsItemPoint.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetMultiple**
> GetMultiple(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null)

Retrieve multiple points by web id or path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **asParallel** | **bool**| Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested points. The default is 'false'.. |
 **includeMode** | **string**| The include mode for the return list. The default is 'All'.. |
 **paths** | **string**| The path of a point. Multiple points may be specified with multiple instances of the parameter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **webIds** | **string**| The ID of a point. Multiple points may be specified with multiple instances of the parameter.. |


### Return type

[**PIItemsItemPoint**](../Model/PIItemsItemPoint.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
