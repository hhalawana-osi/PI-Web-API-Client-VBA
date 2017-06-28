# ElementApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](ElementApi.md#getbypath) | **GET** /elements | Retrieve an element by path.
[**GetByPathWithHttpInfo**](ElementApi.md#getbypathwithhttpinfo) | **GET** /elements | Retrieve an element by path.
[**Get**](ElementApi.md#get) | **GET** /elements/{webId} | Retrieve an element.
[**GetWithHttpInfo**](ElementApi.md#getwithhttpinfo) | **GET** /elements/{webId} | Retrieve an element.
[**Update**](ElementApi.md#update) | **PATCH** /elements/{webId} | Update an element by replacing items in its definition.
[**UpdateWithHttpInfo**](ElementApi.md#updatewithhttpinfo) | **PATCH** /elements/{webId} | Update an element by replacing items in its definition.
[**Delete**](ElementApi.md#delete) | **DELETE** /elements/{webId} | Delete an element.
[**DeleteWithHttpInfo**](ElementApi.md#deletewithhttpinfo) | **DELETE** /elements/{webId} | Delete an element.
[**GetAnalyses**](ElementApi.md#getanalyses) | **GET** /elements/{webId}/analyses | Retrieve analyses based on the specified conditions.
[**GetAnalysesWithHttpInfo**](ElementApi.md#getanalyseswithhttpinfo) | **GET** /elements/{webId}/analyses | Retrieve analyses based on the specified conditions.
[**CreateAnalysis**](ElementApi.md#createanalysis) | **POST** /elements/{webId}/analyses | Create an Analysis.
[**CreateAnalysisWithHttpInfo**](ElementApi.md#createanalysiswithhttpinfo) | **POST** /elements/{webId}/analyses | Create an Analysis.
[**GetAttributes**](ElementApi.md#getattributes) | **GET** /elements/{webId}/attributes | Get the attributes of the specified element.
[**GetAttributesWithHttpInfo**](ElementApi.md#getattributeswithhttpinfo) | **GET** /elements/{webId}/attributes | Get the attributes of the specified element.
[**CreateAttribute**](ElementApi.md#createattribute) | **POST** /elements/{webId}/attributes | Create a new attribute of the specified element.
[**CreateAttributeWithHttpInfo**](ElementApi.md#createattributewithhttpinfo) | **POST** /elements/{webId}/attributes | Create a new attribute of the specified element.
[**GetCategories**](ElementApi.md#getcategories) | **GET** /elements/{webId}/categories | Get an element's categories.
[**GetCategoriesWithHttpInfo**](ElementApi.md#getcategorieswithhttpinfo) | **GET** /elements/{webId}/categories | Get an element's categories.
[**CreateConfig**](ElementApi.md#createconfig) | **POST** /elements/{webId}/config | Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.
[**CreateConfigWithHttpInfo**](ElementApi.md#createconfigwithhttpinfo) | **POST** /elements/{webId}/config | Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.
[**FindElementAttributes**](ElementApi.md#findelementattributes) | **GET** /elements/{webId}/elementattributes | Retrieves a list of element attributes matching the specified filters from the specified element.
[**FindElementAttributesWithHttpInfo**](ElementApi.md#findelementattributeswithhttpinfo) | **GET** /elements/{webId}/elementattributes | Retrieves a list of element attributes matching the specified filters from the specified element.
[**GetElements**](ElementApi.md#getelements) | **GET** /elements/{webId}/elements | Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.
[**GetElementsWithHttpInfo**](ElementApi.md#getelementswithhttpinfo) | **GET** /elements/{webId}/elements | Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.
[**CreateElement**](ElementApi.md#createelement) | **POST** /elements/{webId}/elements | Create a child element.
[**CreateElementWithHttpInfo**](ElementApi.md#createelementwithhttpinfo) | **POST** /elements/{webId}/elements | Create a child element.
[**GetEventFrames**](ElementApi.md#geteventframes) | **GET** /elements/{webId}/eventframes | Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.
[**GetEventFramesWithHttpInfo**](ElementApi.md#geteventframeswithhttpinfo) | **GET** /elements/{webId}/eventframes | Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.
[**GetReferencedElements**](ElementApi.md#getreferencedelements) | **GET** /elements/{webId}/referencedelements | Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.
[**GetReferencedElementsWithHttpInfo**](ElementApi.md#getreferencedelementswithhttpinfo) | **GET** /elements/{webId}/referencedelements | Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.
[**AddReferencedElement**](ElementApi.md#addreferencedelement) | **POST** /elements/{webId}/referencedelements | Add a reference to an existing element to the child elements collection.
[**AddReferencedElementWithHttpInfo**](ElementApi.md#addreferencedelementwithhttpinfo) | **POST** /elements/{webId}/referencedelements | Add a reference to an existing element to the child elements collection.
[**RemoveReferencedElement**](ElementApi.md#removereferencedelement) | **DELETE** /elements/{webId}/referencedelements | Remove a reference to an existing element from the child elements collection.
[**RemoveReferencedElementWithHttpInfo**](ElementApi.md#removereferencedelementwithhttpinfo) | **DELETE** /elements/{webId}/referencedelements | Remove a reference to an existing element from the child elements collection.
[**GetSecurity**](ElementApi.md#getsecurity) | **GET** /elements/{webId}/security | Get the security information of the specified security item associated with the element for a specified user.
[**GetSecurityWithHttpInfo**](ElementApi.md#getsecuritywithhttpinfo) | **GET** /elements/{webId}/security | Get the security information of the specified security item associated with the element for a specified user.
[**GetSecurityEntries**](ElementApi.md#getsecurityentries) | **GET** /elements/{webId}/securityentries | Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.
[**GetSecurityEntriesWithHttpInfo**](ElementApi.md#getsecurityentrieswithhttpinfo) | **GET** /elements/{webId}/securityentries | Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.
[**CreateSecurityEntry**](ElementApi.md#createsecurityentry) | **POST** /elements/{webId}/securityentries | Create a security entry owned by the element.
[**CreateSecurityEntryWithHttpInfo**](ElementApi.md#createsecurityentrywithhttpinfo) | **POST** /elements/{webId}/securityentries | Create a security entry owned by the element.
[**GetSecurityEntryByName**](ElementApi.md#getsecurityentrybyname) | **GET** /elements/{webId}/securityentries/{name} | Retrieve the security entry associated with the element with the specified name.
[**GetSecurityEntryByNameWithHttpInfo**](ElementApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /elements/{webId}/securityentries/{name} | Retrieve the security entry associated with the element with the specified name.
[**UpdateSecurityEntry**](ElementApi.md#updatesecurityentry) | **PUT** /elements/{webId}/securityentries/{name} | Update a security entry owned by the element.
[**UpdateSecurityEntryWithHttpInfo**](ElementApi.md#updatesecurityentrywithhttpinfo) | **PUT** /elements/{webId}/securityentries/{name} | Update a security entry owned by the element.
[**DeleteSecurityEntry**](ElementApi.md#deletesecurityentry) | **DELETE** /elements/{webId}/securityentries/{name} | Delete a security entry owned by the element.
[**DeleteSecurityEntryWithHttpInfo**](ElementApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /elements/{webId}/securityentries/{name} | Delete a security entry owned by the element.
[**GetMultiple**](ElementApi.md#getmultiple) | **GET** /elements/multiple | Retrieve multiple elements by web id or path.
[**GetMultipleWithHttpInfo**](ElementApi.md#getmultiplewithhttpinfo) | **GET** /elements/multiple | Retrieve multiple elements by web id or path.
[**CreateSearchByAttribute**](ElementApi.md#createsearchbyattribute) | **POST** /elements/searchbyattribute | Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
[**CreateSearchByAttributeWithHttpInfo**](ElementApi.md#createsearchbyattributewithhttpinfo) | **POST** /elements/searchbyattribute | Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
[**ExecuteSearchByAttribute**](ElementApi.md#executesearchbyattribute) | **GET** /elements/searchbyattribute/{searchId} | Execute a "Search Elements By Attribute Value" operation.
[**ExecuteSearchByAttributeWithHttpInfo**](ElementApi.md#executesearchbyattributewithhttpinfo) | **GET** /elements/searchbyattribute/{searchId} | Execute a "Search Elements By Attribute Value" operation.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an element by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the element.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIElement**](../Responses/ApiResponsePIElement.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve an element by path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to the element.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIElement**](../Model/PIElement.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIElement**](../Responses/ApiResponsePIElement.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve an element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIElement**](../Model/PIElement.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIElement element)

Update an element by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |
 **element** | **PIElement**| A partial element containing the desired changes.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Update**
> Update(string webId, PIElement element)

Update an element by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |
 **element** | **PIElement**| A partial element containing the desired changes.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete an element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **Delete**
> Delete(string webId)

Delete an element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAnalysesWithHttpInfo**
> GetAnalysesWithHttpInfo(string webId, int maxCount, int startIndex, string selectedFields = null, string sortField = null, string sortOrder = null)

Retrieve analyses based on the specified conditions.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element, which is the Target of the analyses.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |


### Return type

[**ApiResponsePIItemsAnalysis**](../Responses/ApiResponsePIItemsAnalysis.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAnalyses**
> GetAnalyses(string webId, int maxCount, int startIndex, string selectedFields = null, string sortField = null, string sortOrder = null)

Retrieve analyses based on the specified conditions.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element, which is the Target of the analyses.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |


### Return type

[**PIItemsAnalysis**](../Model/PIItemsAnalysis.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateAnalysisWithHttpInfo**
> CreateAnalysisWithHttpInfo(string webId, PIAnalysis analysis)

Create an Analysis.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element on which to create the Analysis.. |
 **analysis** | **PIAnalysis**| The new Analysis definition.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateAnalysis**
> CreateAnalysis(string webId, PIAnalysis analysis)

Create an Analysis.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element on which to create the Analysis.. |
 **analysis** | **PIAnalysis**| The new Analysis definition.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetAttributesWithHttpInfo**
> GetAttributesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, int startIndex, string categoryName = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null, string valueType = null)

Get the attributes of the specified element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |
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

Get the attributes of the specified element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |
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

Create a new attribute of the specified element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element on which to create the attribute.. |
 **attribute** | **PIAttribute**| The definition of the new attribute.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateAttribute**
> CreateAttribute(string webId, PIAttribute attribute)

Create a new attribute of the specified element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element on which to create the attribute.. |
 **attribute** | **PIAttribute**| The definition of the new attribute.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetCategoriesWithHttpInfo**
> GetCategoriesWithHttpInfo(string webId, string selectedFields = null)

Get an element's categories.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsElementCategory**](../Responses/ApiResponsePIItemsElementCategory.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetCategories**
> GetCategories(string webId, string selectedFields = null)

Get an element's categories.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsElementCategory**](../Model/PIItemsElementCategory.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateConfigWithHttpInfo**
> CreateConfigWithHttpInfo(string webId, bool includeChildElements)

Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |
 **includeChildElements** | **bool**| If true, includes the child elements of the specified element.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateConfig**
> CreateConfig(string webId, bool includeChildElements)

Executes the create configuration function of the data references found within the attributes of the element, and optionally, its children.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |
 **includeChildElements** | **bool**| If true, includes the child elements of the specified element.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **FindElementAttributesWithHttpInfo**
> FindElementAttributesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, string selectedFields = null, string sortField = null, string sortOrder = null)

Retrieves a list of element attributes matching the specified filters from the specified element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element to use as the root of the search.. |
 **maxCount** | **int**| The maximum number of objects to be returned (the page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **attributeCategory** | **string**| Specify that returned attributes must have this category. The default is no filter.. |
 **attributeDescriptionFilter** | **string**| The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. |
 **attributeNameFilter** | **string**| The attribute name filter string used for finding objects. The default is no filter.. |
 **attributeType** | **string**| Specify that returned attributes' value type must be this value type. The default is no filter.. |
 **elementCategory** | **string**| Specify that the owner of the returned attributes must have this category. The default is no filter.. |
 **elementDescriptionFilter** | **string**| The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. |
 **elementNameFilter** | **string**| The element name filter string used for finding objects. The default is no filter.. |
 **elementTemplate** | **string**| Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.. |
 **elementType** | **string**| Specify that the element of the returned attributes must have this AFElementType. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |


### Return type

[**ApiResponsePIItemsAttribute**](../Responses/ApiResponsePIItemsAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **FindElementAttributes**
> FindElementAttributes(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string elementCategory = null, string elementDescriptionFilter = null, string elementNameFilter = null, string elementTemplate = null, string elementType = null, string selectedFields = null, string sortField = null, string sortOrder = null)

Retrieves a list of element attributes matching the specified filters from the specified element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element to use as the root of the search.. |
 **maxCount** | **int**| The maximum number of objects to be returned (the page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **attributeCategory** | **string**| Specify that returned attributes must have this category. The default is no filter.. |
 **attributeDescriptionFilter** | **string**| The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. |
 **attributeNameFilter** | **string**| The attribute name filter string used for finding objects. The default is no filter.. |
 **attributeType** | **string**| Specify that returned attributes' value type must be this value type. The default is no filter.. |
 **elementCategory** | **string**| Specify that the owner of the returned attributes must have this category. The default is no filter.. |
 **elementDescriptionFilter** | **string**| The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. |
 **elementNameFilter** | **string**| The element name filter string used for finding objects. The default is no filter.. |
 **elementTemplate** | **string**| Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.. |
 **elementType** | **string**| Specify that the element of the returned attributes must have this AFElementType. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |


### Return type

[**PIItemsAttribute**](../Model/PIItemsAttribute.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetElementsWithHttpInfo**
> GetElementsWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string descriptionFilter = null, string elementType = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null)

Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element to use as the root of the search.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **categoryName** | **string**| Specify that returned elements must have this category. The default is no category filter.. |
 **descriptionFilter** | **string**| Specify that returned elements must have this description. The default is no description filter.. |
 **elementType** | **string**| Specify that returned elements must have this type. The default type is 'Any'.. |
 **nameFilter** | **string**| The name query string used for finding objects. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **templateName** | **string**| Specify that returned elements must have this template or a template derived from this template. The default is no template filter.. |


### Return type

[**ApiResponsePIItemsElement**](../Responses/ApiResponsePIItemsElement.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetElements**
> GetElements(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string descriptionFilter = null, string elementType = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null)

Retrieve elements based on the specified conditions. By default, this method selects immediate children of the specified element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element to use as the root of the search.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **categoryName** | **string**| Specify that returned elements must have this category. The default is no category filter.. |
 **descriptionFilter** | **string**| Specify that returned elements must have this description. The default is no description filter.. |
 **elementType** | **string**| Specify that returned elements must have this type. The default type is 'Any'.. |
 **nameFilter** | **string**| The name query string used for finding objects. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **templateName** | **string**| Specify that returned elements must have this template or a template derived from this template. The default is no template filter.. |


### Return type

[**PIItemsElement**](../Model/PIItemsElement.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateElementWithHttpInfo**
> CreateElementWithHttpInfo(string webId, PIElement element)

Create a child element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent element on which to create the element.. |
 **element** | **PIElement**| The new element definition.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateElement**
> CreateElement(string webId, PIElement element)

Create a child element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent element on which to create the element.. |
 **element** | **PIElement**| The new element definition.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetEventFramesWithHttpInfo**
> GetEventFramesWithHttpInfo(string webId, bool canBeAcknowledged, bool isAcknowledged, int maxCount, int startIndex, string categoryName = null, string endTime = null, string nameFilter = null, string searchMode = null, string selectedFields = null, string severities = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null)

Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element whose related event frames are sought.. |
 **canBeAcknowledged** | **bool**| Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.. |
 **isAcknowledged** | **bool**| Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **categoryName** | **string**| Specify that returned event frames must have this category. The default is no category filter.. |
 **endTime** | **string**| The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.. |
 **nameFilter** | **string**| The name query string used for finding event frames. The default is no filter.. |
 **searchMode** | **string**| Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **severities** | **string**| Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.. |
 **startTime** | **string**| The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.. |
 **templateName** | **string**| Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.. |


### Return type

[**ApiResponsePIItemsEventFrame**](../Responses/ApiResponsePIItemsEventFrame.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetEventFrames**
> GetEventFrames(string webId, bool canBeAcknowledged, bool isAcknowledged, int maxCount, int startIndex, string categoryName = null, string endTime = null, string nameFilter = null, string searchMode = null, string selectedFields = null, string severities = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null)

Retrieve event frames that reference this element based on the specified conditions. By default, returns all event frames that reference this element with a start time in the past 8 hours.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element whose related event frames are sought.. |
 **canBeAcknowledged** | **bool**| Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.. |
 **isAcknowledged** | **bool**| Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **categoryName** | **string**| Specify that returned event frames must have this category. The default is no category filter.. |
 **endTime** | **string**| The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.. |
 **nameFilter** | **string**| The name query string used for finding event frames. The default is no filter.. |
 **searchMode** | **string**| Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **severities** | **string**| Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.. |
 **startTime** | **string**| The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.. |
 **templateName** | **string**| Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.. |


### Return type

[**PIItemsEventFrame**](../Model/PIItemsEventFrame.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetReferencedElementsWithHttpInfo**
> GetReferencedElementsWithHttpInfo(string webId, int maxCount, int startIndex, string categoryName = null, string descriptionFilter = null, string elementType = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null)

Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the resource to use as the root of the search.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **categoryName** | **string**| Specify that returned elements must have this category. The default is no category filter.. |
 **descriptionFilter** | **string**| Specify that returned elements must have this description. The default is no description filter.. |
 **elementType** | **string**| Specify that returned elements must have this type. The default type is 'Any'.. |
 **nameFilter** | **string**| The name query string used for finding objects. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **templateName** | **string**| Specify that returned elements must have this template or a template derived from this template. The default is no template filter.. |


### Return type

[**ApiResponsePIItemsElement**](../Responses/ApiResponsePIItemsElement.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetReferencedElements**
> GetReferencedElements(string webId, int maxCount, int startIndex, string categoryName = null, string descriptionFilter = null, string elementType = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null)

Retrieve referenced elements based on the specified conditions. By default, this method selects all referenced elements of the current resource.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the resource to use as the root of the search.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **categoryName** | **string**| Specify that returned elements must have this category. The default is no category filter.. |
 **descriptionFilter** | **string**| Specify that returned elements must have this description. The default is no description filter.. |
 **elementType** | **string**| Specify that returned elements must have this type. The default type is 'Any'.. |
 **nameFilter** | **string**| The name query string used for finding objects. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **templateName** | **string**| Specify that returned elements must have this template or a template derived from this template. The default is no template filter.. |


### Return type

[**PIItemsElement**](../Model/PIItemsElement.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **AddReferencedElementWithHttpInfo**
> AddReferencedElementWithHttpInfo(string webId, string referencedElementWebIds, string referenceType = null)

Add a reference to an existing element to the child elements collection.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element which the referenced element will be added to.. |
 **referencedElementWebIds** | **string**| The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.. |
 **referenceType** | **string**| The name of the reference type between the parent and the referenced element. The default is "parent-child".. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **AddReferencedElement**
> AddReferencedElement(string webId, string referencedElementWebIds, string referenceType = null)

Add a reference to an existing element to the child elements collection.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element which the referenced element will be added to.. |
 **referencedElementWebIds** | **string**| The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.. |
 **referenceType** | **string**| The name of the reference type between the parent and the referenced element. The default is "parent-child".. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **RemoveReferencedElementWithHttpInfo**
> RemoveReferencedElementWithHttpInfo(string webId, string referencedElementWebIds)

Remove a reference to an existing element from the child elements collection.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element which the referenced element will be removed from.. |
 **referencedElementWebIds** | **string**| The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **RemoveReferencedElement**
> RemoveReferencedElement(string webId, string referencedElementWebIds)

Remove a reference to an existing element from the child elements collection.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element which the referenced element will be removed from.. |
 **referencedElementWebIds** | **string**| The ID of the referenced element. Multiple referenced elements may be specified with multiple instances of the parameter.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityWithHttpInfo**
> GetSecurityWithHttpInfo(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)

Get the security information of the specified security item associated with the element for a specified user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element for the security to be checked.. |
 **userIdentities** | **string**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. |
 **forceRefresh** | **bool**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsSecurityRights**](../Responses/ApiResponsePIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurity**
> GetSecurity(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)

Get the security information of the specified security item associated with the element for a specified user.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element for the security to be checked.. |
 **userIdentities** | **string**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. |
 **forceRefresh** | **bool**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsSecurityRights**](../Model/PIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntriesWithHttpInfo**
> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsSecurityEntry**](../Responses/ApiResponsePIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntries**
> GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the element based on the specified criteria. By default, all security entries for this element are returned.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element.. |
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsSecurityEntry**](../Model/PIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSecurityEntryWithHttpInfo**
> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool applyToChildren)

Create a security entry owned by the element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element where the security entry will be created.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSecurityEntry**
> CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren)

Create a security entry owned by the element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the element where the security entry will be created.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntryByNameWithHttpInfo**
> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the element with the specified name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the element.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePISecurityEntry**](../Responses/ApiResponsePISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetSecurityEntryByName**
> GetSecurityEntryByName(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the element with the specified name.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the element.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PISecurityEntry**](../Model/PISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateSecurityEntryWithHttpInfo**
> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)

Update a security entry owned by the element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. |
 **webId** | **string**| The ID of the element where the security entry will be updated.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **UpdateSecurityEntry**
> UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)

Update a security entry owned by the element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. |
 **webId** | **string**| The ID of the element where the security entry will be updated.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteSecurityEntryWithHttpInfo**
> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool applyToChildren)

Delete a security entry owned by the element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the element where the security entry will be deleted.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **DeleteSecurityEntry**
> DeleteSecurityEntry(string name, string webId, bool applyToChildren)

Delete a security entry owned by the element.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the element where the security entry will be deleted.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetMultipleWithHttpInfo**
> GetMultipleWithHttpInfo(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null)

Retrieve multiple elements by web id or path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **asParallel** | **bool**| Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.. |
 **includeMode** | **string**| The include mode for the return list. The default is 'All'.. |
 **paths** | **string**| The path of an element. Multiple elements may be specified with multiple instances of the parameter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **webIds** | **string**| The ID of an element. Multiple elements may be specified with multiple instances of the parameter.. |


### Return type

[**ApiResponsePIItemsItemElement**](../Responses/ApiResponsePIItemsItemElement.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **GetMultiple**
> GetMultiple(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null)

Retrieve multiple elements by web id or path.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **asParallel** | **bool**| Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.. |
 **includeMode** | **string**| The include mode for the return list. The default is 'All'.. |
 **paths** | **string**| The path of an element. Multiple elements may be specified with multiple instances of the parameter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **webIds** | **string**| The ID of an element. Multiple elements may be specified with multiple instances of the parameter.. |


### Return type

[**PIItemsItemElement**](../Model/PIItemsItemElement.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSearchByAttributeWithHttpInfo**
> CreateSearchByAttributeWithHttpInfo()

Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **CreateSearchByAttribute**
> CreateSearchByAttribute()

Create a link for a "Search Elements By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root Element. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the Elements. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **ExecuteSearchByAttributeWithHttpInfo**
> ExecuteSearchByAttributeWithHttpInfo(string searchId, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string descriptionFilter = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null)

Execute a "Search Elements By Attribute Value" operation.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **searchId** | **string**| The encoded search Id of the "Search Elements By Attribute Value" operation.. |
 **maxCount** | **int**| The maximum number of objects to be returned. The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **categoryName** | **string**| Specify that the owner of the returned attributes must have this category. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. |
 **descriptionFilter** | **string**| The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. |
 **nameFilter** | **string**| The name query string used for finding objects. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **ExecuteSearchByAttribute**
> ExecuteSearchByAttribute(string searchId, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string descriptionFilter = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null)

Execute a "Search Elements By Attribute Value" operation.

### Parameters

Name | Type | Description | Notes
------------- | ------------- | ------------- | -------------
 **searchId** | **string**| The encoded search Id of the "Search Elements By Attribute Value" operation.. |
 **maxCount** | **int**| The maximum number of objects to be returned. The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include objects nested further than the immediate children of the searchRoot. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **categoryName** | **string**| Specify that the owner of the returned attributes must have this category. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. |
 **descriptionFilter** | **string**| The element description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. |
 **nameFilter** | **string**| The name query string used for finding objects. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)
