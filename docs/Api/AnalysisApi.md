# AnalysisApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](AnalysisApi.md#getbypath) | **GET** /analyses | Retrieve an Analysis by path.
[**GetByPathWithHttpInfo**](AnalysisApi.md#getbypathwithhttpinfo) | **GET** /analyses | Retrieve an Analysis by path.
[**Get**](AnalysisApi.md#get) | **GET** /analyses/{webId} | Retrieve an Analysis.
[**GetWithHttpInfo**](AnalysisApi.md#getwithhttpinfo) | **GET** /analyses/{webId} | Retrieve an Analysis.
[**Update**](AnalysisApi.md#update) | **PATCH** /analyses/{webId} | Update an Analysis.
[**UpdateWithHttpInfo**](AnalysisApi.md#updatewithhttpinfo) | **PATCH** /analyses/{webId} | Update an Analysis.
[**Delete**](AnalysisApi.md#delete) | **DELETE** /analyses/{webId} | Delete an Analysis.
[**DeleteWithHttpInfo**](AnalysisApi.md#deletewithhttpinfo) | **DELETE** /analyses/{webId} | Delete an Analysis.
[**GetCategories**](AnalysisApi.md#getcategories) | **GET** /analyses/{webId}/categories | Get an Analysis' categories.
[**GetCategoriesWithHttpInfo**](AnalysisApi.md#getcategorieswithhttpinfo) | **GET** /analyses/{webId}/categories | Get an Analysis' categories.
[**GetSecurity**](AnalysisApi.md#getsecurity) | **GET** /analyses/{webId}/security | Get the security information of the specified security item associated with the Analysis for a specified user.
[**GetSecurityWithHttpInfo**](AnalysisApi.md#getsecuritywithhttpinfo) | **GET** /analyses/{webId}/security | Get the security information of the specified security item associated with the Analysis for a specified user.
[**GetSecurityEntries**](AnalysisApi.md#getsecurityentries) | **GET** /analyses/{webId}/securityentries | Retrieve the security entries associated with the analysis based on the specified criteria. By default, all security entries for this analysis are returned.
[**GetSecurityEntriesWithHttpInfo**](AnalysisApi.md#getsecurityentrieswithhttpinfo) | **GET** /analyses/{webId}/securityentries | Retrieve the security entries associated with the analysis based on the specified criteria. By default, all security entries for this analysis are returned.
[**CreateSecurityEntry**](AnalysisApi.md#createsecurityentry) | **POST** /analyses/{webId}/securityentries | Create a security entry owned by the analysis.
[**CreateSecurityEntryWithHttpInfo**](AnalysisApi.md#createsecurityentrywithhttpinfo) | **POST** /analyses/{webId}/securityentries | Create a security entry owned by the analysis.
[**GetSecurityEntryByName**](AnalysisApi.md#getsecurityentrybyname) | **GET** /analyses/{webId}/securityentries/{name} | Retrieve the security entry associated with the analysis with the specified name.
[**GetSecurityEntryByNameWithHttpInfo**](AnalysisApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /analyses/{webId}/securityentries/{name} | Retrieve the security entry associated with the analysis with the specified name.
[**UpdateSecurityEntry**](AnalysisApi.md#updatesecurityentry) | **PUT** /analyses/{webId}/securityentries/{name} | Update a security entry owned by the analysis.
[**UpdateSecurityEntryWithHttpInfo**](AnalysisApi.md#updatesecurityentrywithhttpinfo) | **PUT** /analyses/{webId}/securityentries/{name} | Update a security entry owned by the analysis.
[**DeleteSecurityEntry**](AnalysisApi.md#deletesecurityentry) | **DELETE** /analyses/{webId}/securityentries/{name} | Delete a security entry owned by the analysis.
[**DeleteSecurityEntryWithHttpInfo**](AnalysisApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /analyses/{webId}/securityentries/{name} | Delete a security entry owned by the analysis.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an Analysis by path.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **path** | **string**| The path to the Analysis.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIAnalysis**](../Responses/ApiResponsePIAnalysis.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve an Analysis by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the Analysis.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIAnalysis**](../Model/PIAnalysis.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an Analysis.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIAnalysis**](../Responses/ApiResponsePIAnalysis.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve an Analysis.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIAnalysis**](../Model/PIAnalysis.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIAnalysis analysis)

Update an Analysis.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis to update.. |
 **analysis** | **PIAnalysis**| A partial Analysis containing the desired changes.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Update**
> Update(string webId, PIAnalysis analysis)

Update an Analysis.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis to update.. |
 **analysis** | **PIAnalysis**| A partial Analysis containing the desired changes.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete an Analysis.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis to delete.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Delete**
> Delete(string webId)

Delete an Analysis.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis to delete.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetCategoriesWithHttpInfo**
> GetCategoriesWithHttpInfo(string webId, string selectedFields = null)

Get an Analysis' categories.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsAnalysisCategory**](../Responses/ApiResponsePIItemsAnalysisCategory.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetCategories**
> GetCategories(string webId, string selectedFields = null)

Get an Analysis' categories.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsAnalysisCategory**](../Model/PIItemsAnalysisCategory.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSecurityWithHttpInfo**
> GetSecurityWithHttpInfo(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)

Get the security information of the specified security item associated with the Analysis for a specified user.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis for the security to be checked.. |
 **userIdentities** | **string**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. |
 **forceRefresh** | **bool**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsSecurityRights**](../Responses/ApiResponsePIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSecurity**
> GetSecurity(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)

Get the security information of the specified security item associated with the Analysis for a specified user.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the Analysis for the security to be checked.. |
 **userIdentities** | **string**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. |
 **forceRefresh** | **bool**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsSecurityRights**](../Model/PIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSecurityEntriesWithHttpInfo**
> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the analysis based on the specified criteria. By default, all security entries for this analysis are returned.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the analysis.. |
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsSecurityEntry**](../Responses/ApiResponsePIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSecurityEntries**
> GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the analysis based on the specified criteria. By default, all security entries for this analysis are returned.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the analysis.. |
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsSecurityEntry**](../Model/PIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateSecurityEntryWithHttpInfo**
> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool applyToChildren)

Create a security entry owned by the analysis.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the analysis, where the security entry will be created.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateSecurityEntry**
> CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren)

Create a security entry owned by the analysis.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the analysis, where the security entry will be created.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSecurityEntryByNameWithHttpInfo**
> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the analysis with the specified name.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the analysis.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePISecurityEntry**](../Responses/ApiResponsePISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSecurityEntryByName**
> GetSecurityEntryByName(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the analysis with the specified name.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the analysis.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PISecurityEntry**](../Model/PISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateSecurityEntryWithHttpInfo**
> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)

Update a security entry owned by the analysis.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. |
 **webId** | **string**| The ID of the analysis, where the security entry will be updated.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateSecurityEntry**
> UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)

Update a security entry owned by the analysis.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. |
 **webId** | **string**| The ID of the analysis, where the security entry will be updated.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **DeleteSecurityEntryWithHttpInfo**
> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool applyToChildren)

Delete a security entry owned by the analysis.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the analysis, where the security entry will be deleted.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **DeleteSecurityEntry**
> DeleteSecurityEntry(string name, string webId, bool applyToChildren)

Delete a security entry owned by the analysis.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the analysis, where the security entry will be deleted.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)
