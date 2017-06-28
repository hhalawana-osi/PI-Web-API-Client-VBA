# EnumerationSetApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](EnumerationSetApi.md#getbypath) | **GET** /enumerationsets | Retrieve an enumeration set by path.
[**GetByPathWithHttpInfo**](EnumerationSetApi.md#getbypathwithhttpinfo) | **GET** /enumerationsets | Retrieve an enumeration set by path.
[**Get**](EnumerationSetApi.md#get) | **GET** /enumerationsets/{webId} | Retrieve an enumeration set.
[**GetWithHttpInfo**](EnumerationSetApi.md#getwithhttpinfo) | **GET** /enumerationsets/{webId} | Retrieve an enumeration set.
[**Update**](EnumerationSetApi.md#update) | **PATCH** /enumerationsets/{webId} | Update an enumeration set by replacing items in its definition.
[**UpdateWithHttpInfo**](EnumerationSetApi.md#updatewithhttpinfo) | **PATCH** /enumerationsets/{webId} | Update an enumeration set by replacing items in its definition.
[**Delete**](EnumerationSetApi.md#delete) | **DELETE** /enumerationsets/{webId} | Delete an enumeration set.
[**DeleteWithHttpInfo**](EnumerationSetApi.md#deletewithhttpinfo) | **DELETE** /enumerationsets/{webId} | Delete an enumeration set.
[**GetValues**](EnumerationSetApi.md#getvalues) | **GET** /enumerationsets/{webId}/enumerationvalues | Retrieve an enumeration set's values.
[**GetValuesWithHttpInfo**](EnumerationSetApi.md#getvalueswithhttpinfo) | **GET** /enumerationsets/{webId}/enumerationvalues | Retrieve an enumeration set's values.
[**CreateValue**](EnumerationSetApi.md#createvalue) | **POST** /enumerationsets/{webId}/enumerationvalues | Create an enumeration value for a enumeration set.
[**CreateValueWithHttpInfo**](EnumerationSetApi.md#createvaluewithhttpinfo) | **POST** /enumerationsets/{webId}/enumerationvalues | Create an enumeration value for a enumeration set.
[**GetSecurity**](EnumerationSetApi.md#getsecurity) | **GET** /enumerationsets/{webId}/security | Get the security information of the specified security item associated with the enumeration set for a specified user.
[**GetSecurityWithHttpInfo**](EnumerationSetApi.md#getsecuritywithhttpinfo) | **GET** /enumerationsets/{webId}/security | Get the security information of the specified security item associated with the enumeration set for a specified user.
[**GetSecurityEntries**](EnumerationSetApi.md#getsecurityentries) | **GET** /enumerationsets/{webId}/securityentries | Retrieve the security entries associated with the enumeration set based on the specified criteria. By default, all security entries for this enumeration set are returned.
[**GetSecurityEntriesWithHttpInfo**](EnumerationSetApi.md#getsecurityentrieswithhttpinfo) | **GET** /enumerationsets/{webId}/securityentries | Retrieve the security entries associated with the enumeration set based on the specified criteria. By default, all security entries for this enumeration set are returned.
[**CreateSecurityEntry**](EnumerationSetApi.md#createsecurityentry) | **POST** /enumerationsets/{webId}/securityentries | Create a security entry owned by the enumeration set.
[**CreateSecurityEntryWithHttpInfo**](EnumerationSetApi.md#createsecurityentrywithhttpinfo) | **POST** /enumerationsets/{webId}/securityentries | Create a security entry owned by the enumeration set.
[**GetSecurityEntryByName**](EnumerationSetApi.md#getsecurityentrybyname) | **GET** /enumerationsets/{webId}/securityentries/{name} | Retrieve the security entry associated with the enumeration set with the specified name.
[**GetSecurityEntryByNameWithHttpInfo**](EnumerationSetApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /enumerationsets/{webId}/securityentries/{name} | Retrieve the security entry associated with the enumeration set with the specified name.
[**UpdateSecurityEntry**](EnumerationSetApi.md#updatesecurityentry) | **PUT** /enumerationsets/{webId}/securityentries/{name} | Update a security entry owned by the enumeration set.
[**UpdateSecurityEntryWithHttpInfo**](EnumerationSetApi.md#updatesecurityentrywithhttpinfo) | **PUT** /enumerationsets/{webId}/securityentries/{name} | Update a security entry owned by the enumeration set.
[**DeleteSecurityEntry**](EnumerationSetApi.md#deletesecurityentry) | **DELETE** /enumerationsets/{webId}/securityentries/{name} | Delete a security entry owned by the enumeration set.
[**DeleteSecurityEntryWithHttpInfo**](EnumerationSetApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /enumerationsets/{webId}/securityentries/{name} | Delete a security entry owned by the enumeration set.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an enumeration set by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the target enumeration set.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIEnumerationSet**](../Response/ApiResponsePIEnumerationSet.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve an enumeration set by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the target enumeration set.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIEnumerationSet**](../Model/PIEnumerationSet.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIEnumerationSet**](../Response/ApiResponsePIEnumerationSet.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve an enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIEnumerationSet**](../Model/PIEnumerationSet.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIEnumerationSet enumerationSet)

Update an enumeration set by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set to update.. | [required]
 **enumerationSet** | **PIEnumerationSet**| A partial enumeration set containing the desired changes.. | [required]


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Update**
> Update(string webId, PIEnumerationSet enumerationSet)

Update an enumeration set by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set to update.. | [required]
 **enumerationSet** | **PIEnumerationSet**| A partial enumeration set containing the desired changes.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete an enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set to delete.. | [required]


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Delete**
> Delete(string webId)

Delete an enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set to delete.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetValuesWithHttpInfo**
> GetValuesWithHttpInfo(string webId, string selectedFields = null)

Retrieve an enumeration set's values.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIItemsEnumerationValue**](../Response/ApiResponsePIItemsEnumerationValue.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetValues**
> GetValues(string webId, string selectedFields = null)

Retrieve an enumeration set's values.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIItemsEnumerationValue**](../Model/PIItemsEnumerationValue.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateValueWithHttpInfo**
> CreateValueWithHttpInfo(string webId, PIEnumerationValue enumerationValue)

Create an enumeration value for a enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set on which to create the enumeration value.. | [required]
 **enumerationValue** | **PIEnumerationValue**| The new enumeration value definition.. | [required]


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateValue**
> CreateValue(string webId, PIEnumerationValue enumerationValue)

Create an enumeration value for a enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set on which to create the enumeration value.. | [required]
 **enumerationValue** | **PIEnumerationValue**| The new enumeration value definition.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityWithHttpInfo**
> GetSecurityWithHttpInfo(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)

Get the security information of the specified security item associated with the enumeration set for a specified user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set for the security to be checked.. | [required]
 **userIdentities** | **string**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. | [required] - join strings separated by ','
 **forceRefresh** | **bool**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIItemsSecurityRights**](../Response/ApiResponsePIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurity**
> GetSecurity(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)

Get the security information of the specified security item associated with the enumeration set for a specified user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set for the security to be checked.. | [required]
 **userIdentities** | **string**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. | [required] - join strings separated by ','
 **forceRefresh** | **bool**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIItemsSecurityRights**](../Model/PIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntriesWithHttpInfo**
> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the enumeration set based on the specified criteria. By default, all security entries for this enumeration set are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set.. | [required]
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. | [optional] - always use empty strings("") instead of Null
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePIItemsSecurityEntry**](../Response/ApiResponsePIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntries**
> GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the enumeration set based on the specified criteria. By default, all security entries for this enumeration set are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set.. | [required]
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. | [optional] - always use empty strings("") instead of Null
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**PIItemsSecurityEntry**](../Model/PIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSecurityEntryWithHttpInfo**
> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool applyToChildren)

Create a security entry owned by the enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set where the security entry will be created.. | [required]
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. | [required]
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [required]


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSecurityEntry**
> CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren)

Create a security entry owned by the enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the enumeration set where the security entry will be created.. | [required]
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. | [required]
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntryByNameWithHttpInfo**
> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the enumeration set with the specified name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. | [required]
 **webId** | **string**| The ID of the enumeration set.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**ApiResponsePISecurityEntry**](../Response/ApiResponsePISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntryByName**
> GetSecurityEntryByName(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the enumeration set with the specified name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. | [required]
 **webId** | **string**| The ID of the enumeration set.. | [required]
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. | [optional] - always use empty strings("") instead of Null


### Return type

[**PISecurityEntry**](../Model/PISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateSecurityEntryWithHttpInfo**
> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)

Update a security entry owned by the enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. | [required]
 **webId** | **string**| The ID of the enumeration set where the security entry will be updated.. | [required]
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. | [required]
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [required]


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateSecurityEntry**
> UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)

Update a security entry owned by the enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. | [required]
 **webId** | **string**| The ID of the enumeration set where the security entry will be updated.. | [required]
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. | [required]
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteSecurityEntryWithHttpInfo**
> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool applyToChildren)

Delete a security entry owned by the enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. | [required]
 **webId** | **string**| The ID of the enumeration set where the security entry will be deleted.. | [required]
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [required]


### Return type

[**ApiResponseObject**](../Response/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteSecurityEntry**
> DeleteSecurityEntry(string name, string webId, bool applyToChildren)

Delete a security entry owned by the enumeration set.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. | [required]
 **webId** | **string**| The ID of the enumeration set where the security entry will be deleted.. | [required]
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. | [required]


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
