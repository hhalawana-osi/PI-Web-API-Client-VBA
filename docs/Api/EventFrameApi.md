# EventFrameApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetByPath**](EventFrameApi.md#getbypath) | **GET** /eventframes | Retrieve an event frame by path.
[**GetByPathWithHttpInfo**](EventFrameApi.md#getbypathwithhttpinfo) | **GET** /eventframes | Retrieve an event frame by path.
[**Get**](EventFrameApi.md#get) | **GET** /eventframes/{webId} | Retrieve an event frame.
[**GetWithHttpInfo**](EventFrameApi.md#getwithhttpinfo) | **GET** /eventframes/{webId} | Retrieve an event frame.
[**Update**](EventFrameApi.md#update) | **PATCH** /eventframes/{webId} | Update an event frame by replacing items in its definition.
[**UpdateWithHttpInfo**](EventFrameApi.md#updatewithhttpinfo) | **PATCH** /eventframes/{webId} | Update an event frame by replacing items in its definition.
[**Delete**](EventFrameApi.md#delete) | **DELETE** /eventframes/{webId} | Delete an event frame.
[**DeleteWithHttpInfo**](EventFrameApi.md#deletewithhttpinfo) | **DELETE** /eventframes/{webId} | Delete an event frame.
[**Acknowledge**](EventFrameApi.md#acknowledge) | **PATCH** /eventframes/{webId}/acknowledge | Calls the EventFrame's Acknowledge method.
[**AcknowledgeWithHttpInfo**](EventFrameApi.md#acknowledgewithhttpinfo) | **PATCH** /eventframes/{webId}/acknowledge | Calls the EventFrame's Acknowledge method.
[**GetAnnotations**](EventFrameApi.md#getannotations) | **GET** /eventframes/{webId}/annotations | Get an event frame's annotations.
[**GetAnnotationsWithHttpInfo**](EventFrameApi.md#getannotationswithhttpinfo) | **GET** /eventframes/{webId}/annotations | Get an event frame's annotations.
[**CreateAnnotation**](EventFrameApi.md#createannotation) | **POST** /eventframes/{webId}/annotations | Create an annotation on an event frame.
[**CreateAnnotationWithHttpInfo**](EventFrameApi.md#createannotationwithhttpinfo) | **POST** /eventframes/{webId}/annotations | Create an annotation on an event frame.
[**GetAnnotationById**](EventFrameApi.md#getannotationbyid) | **GET** /eventframes/{webId}/annotations/{id} | Get a specific annotation on an event frame.
[**GetAnnotationByIdWithHttpInfo**](EventFrameApi.md#getannotationbyidwithhttpinfo) | **GET** /eventframes/{webId}/annotations/{id} | Get a specific annotation on an event frame.
[**UpdateAnnotation**](EventFrameApi.md#updateannotation) | **PATCH** /eventframes/{webId}/annotations/{id} | Update an annotation on an event frame by replacing items in its definition.
[**UpdateAnnotationWithHttpInfo**](EventFrameApi.md#updateannotationwithhttpinfo) | **PATCH** /eventframes/{webId}/annotations/{id} | Update an annotation on an event frame by replacing items in its definition.
[**DeleteAnnotation**](EventFrameApi.md#deleteannotation) | **DELETE** /eventframes/{webId}/annotations/{id} | Delete an annotation on an event frame.
[**DeleteAnnotationWithHttpInfo**](EventFrameApi.md#deleteannotationwithhttpinfo) | **DELETE** /eventframes/{webId}/annotations/{id} | Delete an annotation on an event frame.
[**GetAttributes**](EventFrameApi.md#getattributes) | **GET** /eventframes/{webId}/attributes | Get the attributes of the specified event frame.
[**GetAttributesWithHttpInfo**](EventFrameApi.md#getattributeswithhttpinfo) | **GET** /eventframes/{webId}/attributes | Get the attributes of the specified event frame.
[**CreateAttribute**](EventFrameApi.md#createattribute) | **POST** /eventframes/{webId}/attributes | Create a new attribute of the specified event frame.
[**CreateAttributeWithHttpInfo**](EventFrameApi.md#createattributewithhttpinfo) | **POST** /eventframes/{webId}/attributes | Create a new attribute of the specified event frame.
[**CaptureValues**](EventFrameApi.md#capturevalues) | **POST** /eventframes/{webId}/attributes/capture | Calls the EventFrame's CaptureValues method.
[**CaptureValuesWithHttpInfo**](EventFrameApi.md#capturevalueswithhttpinfo) | **POST** /eventframes/{webId}/attributes/capture | Calls the EventFrame's CaptureValues method.
[**GetCategories**](EventFrameApi.md#getcategories) | **GET** /eventframes/{webId}/categories | Get an event frame's categories.
[**GetCategoriesWithHttpInfo**](EventFrameApi.md#getcategorieswithhttpinfo) | **GET** /eventframes/{webId}/categories | Get an event frame's categories.
[**CreateConfig**](EventFrameApi.md#createconfig) | **POST** /eventframes/{webId}/config | Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.
[**CreateConfigWithHttpInfo**](EventFrameApi.md#createconfigwithhttpinfo) | **POST** /eventframes/{webId}/config | Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.
[**FindEventFrameAttributes**](EventFrameApi.md#findeventframeattributes) | **GET** /eventframes/{webId}/eventframeattributes | Retrieves a list of event frame attributes matching the specified filters from the specified event frame.
[**FindEventFrameAttributesWithHttpInfo**](EventFrameApi.md#findeventframeattributeswithhttpinfo) | **GET** /eventframes/{webId}/eventframeattributes | Retrieves a list of event frame attributes matching the specified filters from the specified event frame.
[**GetEventFrames**](EventFrameApi.md#geteventframes) | **GET** /eventframes/{webId}/eventframes | Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.
[**GetEventFramesWithHttpInfo**](EventFrameApi.md#geteventframeswithhttpinfo) | **GET** /eventframes/{webId}/eventframes | Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.
[**CreateEventFrame**](EventFrameApi.md#createeventframe) | **POST** /eventframes/{webId}/eventframes | Create an event frame as a child of the specified event frame.
[**CreateEventFrameWithHttpInfo**](EventFrameApi.md#createeventframewithhttpinfo) | **POST** /eventframes/{webId}/eventframes | Create an event frame as a child of the specified event frame.
[**GetReferencedElements**](EventFrameApi.md#getreferencedelements) | **GET** /eventframes/{webId}/referencedelements | Retrieve the event frame's referenced elements.
[**GetReferencedElementsWithHttpInfo**](EventFrameApi.md#getreferencedelementswithhttpinfo) | **GET** /eventframes/{webId}/referencedelements | Retrieve the event frame's referenced elements.
[**GetSecurity**](EventFrameApi.md#getsecurity) | **GET** /eventframes/{webId}/security | Get the security information of the specified security item associated with the event frame for a specified user.
[**GetSecurityWithHttpInfo**](EventFrameApi.md#getsecuritywithhttpinfo) | **GET** /eventframes/{webId}/security | Get the security information of the specified security item associated with the event frame for a specified user.
[**GetSecurityEntries**](EventFrameApi.md#getsecurityentries) | **GET** /eventframes/{webId}/securityentries | Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.
[**GetSecurityEntriesWithHttpInfo**](EventFrameApi.md#getsecurityentrieswithhttpinfo) | **GET** /eventframes/{webId}/securityentries | Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.
[**CreateSecurityEntry**](EventFrameApi.md#createsecurityentry) | **POST** /eventframes/{webId}/securityentries | Create a security entry owned by the event frame.
[**CreateSecurityEntryWithHttpInfo**](EventFrameApi.md#createsecurityentrywithhttpinfo) | **POST** /eventframes/{webId}/securityentries | Create a security entry owned by the event frame.
[**GetSecurityEntryByName**](EventFrameApi.md#getsecurityentrybyname) | **GET** /eventframes/{webId}/securityentries/{name} | Retrieve the security entry associated with the event frame with the specified name.
[**GetSecurityEntryByNameWithHttpInfo**](EventFrameApi.md#getsecurityentrybynamewithhttpinfo) | **GET** /eventframes/{webId}/securityentries/{name} | Retrieve the security entry associated with the event frame with the specified name.
[**UpdateSecurityEntry**](EventFrameApi.md#updatesecurityentry) | **PUT** /eventframes/{webId}/securityentries/{name} | Update a security entry owned by the event frame.
[**UpdateSecurityEntryWithHttpInfo**](EventFrameApi.md#updatesecurityentrywithhttpinfo) | **PUT** /eventframes/{webId}/securityentries/{name} | Update a security entry owned by the event frame.
[**DeleteSecurityEntry**](EventFrameApi.md#deletesecurityentry) | **DELETE** /eventframes/{webId}/securityentries/{name} | Delete a security entry owned by the event frame.
[**DeleteSecurityEntryWithHttpInfo**](EventFrameApi.md#deletesecurityentrywithhttpinfo) | **DELETE** /eventframes/{webId}/securityentries/{name} | Delete a security entry owned by the event frame.
[**GetMultiple**](EventFrameApi.md#getmultiple) | **GET** /eventframes/multiple | Retrieve multiple event frames by web ids or paths.
[**GetMultipleWithHttpInfo**](EventFrameApi.md#getmultiplewithhttpinfo) | **GET** /eventframes/multiple | Retrieve multiple event frames by web ids or paths.
[**CreateSearchByAttribute**](EventFrameApi.md#createsearchbyattribute) | **POST** /eventframes/searchbyattribute | Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
[**CreateSearchByAttributeWithHttpInfo**](EventFrameApi.md#createsearchbyattributewithhttpinfo) | **POST** /eventframes/searchbyattribute | Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.
[**ExecuteSearchByAttribute**](EventFrameApi.md#executesearchbyattribute) | **GET** /eventframes/searchbyattribute/{searchId} | Execute a "Search EventFrames By Attribute Value" operation.
[**ExecuteSearchByAttributeWithHttpInfo**](EventFrameApi.md#executesearchbyattributewithhttpinfo) | **GET** /eventframes/searchbyattribute/{searchId} | Execute a "Search EventFrames By Attribute Value" operation.


# **GetByPathWithHttpInfo**
> GetByPathWithHttpInfo(string path, string selectedFields = null)

Retrieve an event frame by path.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **path** | **string**| The path to the event frame.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIEventFrame**](../Responses/ApiResponsePIEventFrame.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetByPath**
> GetByPath(string path, string selectedFields = null)

Retrieve an event frame by path.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **path** | **string**| The path to the event frame.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIEventFrame**](../Model/PIEventFrame.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetWithHttpInfo**
> GetWithHttpInfo(string webId, string selectedFields = null)

Retrieve an event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIEventFrame**](../Responses/ApiResponsePIEventFrame.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Get**
> Get(string webId, string selectedFields = null)

Retrieve an event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIEventFrame**](../Model/PIEventFrame.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateWithHttpInfo**
> UpdateWithHttpInfo(string webId, PIEventFrame eventFrame)

Update an event frame by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame to update.. |
 **eventFrame** | **PIEventFrame**| A partial event frame containing the desired changes.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Update**
> Update(string webId, PIEventFrame eventFrame)

Update an event frame by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame to update.. |
 **eventFrame** | **PIEventFrame**| A partial event frame containing the desired changes.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **DeleteWithHttpInfo**
> DeleteWithHttpInfo(string webId)

Delete an event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame to delete.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Delete**
> Delete(string webId)

Delete an event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame to delete.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **AcknowledgeWithHttpInfo**
> AcknowledgeWithHttpInfo(string webId)

Calls the EventFrame's Acknowledge method.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Acknowledge**
> Acknowledge(string webId)

Calls the EventFrame's Acknowledge method.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetAnnotationsWithHttpInfo**
> GetAnnotationsWithHttpInfo(string webId, string selectedFields = null)

Get an event frame's annotations.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the owner event frame.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsAnnotation**](../Responses/ApiResponsePIItemsAnnotation.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetAnnotations**
> GetAnnotations(string webId, string selectedFields = null)

Get an event frame's annotations.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the owner event frame.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsAnnotation**](../Model/PIItemsAnnotation.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateAnnotationWithHttpInfo**
> CreateAnnotationWithHttpInfo(string webId, PIAnnotation annotation)

Create an annotation on an event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the owner event frame on which to create the annotation.. |
 **annotation** | **PIAnnotation**| The new annotation definition.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateAnnotation**
> CreateAnnotation(string webId, PIAnnotation annotation)

Create an annotation on an event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the owner event frame on which to create the annotation.. |
 **annotation** | **PIAnnotation**| The new annotation definition.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetAnnotationByIdWithHttpInfo**
> GetAnnotationByIdWithHttpInfo(string id, string webId, string selectedFields = null)

Get a specific annotation on an event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **id** | **string**| The Annotation identifier of the specific annotation.. |
 **webId** | **string**| The ID of the owner event frame.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIAnnotation**](../Responses/ApiResponsePIAnnotation.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetAnnotationById**
> GetAnnotationById(string id, string webId, string selectedFields = null)

Get a specific annotation on an event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **id** | **string**| The Annotation identifier of the specific annotation.. |
 **webId** | **string**| The ID of the owner event frame.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIAnnotation**](../Model/PIAnnotation.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateAnnotationWithHttpInfo**
> UpdateAnnotationWithHttpInfo(string id, string webId, PIAnnotation annotation)

Update an annotation on an event frame by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **id** | **string**| The Annotation identifier of the annotation to be updated.. |
 **webId** | **string**| The ID of the owner event frame of the annotation to update.. |
 **annotation** | **PIAnnotation**| A partial annotation containing the desired changes.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateAnnotation**
> UpdateAnnotation(string id, string webId, PIAnnotation annotation)

Update an annotation on an event frame by replacing items in its definition.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **id** | **string**| The Annotation identifier of the annotation to be updated.. |
 **webId** | **string**| The ID of the owner event frame of the annotation to update.. |
 **annotation** | **PIAnnotation**| A partial annotation containing the desired changes.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **DeleteAnnotationWithHttpInfo**
> DeleteAnnotationWithHttpInfo(string id, string webId)

Delete an annotation on an event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **id** | **string**| The Annotation identifier of the annotation to be deleted.. |
 **webId** | **string**| The ID of the owner event frame of the annotation to delete.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **DeleteAnnotation**
> DeleteAnnotation(string id, string webId)

Delete an annotation on an event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **id** | **string**| The Annotation identifier of the annotation to be deleted.. |
 **webId** | **string**| The ID of the owner event frame of the annotation to delete.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetAttributesWithHttpInfo**
> GetAttributesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, int startIndex, string categoryName = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null, string valueType = null)

Get the attributes of the specified event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |
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

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetAttributes**
> GetAttributes(string webId, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, int startIndex, string categoryName = null, string nameFilter = null, string selectedFields = null, string sortField = null, string sortOrder = null, string templateName = null, string valueType = null)

Get the attributes of the specified event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |
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

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateAttributeWithHttpInfo**
> CreateAttributeWithHttpInfo(string webId, PIAttribute attribute)

Create a new attribute of the specified event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame on which to create the attribute.. |
 **attribute** | **PIAttribute**| The definition of the new attribute.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateAttribute**
> CreateAttribute(string webId, PIAttribute attribute)

Create a new attribute of the specified event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame on which to create the attribute.. |
 **attribute** | **PIAttribute**| The definition of the new attribute.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CaptureValuesWithHttpInfo**
> CaptureValuesWithHttpInfo(string webId)

Calls the EventFrame's CaptureValues method.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CaptureValues**
> CaptureValues(string webId)

Calls the EventFrame's CaptureValues method.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetCategoriesWithHttpInfo**
> GetCategoriesWithHttpInfo(string webId, string selectedFields = null)

Get an event frame's categories.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsElementCategory**](../Responses/ApiResponsePIItemsElementCategory.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetCategories**
> GetCategories(string webId, string selectedFields = null)

Get an event frame's categories.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsElementCategory**](../Model/PIItemsElementCategory.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateConfigWithHttpInfo**
> CreateConfigWithHttpInfo(string webId, bool includeChildElements)

Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |
 **includeChildElements** | **bool**| If true, includes the child event frames of the specified event frame.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateConfig**
> CreateConfig(string webId, bool includeChildElements)

Executes the create configuration function of the data references found within the attributes of the event frame, and optionally, its children.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |
 **includeChildElements** | **bool**| If true, includes the child event frames of the specified event frame.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **FindEventFrameAttributesWithHttpInfo**
> FindEventFrameAttributesWithHttpInfo(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, string referencedElementNameFilter = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null)

Retrieves a list of event frame attributes matching the specified filters from the specified event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame to use as the root of the search.. |
 **maxCount** | **int**| The maximum number of objects to be returned (the page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **attributeCategory** | **string**| Specify that returned attributes must have this category. The default is no filter.. |
 **attributeDescriptionFilter** | **string**| The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. |
 **attributeNameFilter** | **string**| The attribute name filter string used for finding objects. The default is no filter.. |
 **attributeType** | **string**| Specify that returned attributes' value type must be this value type. The default is no filter.. |
 **endTime** | **string**| A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.. |
 **eventFrameCategory** | **string**| Specify that the owner of the returned attributes must have this category. The default is no filter.. |
 **eventFrameDescriptionFilter** | **string**| The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. |
 **eventFrameNameFilter** | **string**| The event frame name filter string used for finding objects. The default is no filter.. |
 **eventFrameTemplate** | **string**| Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.. |
 **referencedElementNameFilter** | **string**| The name query string which must match the name of a referenced element. The default is no filter.. |
 **searchMode** | **string**| Determines how the startTime and endTime parameters are treated when searching for event frames.     The default is 'Overlapped'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **startTime** | **string**| A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.. |


### Return type

[**ApiResponsePIItemsAttribute**](../Responses/ApiResponsePIItemsAttribute.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **FindEventFrameAttributes**
> FindEventFrameAttributes(string webId, int maxCount, bool searchFullHierarchy, int startIndex, string attributeCategory = null, string attributeDescriptionFilter = null, string attributeNameFilter = null, string attributeType = null, string endTime = null, string eventFrameCategory = null, string eventFrameDescriptionFilter = null, string eventFrameNameFilter = null, string eventFrameTemplate = null, string referencedElementNameFilter = null, string searchMode = null, string selectedFields = null, string sortField = null, string sortOrder = null, string startTime = null)

Retrieves a list of event frame attributes matching the specified filters from the specified event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame to use as the root of the search.. |
 **maxCount** | **int**| The maximum number of objects to be returned (the page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include objects nested further than immediate children of the given resource. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **attributeCategory** | **string**| Specify that returned attributes must have this category. The default is no filter.. |
 **attributeDescriptionFilter** | **string**| The attribute description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. |
 **attributeNameFilter** | **string**| The attribute name filter string used for finding objects. The default is no filter.. |
 **attributeType** | **string**| Specify that returned attributes' value type must be this value type. The default is no filter.. |
 **endTime** | **string**| A string representing the latest ending time for the event frames to be matched. The endTime must be greater than or equal to the startTime. The default is '*'.. |
 **eventFrameCategory** | **string**| Specify that the owner of the returned attributes must have this category. The default is no filter.. |
 **eventFrameDescriptionFilter** | **string**| The event frame description filter string used for finding objects. Only the first 440 characters of the description will be searched. For Asset Servers older than 2.7, a 400 status code (Bad Request) will be returned if this parameter is specified. The default is no filter.. |
 **eventFrameNameFilter** | **string**| The event frame name filter string used for finding objects. The default is no filter.. |
 **eventFrameTemplate** | **string**| Specify that the owner of the returned attributes must have this template or a template derived from this template. The default is no filter.. |
 **referencedElementNameFilter** | **string**| The name query string which must match the name of a referenced element. The default is no filter.. |
 **searchMode** | **string**| Determines how the startTime and endTime parameters are treated when searching for event frames.     The default is 'Overlapped'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **startTime** | **string**| A string representing the earliest starting time for the event frames to be matched. startTime must be less than or equal to the endTime. The default is '*-8h'.. |


### Return type

[**PIItemsAttribute**](../Model/PIItemsAttribute.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetEventFramesWithHttpInfo**
> GetEventFramesWithHttpInfo(string webId, bool canBeAcknowledged, bool isAcknowledged, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string endTime = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, string searchMode = null, string selectedFields = null, string severities = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null)

Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame to use as the root of the search.. |
 **canBeAcknowledged** | **bool**| Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.. |
 **isAcknowledged** | **bool**| Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **categoryName** | **string**| Specify that returned event frames must have this category. The default is no category filter.. |
 **endTime** | **string**| The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.. |
 **nameFilter** | **string**| The name query string used for finding event frames. The default is no filter.. |
 **referencedElementNameFilter** | **string**| The name query string which must match the name of a referenced element. The default is no filter.. |
 **referencedElementTemplateName** | **string**| Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.. |
 **searchMode** | **string**| Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **severities** | **string**| Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.. |
 **startTime** | **string**| The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.. |
 **templateName** | **string**| Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.. |


### Return type

[**ApiResponsePIItemsEventFrame**](../Responses/ApiResponsePIItemsEventFrame.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetEventFrames**
> GetEventFrames(string webId, bool canBeAcknowledged, bool isAcknowledged, int maxCount, bool searchFullHierarchy, int startIndex, string categoryName = null, string endTime = null, string nameFilter = null, string referencedElementNameFilter = null, string referencedElementTemplateName = null, string searchMode = null, string selectedFields = null, string severities = null, string sortField = null, string sortOrder = null, string startTime = null, string templateName = null)

Retrieve event frames based on the specified conditions. By default, returns all children of the specified root event frame with a start time in the past 8 hours.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame to use as the root of the search.. |
 **canBeAcknowledged** | **bool**| Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.. |
 **isAcknowledged** | **bool**| Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **categoryName** | **string**| Specify that returned event frames must have this category. The default is no category filter.. |
 **endTime** | **string**| The ending time for the search. The endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*' if searchMode is not one of the 'Backward*' or 'Forward*' values.. |
 **nameFilter** | **string**| The name query string used for finding event frames. The default is no filter.. |
 **referencedElementNameFilter** | **string**| The name query string which must match the name of a referenced element. The default is no filter.. |
 **referencedElementTemplateName** | **string**| Specify that returned event frames must have an element in the event frame's referenced elements collection that derives from the template. Specify this parameter by name.. |
 **searchMode** | **string**| Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. If this parameter is one of the 'Backward*' or 'Forward*' values, none of endTime, sortField, or sortOrder may be specified. The default is 'Overlapped'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **severities** | **string**| Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name' if searchMode is not one of the 'Backward*' or 'Forward*' values.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending' if searchMode is not one of the 'Backward*' or 'Forward*' values.. |
 **startTime** | **string**| The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.. |
 **templateName** | **string**| Specify that returned event frames must have this template or a template derived from this template. The default is no template filter. Specify this parameter by name.. |


### Return type

[**PIItemsEventFrame**](../Model/PIItemsEventFrame.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateEventFrameWithHttpInfo**
> CreateEventFrameWithHttpInfo(string webId, PIEventFrame eventFrame)

Create an event frame as a child of the specified event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent event frame on which to create the event frame.. |
 **eventFrame** | **PIEventFrame**| The new event frame definition.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateEventFrame**
> CreateEventFrame(string webId, PIEventFrame eventFrame)

Create an event frame as a child of the specified event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent event frame on which to create the event frame.. |
 **eventFrame** | **PIEventFrame**| The new event frame definition.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetReferencedElementsWithHttpInfo**
> GetReferencedElementsWithHttpInfo(string webId, string selectedFields = null)

Retrieve the event frame's referenced elements.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame whose referenced elements should be retrieved.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsElement**](../Responses/ApiResponsePIItemsElement.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetReferencedElements**
> GetReferencedElements(string webId, string selectedFields = null)

Retrieve the event frame's referenced elements.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame whose referenced elements should be retrieved.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsElement**](../Model/PIItemsElement.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSecurityWithHttpInfo**
> GetSecurityWithHttpInfo(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)

Get the security information of the specified security item associated with the event frame for a specified user.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame for the security to be checked.. |
 **userIdentities** | **string**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. |
 **forceRefresh** | **bool**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsSecurityRights**](../Responses/ApiResponsePIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSecurity**
> GetSecurity(string webId, string userIdentities, bool forceRefresh, string selectedFields = null)

Get the security information of the specified security item associated with the event frame for a specified user.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame for the security to be checked.. |
 **userIdentities** | **string**| The user identity for the security information to be checked. Multiple security identities may be specified with multiple instances of the parameter. If the parameter is not specified, only the current user's security rights will be returned.. |
 **forceRefresh** | **bool**| Indicates if the security cache should be refreshed before getting security information. The default is 'false'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsSecurityRights**](../Model/PIItemsSecurityRights.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSecurityEntriesWithHttpInfo**
> GetSecurityEntriesWithHttpInfo(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsSecurityEntry**](../Responses/ApiResponsePIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSecurityEntries**
> GetSecurityEntries(string webId, string nameFilter = null, string selectedFields = null)

Retrieve the security entries associated with the event frame based on the specified criteria. By default, all security entries for this event frame are returned.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame.. |
 **nameFilter** | **string**| The name query string used for filtering security entries. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsSecurityEntry**](../Model/PIItemsSecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateSecurityEntryWithHttpInfo**
> CreateSecurityEntryWithHttpInfo(string webId, PISecurityEntry securityEntry, bool applyToChildren)

Create a security entry owned by the event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame where the security entry will be created.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateSecurityEntry**
> CreateSecurityEntry(string webId, PISecurityEntry securityEntry, bool applyToChildren)

Create a security entry owned by the event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the event frame where the security entry will be created.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSecurityEntryByNameWithHttpInfo**
> GetSecurityEntryByNameWithHttpInfo(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the event frame with the specified name.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the event frame.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePISecurityEntry**](../Responses/ApiResponsePISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSecurityEntryByName**
> GetSecurityEntryByName(string name, string webId, string selectedFields = null)

Retrieve the security entry associated with the event frame with the specified name.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the event frame.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PISecurityEntry**](../Model/PISecurityEntry.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateSecurityEntryWithHttpInfo**
> UpdateSecurityEntryWithHttpInfo(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)

Update a security entry owned by the event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. |
 **webId** | **string**| The ID of the event frame where the security entry will be updated.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateSecurityEntry**
> UpdateSecurityEntry(string name, string webId, PISecurityEntry securityEntry, bool applyToChildren)

Update a security entry owned by the event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry.. |
 **webId** | **string**| The ID of the event frame where the security entry will be updated.. |
 **securityEntry** | **PISecurityEntry**| The new security entry definition. The full list of allow and deny rights must be supplied or they will be removed.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **DeleteSecurityEntryWithHttpInfo**
> DeleteSecurityEntryWithHttpInfo(string name, string webId, bool applyToChildren)

Delete a security entry owned by the event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the event frame where the security entry will be deleted.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **DeleteSecurityEntry**
> DeleteSecurityEntry(string name, string webId, bool applyToChildren)

Delete a security entry owned by the event frame.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **name** | **string**| The name of the security entry. For every backslash character (\) in the security entry name, replace with asterisk (*). As an example, use domain*username instead of domain\username.. |
 **webId** | **string**| The ID of the event frame where the security entry will be deleted.. |
 **applyToChildren** | **bool**| If false, the new access permissions are only applied to the associated object. If true, the access permissions of children with any parent-child reference types will change when the permissions on the primary parent change.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetMultipleWithHttpInfo**
> GetMultipleWithHttpInfo(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null)

Retrieve multiple event frames by web ids or paths.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **asParallel** | **bool**| Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.. |
 **includeMode** | **string**| The include mode for the return list. The default is 'All'.. |
 **paths** | **string**| The path of an event frame. Multiple event frames may be specified with multiple instances of the parameter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **webIds** | **string**| The ID of an event frame. Multiple event frames may be specified with multiple instances of the parameter.. |


### Return type

[**ApiResponsePIItemsItemEventFrame**](../Responses/ApiResponsePIItemsItemEventFrame.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetMultiple**
> GetMultiple(bool asParallel, string includeMode = null, string paths = null, string selectedFields = null, string webIds = null)

Retrieve multiple event frames by web ids or paths.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **asParallel** | **bool**| Specifies if the retrieval processes should be run in parallel on the server. This may improve the response time for large amounts of requested attributes. The default is 'false'.. |
 **includeMode** | **string**| The include mode for the return list. The default is 'All'.. |
 **paths** | **string**| The path of an event frame. Multiple event frames may be specified with multiple instances of the parameter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **webIds** | **string**| The ID of an event frame. Multiple event frames may be specified with multiple instances of the parameter.. |


### Return type

[**PIItemsItemEventFrame**](../Model/PIItemsItemEventFrame.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateSearchByAttributeWithHttpInfo**
> CreateSearchByAttributeWithHttpInfo()

Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CreateSearchByAttribute**
> CreateSearchByAttribute()

Create a link for a "Search EventFrames By Attribute Value" operation, whose queries are specified in the request content. The SearchRoot is specified by the Web Id of the root EventFrame. If the SearchRoot is not specified, then the search starts at the Asset Database. ElementTemplate must be provided as the Web ID of the ElementTemplate, which are used to create the EventFrames. All the attributes in the queries must be defined as AttributeTemplates on the ElementTemplate. An array of attribute value queries are ANDed together to find the desired Element objects. At least one value query must be specified. There are limitations on SearchOperators.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **ExecuteSearchByAttributeWithHttpInfo**
> ExecuteSearchByAttributeWithHttpInfo(string searchId, bool canBeAcknowledged, bool isAcknowledged, int maxCount, bool searchFullHierarchy, int startIndex, string endTime = null, string nameFilter = null, string referencedElementNameFilter = null, string searchMode = null, string selectedFields = null, string severities = null, string sortField = null, string sortOrder = null, string startTime = null)

Execute a "Search EventFrames By Attribute Value" operation.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **searchId** | **string**| The encoded search Id of the "Search EventFrames By Attribute Value" operation.. |
 **canBeAcknowledged** | **bool**| Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.. |
 **isAcknowledged** | **bool**| Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **endTime** | **string**| The ending time for the search. endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*'.. |
 **nameFilter** | **string**| The name query string used for finding event frames. The default is no filter.. |
 **referencedElementNameFilter** | **string**| The name query string which must match the name of a referenced element. The default is no filter.. |
 **searchMode** | **string**| Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. The default is 'Overlapped'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **severities** | **string**| Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **startTime** | **string**| The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.. |


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **ExecuteSearchByAttribute**
> ExecuteSearchByAttribute(string searchId, bool canBeAcknowledged, bool isAcknowledged, int maxCount, bool searchFullHierarchy, int startIndex, string endTime = null, string nameFilter = null, string referencedElementNameFilter = null, string searchMode = null, string selectedFields = null, string severities = null, string sortField = null, string sortOrder = null, string startTime = null)

Execute a "Search EventFrames By Attribute Value" operation.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **searchId** | **string**| The encoded search Id of the "Search EventFrames By Attribute Value" operation.. |
 **canBeAcknowledged** | **bool**| Specify the returned event frames' canBeAcknowledged property. The default is no canBeAcknowledged filter.. |
 **isAcknowledged** | **bool**| Specify the returned event frames' isAcknowledged property. The default no isAcknowledged filter.. |
 **maxCount** | **int**| The maximum number of objects to be returned per call (page size). The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies whether the search should include objects nested further than the immediate children of the search root. The default is 'false'.. |
 **startIndex** | **int**| The starting index (zero based) of the items to be returned. The default is 0.. |
 **endTime** | **string**| The ending time for the search. endTime must be greater than or equal to the startTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*'.. |
 **nameFilter** | **string**| The name query string used for finding event frames. The default is no filter.. |
 **referencedElementNameFilter** | **string**| The name query string which must match the name of a referenced element. The default is no filter.. |
 **searchMode** | **string**| Determines how the startTime and endTime parameters are treated when searching for event frame objects to be included in the returned collection. The default is 'Overlapped'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **severities** | **string**| Specify that returned event frames must have this severity. Multiple severity values may be specified with multiple instances of the parameter. The default is no severity filter.. |
 **sortField** | **string**| The field or property of the object used to sort the returned collection. The default is 'Name'.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **startTime** | **string**| The starting time for the search. startTime must be less than or equal to the endTime. The searchMode parameter will control whether the comparison will be performed against the event frame's startTime or endTime. The default is '*-8h'.. |


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)
