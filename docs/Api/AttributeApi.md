# AttributeApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](AttributeApi.md#getbypath) | **GET** /attributes | Retrieve an attribute by path.
[**GetByPathWithHttpInfo**](AttributeApi.md#getbypathwithhttpinfo) | **GET** /attributes | Retrieve an attribute by path.
[**Get**](AttributeApi.md#get) | **GET** /attributes/{webId} | Retrieve an attribute.
[**GetWithHttpInfo**](AttributeApi.md#getwithhttpinfo) | **GET** /attributes/{webId} | Retrieve an attribute.
[**Update**](AttributeApi.md#update) | **PATCH** /attributes/{webId} | Update an attribute by replacing items in its definition.
[**UpdateWithHttpInfo**](AttributeApi.md#updatewithhttpinfo) | **PATCH** /attributes/{webId} | Update an attribute by replacing items in its definition.
[**Delete**](AttributeApi.md#delete) | **DELETE** /attributes/{webId} | Delete an attribute.
[**DeleteWithHttpInfo**](AttributeApi.md#deletewithhttpinfo) | **DELETE** /attributes/{webId} | Delete an attribute.
[**GetAttributes**](AttributeApi.md#getattributes) | **GET** /attributes/{webId}/attributes | Get the child attributes of the specified attribute.
[**GetAttributesWithHttpInfo**](AttributeApi.md#getattributeswithhttpinfo) | **GET** /attributes/{webId}/attributes | Get the child attributes of the specified attribute.
[**CreateAttribute**](AttributeApi.md#createattribute) | **POST** /attributes/{webId}/attributes | Create a new attribute as a child of the specified attribute.
[**CreateAttributeWithHttpInfo**](AttributeApi.md#createattributewithhttpinfo) | **POST** /attributes/{webId}/attributes | Create a new attribute as a child of the specified attribute.
[**GetCategories**](AttributeApi.md#getcategories) | **GET** /attributes/{webId}/categories | Get an attribute's categories.
[**GetCategoriesWithHttpInfo**](AttributeApi.md#getcategorieswithhttpinfo) | **GET** /attributes/{webId}/categories | Get an attribute's categories.
[**CreateConfig**](AttributeApi.md#createconfig) | **POST** /attributes/{webId}/config | Create or update an attribute's DataReference configuration (Create/Update PI point for PI Point DataReference).
[**CreateConfigWithHttpInfo**](AttributeApi.md#createconfigwithhttpinfo) | **POST** /attributes/{webId}/config | Create or update an attribute's DataReference configuration (Create/Update PI point for PI Point DataReference).
[**GetValue**](AttributeApi.md#getvalue) | **GET** /attributes/{webId}/value | Get the attribute's value. This call is intended for use with attributes that have no data reference only. For attributes with a data reference, consult the documentation for Streams.
[**GetValueWithHttpInfo**](AttributeApi.md#getvaluewithhttpinfo) | **GET** /attributes/{webId}/value | Get the attribute's value. This call is intended for use with attributes that have no data reference only. For attributes with a data reference, consult the documentation for Streams.
[**SetValue**](AttributeApi.md#setvalue) | **PUT** /attributes/{webId}/value | Set the value of a configuration item attribute. For attributes with a data reference or non-configuration item attributes, consult the documentation for streams.
[**SetValueWithHttpInfo**](AttributeApi.md#setvaluewithhttpinfo) | **PUT** /attributes/{webId}/value | Set the value of a configuration item attribute. For attributes with a data reference or non-configuration item attributes, consult the documentation for streams.
[**GetMultiple**](AttributeApi.md#getmultiple) | **GET** /attributes/multiple | Retrieve multiple attributes by web id or path.
[**GetMultipleWithHttpInfo**](AttributeApi.md#getmultiplewithhttpinfo) | **GET** /attributes/multiple | Retrieve multiple attributes by web id or path.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an attribute by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the attribute.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIAttribute**](../Responses/ApiResponsePIAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve an attribute by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the attribute.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIAttribute**](../Model/PIAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIAttribute**](../Responses/ApiResponsePIAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve an attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIAttribute**](../Model/PIAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIAttribute attribute)

Update an attribute by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |
 **attribute** | **PIAttribute**| A partial attribute containing the desired changes.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Update**
> Update(string webId, PIAttribute attribute)

Update an attribute by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |
 **attribute** | **PIAttribute**| A partial attribute containing the desired changes.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete an attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Delete**
> Delete(string webId)

Delete an attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAttributesWithHttpInfo**
> GetAttributesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, int startIndex, string categoryName = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null, string valueType = null)

Get the child attributes of the specified attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent attribute.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **categoryName** | **string**| Specify that returned attributes must have this category. The default is no category filter.. |
 **nameFilter** | **string**| The name query string used for finding attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **templateName** | **string**| Specify that returned attributes must be members of this template. The default is no template filter.. |
 **valueType** | **string**| Specify that returned attributes' value type must be the given value type. The default is no value type filter.. |


### Return type

[**ApiResponsePIItemsAttribute**](../Responses/ApiResponsePIItemsAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAttributes**
> GetAttributes(string webId, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, int startIndex, string categoryName = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null, string valueType = null)

Get the child attributes of the specified attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent attribute.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **categoryName** | **string**| Specify that returned attributes must have this category. The default is no category filter.. |
 **nameFilter** | **string**| The name query string used for finding attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **templateName** | **string**| Specify that returned attributes must be members of this template. The default is no template filter.. |
 **valueType** | **string**| Specify that returned attributes' value type must be the given value type. The default is no value type filter.. |


### Return type

[**PIItemsAttribute**](../Model/PIItemsAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateAttributeWithHttpInfo**
> CreateAttributeWithHttpInfo(string webId, PIAttribute attribute)

Create a new attribute as a child of the specified attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent attribute on which to create the attribute.. |
 **attribute** | **PIAttribute**| The definition of the new attribute.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateAttribute**
> CreateAttribute(string webId, PIAttribute attribute)

Create a new attribute as a child of the specified attribute.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent attribute on which to create the attribute.. |
 **attribute** | **PIAttribute**| The definition of the new attribute.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetCategoriesWithHttpInfo**
> GetCategoriesWithHttpInfo(string webId, string selectedFields = null)

Get an attribute's categories.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsAttributeCategory**](../Responses/ApiResponsePIItemsAttributeCategory.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetCategories**
> GetCategories(string webId, string selectedFields = null)

Get an attribute's categories.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsAttributeCategory**](../Model/PIItemsAttributeCategory.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateConfigWithHttpInfo**
> CreateConfigWithHttpInfo(string webId)

Create or update an attribute's DataReference configuration (Create/Update PI point for PI Point DataReference).

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateConfig**
> CreateConfig(string webId)

Create or update an attribute's DataReference configuration (Create/Update PI point for PI Point DataReference).

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetValueWithHttpInfo**
> GetValueWithHttpInfo(string webId, string selectedFields = null)

Get the attribute's value. This call is intended for use with attributes that have no data reference only. For attributes with a data reference, consult the documentation for Streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePITimedValue**](../Responses/ApiResponsePITimedValue.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetValue**
> GetValue(string webId, string selectedFields = null)

Get the attribute's value. This call is intended for use with attributes that have no data reference only. For attributes with a data reference, consult the documentation for Streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PITimedValue**](../Model/PITimedValue.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **SetValueWithHttpInfo**
> SetValueWithHttpInfo(string webId, PITimedValue value)

Set the value of a configuration item attribute. For attributes with a data reference or non-configuration item attributes, consult the documentation for streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |
 **value** | **PITimedValue**| The value to write.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **SetValue**
> SetValue(string webId, PITimedValue value)

Set the value of a configuration item attribute. For attributes with a data reference or non-configuration item attributes, consult the documentation for streams.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the attribute.. |
 **value** | **PITimedValue**| The value to write.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetMultipleWithHttpInfo**
> GetMultipleWithHttpInfo(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null)

Retrieve multiple attributes by web id or path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **asParallel** | **bool**| Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.. |
 **includeMode** | **string**| The include mode for the return list. The default is 'All'.. |
 **paths** | **string**| The path of an attribute. Multiple attributes may be specified with multiple instances of the parameter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **webIds** | **string**| The ID of an attribute. Multiple attributes may be specified with multiple instances of the parameter.. |


### Return type

[**ApiResponsePIItemsItemAttribute**](../Responses/ApiResponsePIItemsItemAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetMultiple**
> GetMultiple(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null)

Retrieve multiple attributes by web id or path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **asParallel** | **bool**| Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.. |
 **includeMode** | **string**| The include mode for the return list. The default is 'All'.. |
 **paths** | **string**| The path of an attribute. Multiple attributes may be specified with multiple instances of the parameter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **webIds** | **string**| The ID of an attribute. Multiple attributes may be specified with multiple instances of the parameter.. |


### Return type

[**PIItemsItemAttribute**](../Model/PIItemsItemAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
