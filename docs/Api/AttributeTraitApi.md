# AttributeTraitApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByCategory**](AttributeTraitApi.md#getbycategory) | **GET** /attributetraits | Retrieve all attribute traits of the specified category/categories.
[**GetByCategoryWithHttpInfo**](AttributeTraitApi.md#getbycategorywithhttpinfo) | **GET** /attributetraits | Retrieve all attribute traits of the specified category/categories.
[**Get**](AttributeTraitApi.md#get) | **GET** /attributetraits/{name} | Retrieve an attribute trait.
[**GetWithHttpInfo**](AttributeTraitApi.md#getwithhttpinfo) | **GET** /attributetraits/{name} | Retrieve an attribute trait.


# **GetByCategoryWithHttpInfo**
> GetByCategoryWithHttpInfo(string categorys, string selectedFields = null)

Retrieve all attribute traits of the specified category/categories.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **categorys** | **string**| The category of the attribute traits. Multiple categories may be specified with multiple instances of the parameter. If the parameter is not specified, or if its value is "all", then all attribute traits of all categories will be returned.. | [required] - join strings separated by ','
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIItemsAttributeTrait**](../Response/ApiResponsePIItemsAttributeTrait.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetByCategory**
> GetByCategory(string categorys, string selectedFields = null)

Retrieve all attribute traits of the specified category/categories.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **categorys** | **string**| The category of the attribute traits. Multiple categories may be specified with multiple instances of the parameter. If the parameter is not specified, or if its value is "all", then all attribute traits of all categories will be returned.. | [required] - join strings separated by ','
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIItemsAttributeTrait**](../Model/PIItemsAttributeTrait.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string name, string selectedFields = null)

Retrieve an attribute trait.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name or abbreviation of the attribute trait.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIAttributeTrait**](../Response/ApiResponsePIAttributeTrait.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)

# **Get**
> Get(string name, string selectedFields = null)

Retrieve an attribute trait.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name or abbreviation of the attribute trait.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIAttributeTrait**](../Model/PIAttributeTrait.md)

[[Back to top]](#) [[Back to API list]](../../DOCUMENTATION.md#documentation-for-api-endpoints) [[Back to Model list]](../../DOCUMENTATION.md#documentation-for-models) [[Back to DOCUMENTATION]](../../DOCUMENTATION.md)
