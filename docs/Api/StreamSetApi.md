# StreamSetApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**GetChannel**](StreamSetApi.md#getchannel) | **GET** /streamsets/{webId}/channel | Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
[**GetChannelWithHttpInfo**](StreamSetApi.md#getchannelwithhttpinfo) | **GET** /streamsets/{webId}/channel | Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.
[**GetEnd**](StreamSetApi.md#getend) | **GET** /streamsets/{webId}/end | Returns End of stream values of the attributes for an Element, Event Frame or Attribute
[**GetEndWithHttpInfo**](StreamSetApi.md#getendwithhttpinfo) | **GET** /streamsets/{webId}/end | Returns End of stream values of the attributes for an Element, Event Frame or Attribute
[**GetInterpolated**](StreamSetApi.md#getinterpolated) | **GET** /streamsets/{webId}/interpolated | Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
[**GetInterpolatedWithHttpInfo**](StreamSetApi.md#getinterpolatedwithhttpinfo) | **GET** /streamsets/{webId}/interpolated | Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.
[**GetInterpolatedAtTimes**](StreamSetApi.md#getinterpolatedattimes) | **GET** /streamsets/{webId}/interpolatedattimes | Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
[**GetInterpolatedAtTimesWithHttpInfo**](StreamSetApi.md#getinterpolatedattimeswithhttpinfo) | **GET** /streamsets/{webId}/interpolatedattimes | Returns interpolated values of attributes for an element, event frame or attribute at the specified times.
[**GetPlot**](StreamSetApi.md#getplot) | **GET** /streamsets/{webId}/plot | Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
[**GetPlotWithHttpInfo**](StreamSetApi.md#getplotwithhttpinfo) | **GET** /streamsets/{webId}/plot | Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
[**GetRecorded**](StreamSetApi.md#getrecorded) | **GET** /streamsets/{webId}/recorded | Returns recorded values of the attributes for an element, event frame, or attribute.
[**GetRecordedWithHttpInfo**](StreamSetApi.md#getrecordedwithhttpinfo) | **GET** /streamsets/{webId}/recorded | Returns recorded values of the attributes for an element, event frame, or attribute.
[**UpdateValues**](StreamSetApi.md#updatevalues) | **POST** /streamsets/{webId}/recorded | Updates multiple values for the specified streams.
[**UpdateValuesWithHttpInfo**](StreamSetApi.md#updatevalueswithhttpinfo) | **POST** /streamsets/{webId}/recorded | Updates multiple values for the specified streams.
[**GetRecordedAtTime**](StreamSetApi.md#getrecordedattime) | **GET** /streamsets/{webId}/recordedattime | Returns recorded values of the attributes for an element, event frame, or attribute.
[**GetRecordedAtTimeWithHttpInfo**](StreamSetApi.md#getrecordedattimewithhttpinfo) | **GET** /streamsets/{webId}/recordedattime | Returns recorded values of the attributes for an element, event frame, or attribute.
[**GetRecordedAtTimes**](StreamSetApi.md#getrecordedattimes) | **GET** /streamsets/{webId}/recordedattimes | Returns recorded values of attributes for an element, event frame or attribute at the specified times.
[**GetRecordedAtTimesWithHttpInfo**](StreamSetApi.md#getrecordedattimeswithhttpinfo) | **GET** /streamsets/{webId}/recordedattimes | Returns recorded values of attributes for an element, event frame or attribute at the specified times.
[**GetSummaries**](StreamSetApi.md#getsummaries) | **GET** /streamsets/{webId}/summary | Returns summary values of the attributes for an element, event frame or attribute.
[**GetSummariesWithHttpInfo**](StreamSetApi.md#getsummarieswithhttpinfo) | **GET** /streamsets/{webId}/summary | Returns summary values of the attributes for an element, event frame or attribute.
[**GetValues**](StreamSetApi.md#getvalues) | **GET** /streamsets/{webId}/value | Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
[**GetValuesWithHttpInfo**](StreamSetApi.md#getvalueswithhttpinfo) | **GET** /streamsets/{webId}/value | Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.
[**UpdateValue**](StreamSetApi.md#updatevalue) | **POST** /streamsets/{webId}/value | Updates a single value for the specified streams.
[**UpdateValueWithHttpInfo**](StreamSetApi.md#updatevaluewithhttpinfo) | **POST** /streamsets/{webId}/value | Updates a single value for the specified streams.
[**GetChannelAdHoc**](StreamSetApi.md#getchanneladhoc) | **GET** /streamsets/channel | Opens a channel that will send messages about any value changes for the specified streams.
[**GetChannelAdHocWithHttpInfo**](StreamSetApi.md#getchanneladhocwithhttpinfo) | **GET** /streamsets/channel | Opens a channel that will send messages about any value changes for the specified streams.
[**GetEndAdHoc**](StreamSetApi.md#getendadhoc) | **GET** /streamsets/end | Returns End Of Stream values for attributes of the specified streams
[**GetEndAdHocWithHttpInfo**](StreamSetApi.md#getendadhocwithhttpinfo) | **GET** /streamsets/end | Returns End Of Stream values for attributes of the specified streams
[**GetInterpolatedAdHoc**](StreamSetApi.md#getinterpolatedadhoc) | **GET** /streamsets/interpolated | Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
[**GetInterpolatedAdHocWithHttpInfo**](StreamSetApi.md#getinterpolatedadhocwithhttpinfo) | **GET** /streamsets/interpolated | Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.
[**GetInterpolatedAtTimesAdHoc**](StreamSetApi.md#getinterpolatedattimesadhoc) | **GET** /streamsets/interpolatedattimes | Returns interpolated values of the specified streams at the specified times.
[**GetInterpolatedAtTimesAdHocWithHttpInfo**](StreamSetApi.md#getinterpolatedattimesadhocwithhttpinfo) | **GET** /streamsets/interpolatedattimes | Returns interpolated values of the specified streams at the specified times.
[**GetPlotAdHoc**](StreamSetApi.md#getplotadhoc) | **GET** /streamsets/plot | Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
[**GetPlotAdHocWithHttpInfo**](StreamSetApi.md#getplotadhocwithhttpinfo) | **GET** /streamsets/plot | Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).
[**GetRecordedAdHoc**](StreamSetApi.md#getrecordedadhoc) | **GET** /streamsets/recorded | Returns recorded values of the specified streams.
[**GetRecordedAdHocWithHttpInfo**](StreamSetApi.md#getrecordedadhocwithhttpinfo) | **GET** /streamsets/recorded | Returns recorded values of the specified streams.
[**UpdateValuesAdHoc**](StreamSetApi.md#updatevaluesadhoc) | **POST** /streamsets/recorded | Updates multiple values for the specified streams.
[**UpdateValuesAdHocWithHttpInfo**](StreamSetApi.md#updatevaluesadhocwithhttpinfo) | **POST** /streamsets/recorded | Updates multiple values for the specified streams.
[**GetRecordedAtTimeAdHoc**](StreamSetApi.md#getrecordedattimeadhoc) | **GET** /streamsets/recordedattime | Returns recorded values based on the passed time and retrieval mode.
[**GetRecordedAtTimeAdHocWithHttpInfo**](StreamSetApi.md#getrecordedattimeadhocwithhttpinfo) | **GET** /streamsets/recordedattime | Returns recorded values based on the passed time and retrieval mode.
[**GetRecordedAtTimesAdHoc**](StreamSetApi.md#getrecordedattimesadhoc) | **GET** /streamsets/recordedattimes | Returns recorded values of the specified streams at the specified times.
[**GetRecordedAtTimesAdHocWithHttpInfo**](StreamSetApi.md#getrecordedattimesadhocwithhttpinfo) | **GET** /streamsets/recordedattimes | Returns recorded values of the specified streams at the specified times.
[**GetSummariesAdHoc**](StreamSetApi.md#getsummariesadhoc) | **GET** /streamsets/summary | Returns summary values of the specified streams.
[**GetSummariesAdHocWithHttpInfo**](StreamSetApi.md#getsummariesadhocwithhttpinfo) | **GET** /streamsets/summary | Returns summary values of the specified streams.
[**GetValuesAdHoc**](StreamSetApi.md#getvaluesadhoc) | **GET** /streamsets/value | Returns values of the specified streams.
[**GetValuesAdHocWithHttpInfo**](StreamSetApi.md#getvaluesadhocwithhttpinfo) | **GET** /streamsets/value | Returns values of the specified streams.
[**UpdateValueAdHoc**](StreamSetApi.md#updatevalueadhoc) | **POST** /streamsets/value | Updates a single value for the specified streams.
[**UpdateValueAdHocWithHttpInfo**](StreamSetApi.md#updatevalueadhocwithhttpinfo) | **POST** /streamsets/value | Updates a single value for the specified streams.


# **GetChannelWithHttpInfo**
> GetChannelWithHttpInfo(string webId, bool includeInitialValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string templateName = null)

Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.. |
 **includeInitialValues** | **bool**| Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |


### Return type

[**ApiResponsePIItemsStreamValue**](../Responses/ApiResponsePIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetChannel**
> GetChannel(string webId, bool includeInitialValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string templateName = null)

Opens a channel that will send messages about any value changes for the attributes of an Element, Event Frame, or Attribute.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.. |
 **includeInitialValues** | **bool**| Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetEndWithHttpInfo**
> GetEndWithHttpInfo(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string selectedFields = null, string templateName = null)

Returns End of stream values of the attributes for an Element, Event Frame or Attribute

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |


### Return type

[**ApiResponsePIItemsStreamValue**](../Responses/ApiResponsePIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetEnd**
> GetEnd(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string selectedFields = null, string templateName = null)

Returns End of stream values of the attributes for an Element, Event Frame or Attribute

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetInterpolatedWithHttpInfo**
> GetInterpolatedWithHttpInfo(string webId, bool includeFilteredValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string endTime = null, string filterExpression = null, string interval = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null)

Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **includeFilteredValues** | **bool**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. |
 **interval** | **string**| The sampling interval, in AFTimeSpan format.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValues**](../Responses/ApiResponsePIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetInterpolated**
> GetInterpolated(string webId, bool includeFilteredValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string endTime = null, string filterExpression = null, string interval = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null)

Returns interpolated values of attributes for an element, event frame or attribute over the specified time range at the specified sampling interval.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **includeFilteredValues** | **bool**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. |
 **interval** | **string**| The sampling interval, in AFTimeSpan format.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetInterpolatedAtTimesWithHttpInfo**
> GetInterpolatedAtTimesWithHttpInfo(string webId, string times, bool includeFilteredValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string filterExpression = null, string nameFilter = null, string selectedFields = null, string sortOrder = null, string templateName = null, string timeZone = null)

Returns interpolated values of attributes for an element, event frame or attribute at the specified times.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **times** | **string**| The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.. |
 **includeFilteredValues** | **bool**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValues**](../Responses/ApiResponsePIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetInterpolatedAtTimes**
> GetInterpolatedAtTimes(string webId, string times, bool includeFilteredValues, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string filterExpression = null, string nameFilter = null, string selectedFields = null, string sortOrder = null, string templateName = null, string timeZone = null)

Returns interpolated values of attributes for an element, event frame or attribute at the specified times.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **times** | **string**| The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.. |
 **includeFilteredValues** | **bool**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetPlotWithHttpInfo**
> GetPlotWithHttpInfo(string webId, int intervals, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string endTime = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null)

Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **intervals** | **int**| The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValues**](../Responses/ApiResponsePIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetPlot**
> GetPlot(string webId, int intervals, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string endTime = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null)

Returns values of attributes for an element, event frame or attribute over the specified time range suitable for plotting over the number of intervals (typically represents pixels).

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **intervals** | **int**| The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetRecordedWithHttpInfo**
> GetRecordedWithHttpInfo(string webId, bool includeFilteredValues, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null)

Returns recorded values of the attributes for an element, event frame, or attribute.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **includeFilteredValues** | **bool**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. |
 **maxCount** | **int**| The maximum number of values to be returned. The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **boundaryType** | **string**| An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValues**](../Responses/ApiResponsePIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetRecorded**
> GetRecorded(string webId, bool includeFilteredValues, int maxCount, bool searchFullHierarchy, bool showExcluded, bool showHidden, string boundaryType = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string selectedFields = null, string startTime = null, string templateName = null, string timeZone = null)

Returns recorded values of the attributes for an element, event frame, or attribute.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **includeFilteredValues** | **bool**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. |
 **maxCount** | **int**| The maximum number of values to be returned. The default is 1000.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **boundaryType** | **string**| An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateValuesWithHttpInfo**
> UpdateValuesWithHttpInfo(string webId, PIItemsStreamValues values, string bufferOption = null, string updateOption = null)

Updates multiple values for the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.. |
 **values** | **PIItemsStreamValues**| The values to add or update.. |
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. |
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. |


### Return type

[**ApiResponsePIItemsItemsSubstatus**](../Responses/ApiResponsePIItemsItemsSubstatus.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateValues**
> UpdateValues(string webId, PIItemsStreamValues values, string bufferOption = null, string updateOption = null)

Updates multiple values for the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.. |
 **values** | **PIItemsStreamValues**| The values to add or update.. |
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. |
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. |


### Return type

[**PIItemsItemsSubstatus**](../Model/PIItemsItemsSubstatus.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetRecordedAtTimeWithHttpInfo**
> GetRecordedAtTimeWithHttpInfo(string webId, string time, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string retrievalMode = null, string selectedFields = null, string templateName = null, string timeZone = null)

Returns recorded values of the attributes for an element, event frame, or attribute.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **time** | **string**| The timestamp at which the values are desired.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **retrievalMode** | **string**| An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValues**](../Responses/ApiResponsePIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetRecordedAtTime**
> GetRecordedAtTime(string webId, string time, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string retrievalMode = null, string selectedFields = null, string templateName = null, string timeZone = null)

Returns recorded values of the attributes for an element, event frame, or attribute.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **time** | **string**| The timestamp at which the values are desired.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **retrievalMode** | **string**| An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetRecordedAtTimesWithHttpInfo**
> GetRecordedAtTimesWithHttpInfo(string webId, string times, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string templateName = null, string timeZone = null)

Returns recorded values of attributes for an element, event frame or attribute at the specified times.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **times** | **string**| The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **retrievalMode** | **string**| An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValues**](../Responses/ApiResponsePIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetRecordedAtTimes**
> GetRecordedAtTimes(string webId, string times, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string templateName = null, string timeZone = null)

Returns recorded values of attributes for an element, event frame or attribute at the specified times.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **times** | **string**| The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **retrievalMode** | **string**| An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSummariesWithHttpInfo**
> GetSummariesWithHttpInfo(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string templateName = null, string timeType = null, string timeZone = null)

Returns summary values of the attributes for an element, event frame or attribute.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **calculationBasis** | **string**| Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **filterExpression** | **string**| A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **sampleInterval** | **string**| A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.. |
 **sampleType** | **string**| A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. |
 **summaryDuration** | **string**| The duration of each summary interval.. |
 **summaryTypes** | **string**| Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeType** | **string**| Specifies how to calculate the timestamp for each interval. The default is 'Auto'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamSummaries**](../Responses/ApiResponsePIItemsStreamSummaries.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSummaries**
> GetSummaries(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string calculationBasis = null, string categoryName = null, string endTime = null, string filterExpression = null, string nameFilter = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string templateName = null, string timeType = null, string timeZone = null)

Returns summary values of the attributes for an element, event frame or attribute.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an element, event frame or attribute, which is the base element or parent of all the stream attributes.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **calculationBasis** | **string**| Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **endTime** | **string**| An optional end time. The default is '*' for element attributes and points. For event frame attributes, the default is the event frame's end time, or '*' if that is not set. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **filterExpression** | **string**| A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **sampleInterval** | **string**| A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.. |
 **sampleType** | **string**| A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d' for element attributes and points. For event frame attributes, the default is the event frame's start time, or '*-1d' if that is not set.. |
 **summaryDuration** | **string**| The duration of each summary interval.. |
 **summaryTypes** | **string**| Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **timeType** | **string**| Specifies how to calculate the timestamp for each interval. The default is 'Auto'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamSummaries**](../Model/PIItemsStreamSummaries.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetValuesWithHttpInfo**
> GetValuesWithHttpInfo(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string selectedFields = null, string templateName = null, string time = null, string timeZone = null)

Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **time** | **string**| An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValue**](../Responses/ApiResponsePIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetValues**
> GetValues(string webId, bool searchFullHierarchy, bool showExcluded, bool showHidden, string categoryName = null, string nameFilter = null, string selectedFields = null, string templateName = null, string time = null, string timeZone = null)

Returns values of the attributes for an Element, Event Frame or Attribute at the specified time.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of an Element, Event Frame or Attribute, which is the base element or parent of all the stream attributes.. |
 **searchFullHierarchy** | **bool**| Specifies if the search should include attributes nested further than the immediate attributes of the searchRoot. The default is 'false'.. |
 **showExcluded** | **bool**| Specified if the search should include attributes with the Excluded property set. The default is 'false'.. |
 **showHidden** | **bool**| Specified if the search should include attributes with the Hidden property set. The default is 'false'.. |
 **categoryName** | **string**| Specify that included attributes must have this category. The default is no category filter.. |
 **nameFilter** | **string**| The name query string used for filtering attributes. The default is no filter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **templateName** | **string**| Specify that included attributes must be members of this template. The default is no template filter.. |
 **time** | **string**| An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateValueWithHttpInfo**
> UpdateValueWithHttpInfo(string webId, PIItemsStreamValue values, string bufferOption = null, string updateOption = null)

Updates a single value for the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.. |
 **values** | **PIItemsStreamValue**| The values to add or update.. |
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. |
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. |


### Return type

[**ApiResponsePIItemsSubstatus**](../Responses/ApiResponsePIItemsSubstatus.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateValue**
> UpdateValue(string webId, PIItemsStreamValue values, string bufferOption = null, string updateOption = null)

Updates a single value for the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webId** | **string**| The ID of the parent element, event frame, or attribute. Attributes specified in the body must be descendants of the specified object.. |
 **values** | **PIItemsStreamValue**| The values to add or update.. |
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. |
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. |


### Return type

[**PIItemsSubstatus**](../Model/PIItemsSubstatus.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetChannelAdHocWithHttpInfo**
> GetChannelAdHocWithHttpInfo(string webIds, bool includeInitialValues)

Opens a channel that will send messages about any value changes for the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **includeInitialValues** | **bool**| Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.. |


### Return type

[**ApiResponsePIItemsStreamValue**](../Responses/ApiResponsePIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetChannelAdHoc**
> GetChannelAdHoc(string webIds, bool includeInitialValues)

Opens a channel that will send messages about any value changes for the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **includeInitialValues** | **bool**| Specified if the channel should send a message with the current values of all the streams after the connection is opened. The default is 'false'.. |


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetEndAdHocWithHttpInfo**
> GetEndAdHocWithHttpInfo(string webIds, string selectedFields = null)

Returns End Of Stream values for attributes of the specified streams

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**ApiResponsePIItemsStreamValues**](../Responses/ApiResponsePIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetEndAdHoc**
> GetEndAdHoc(string webIds, string selectedFields = null)

Returns End Of Stream values for attributes of the specified streams

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetInterpolatedAdHocWithHttpInfo**
> GetInterpolatedAdHocWithHttpInfo(string webIds, bool includeFilteredValues, string endTime = null, string filterExpression = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null)

Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. |
 **includeFilteredValues** | **bool**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. |
 **endTime** | **string**| An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. |
 **interval** | **string**| The sampling interval, in AFTimeSpan format.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValues**](../Responses/ApiResponsePIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetInterpolatedAdHoc**
> GetInterpolatedAdHoc(string webIds, bool includeFilteredValues, string endTime = null, string filterExpression = null, string interval = null, string selectedFields = null, string startTime = null, string timeZone = null)

Returns interpolated values of the specified streams over the specified time range at the specified sampling interval.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. |
 **includeFilteredValues** | **bool**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. |
 **endTime** | **string**| An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. |
 **interval** | **string**| The sampling interval, in AFTimeSpan format.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetInterpolatedAtTimesAdHocWithHttpInfo**
> GetInterpolatedAtTimesAdHocWithHttpInfo(string times, string webIds, bool includeFilteredValues, string filterExpression = null, string selectedFields = null, string sortOrder = null, string timeZone = null)

Returns interpolated values of the specified streams at the specified times.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **times** | **string**| The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.. |
 **webIds** | **string**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. |
 **includeFilteredValues** | **bool**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. |
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValues**](../Responses/ApiResponsePIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetInterpolatedAtTimesAdHoc**
> GetInterpolatedAtTimesAdHoc(string times, string webIds, bool includeFilteredValues, string filterExpression = null, string selectedFields = null, string sortOrder = null, string timeZone = null)

Returns interpolated values of the specified streams at the specified times.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **times** | **string**| The timestamp at which to retrieve a interpolated value. Multiple timestamps may be specified with multiple instances of the parameter.. |
 **webIds** | **string**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. |
 **includeFilteredValues** | **bool**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. |
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. If the attribute does not support filtering, the filter will be ignored. The default is no filtering.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetPlotAdHocWithHttpInfo**
> GetPlotAdHocWithHttpInfo(string webIds, int intervals, string endTime = null, string selectedFields = null, string startTime = null, string timeZone = null)

Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **intervals** | **int**| The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).. |
 **endTime** | **string**| An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValues**](../Responses/ApiResponsePIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetPlotAdHoc**
> GetPlotAdHoc(string webIds, int intervals, string endTime = null, string selectedFields = null, string startTime = null, string timeZone = null)

Returns values of attributes for the specified streams over the specified time range suitable for plotting over the number of intervals (typically represents pixels).

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **intervals** | **int**| The number of intervals to plot over. Typically, this would be the number of horizontal pixels in the trend. The default is '24'. For each interval, the data available is examined and significant values are returned. Each interval can produce up to 5 values if they are unique, the first value in the interval, the last value, the highest value, the lowest value and at most one exceptional point (bad status or digital state).. |
 **endTime** | **string**| An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetRecordedAdHocWithHttpInfo**
> GetRecordedAdHocWithHttpInfo(string webIds, bool includeFilteredValues, int maxCount, string boundaryType = null, string endTime = null, string filterExpression = null, string selectedFields = null, string startTime = null, string timeZone = null)

Returns recorded values of the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **includeFilteredValues** | **bool**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. |
 **maxCount** | **int**| The maximum number of values to be returned. The default is 1000.. |
 **boundaryType** | **string**| An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.. |
 **endTime** | **string**| An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValues**](../Responses/ApiResponsePIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetRecordedAdHoc**
> GetRecordedAdHoc(string webIds, bool includeFilteredValues, int maxCount, string boundaryType = null, string endTime = null, string filterExpression = null, string selectedFields = null, string startTime = null, string timeZone = null)

Returns recorded values of the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **includeFilteredValues** | **bool**| Specify 'true' to indicate that values which fail the filter criteria are present in the returned data at the times where they occurred with a value set to a 'Filtered' enumeration value with bad status. Repeated consecutive failures are omitted.. |
 **maxCount** | **int**| The maximum number of values to be returned. The default is 1000.. |
 **boundaryType** | **string**| An optional value that determines how the times and values of the returned end points are determined. The default is 'Inside'.. |
 **endTime** | **string**| An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **filterExpression** | **string**| An optional string containing a filter expression. Expression variables are relative to the data point. Use '.' to reference the containing attribute. The default is no filtering.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateValuesAdHocWithHttpInfo**
> UpdateValuesAdHocWithHttpInfo(PIItemsStreamValues values, string bufferOption = null, string updateOption = null)

Updates multiple values for the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **values** | **PIItemsStreamValues**| The values to add or update.. |
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. |
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. |


### Return type

[**ApiResponsePIItemsItemsSubstatus**](../Responses/ApiResponsePIItemsItemsSubstatus.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateValuesAdHoc**
> UpdateValuesAdHoc(PIItemsStreamValues values, string bufferOption = null, string updateOption = null)

Updates multiple values for the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **values** | **PIItemsStreamValues**| The values to add or update.. |
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. |
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. |


### Return type

[**PIItemsItemsSubstatus**](../Model/PIItemsItemsSubstatus.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetRecordedAtTimeAdHocWithHttpInfo**
> GetRecordedAtTimeAdHocWithHttpInfo(string time, string webIds, string retrievalMode = null, string selectedFields = null, string timeZone = null)

Returns recorded values based on the passed time and retrieval mode.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **time** | **string**| The timestamp at which the values are desired.. |
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **retrievalMode** | **string**| An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValue**](../Responses/ApiResponsePIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetRecordedAtTimeAdHoc**
> GetRecordedAtTimeAdHoc(string time, string webIds, string retrievalMode = null, string selectedFields = null, string timeZone = null)

Returns recorded values based on the passed time and retrieval mode.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **time** | **string**| The timestamp at which the values are desired.. |
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **retrievalMode** | **string**| An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetRecordedAtTimesAdHocWithHttpInfo**
> GetRecordedAtTimesAdHocWithHttpInfo(string times, string webIds, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null)

Returns recorded values of the specified streams at the specified times.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **times** | **string**| The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.. |
 **webIds** | **string**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. |
 **retrievalMode** | **string**| An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValues**](../Responses/ApiResponsePIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetRecordedAtTimesAdHoc**
> GetRecordedAtTimesAdHoc(string times, string webIds, string retrievalMode = null, string selectedFields = null, string sortOrder = null, string timeZone = null)

Returns recorded values of the specified streams at the specified times.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **times** | **string**| The timestamp at which to retrieve a recorded value. Multiple timestamps may be specified with multiple instances of the parameter.. |
 **webIds** | **string**| The ID of a stream. Multiple streams may be specified with multiple instances of the parameter.. |
 **retrievalMode** | **string**| An optional value that determines the values to return when values don't exist at the exact time specified. The default is 'Auto'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **sortOrder** | **string**| The order that the returned collection is sorted. The default is 'Ascending'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValues**](../Model/PIItemsStreamValues.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSummariesAdHocWithHttpInfo**
> GetSummariesAdHocWithHttpInfo(string webIds, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string timeZone = null)

Returns summary values of the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **calculationBasis** | **string**| Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.. |
 **endTime** | **string**| An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **filterExpression** | **string**| A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.. |
 **sampleInterval** | **string**| A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.. |
 **sampleType** | **string**| A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d'.. |
 **summaryDuration** | **string**| The duration of each summary interval.. |
 **summaryTypes** | **string**| Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.. |
 **timeType** | **string**| Specifies how to calculate the timestamp for each interval. The default is 'Auto'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamSummaries**](../Responses/ApiResponsePIItemsStreamSummaries.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetSummariesAdHoc**
> GetSummariesAdHoc(string webIds, string calculationBasis = null, string endTime = null, string filterExpression = null, string sampleInterval = null, string sampleType = null, string selectedFields = null, string startTime = null, string summaryDuration = null, string summaryTypes = null, string timeType = null, string timeZone = null)

Returns summary values of the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **calculationBasis** | **string**| Specifies the method of evaluating the data over the time range. The default is 'TimeWeighted'.. |
 **endTime** | **string**| An optional end time. The default is '*'. Note that if endTime is earlier than startTime, the resulting values will be in time-descending order.. |
 **filterExpression** | **string**| A string containing a filter expression. Expression variables are relative to the attribute. Use '.' to reference the containing attribute. The default is no filtering.. |
 **sampleInterval** | **string**| A time span specifies how often the filter expression is evaluated when computing the summary for an interval, if the sampleType is 'Interval'.. |
 **sampleType** | **string**| A flag which specifies one or more summaries to compute for each interval over the time range. The default is 'ExpressionRecordedValues'.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **startTime** | **string**| An optional start time. The default is '*-1d'.. |
 **summaryDuration** | **string**| The duration of each summary interval.. |
 **summaryTypes** | **string**| Specifies the kinds of summaries to produce over the range. The default is 'Total'. Multiple summary types may be specified by using multiple instances of summaryType.. |
 **timeType** | **string**| Specifies how to calculate the timestamp for each interval. The default is 'Auto'.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamSummaries**](../Model/PIItemsStreamSummaries.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetValuesAdHocWithHttpInfo**
> GetValuesAdHocWithHttpInfo(string webIds, string selectedFields = null, string time = null, string timeZone = null)

Returns values of the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **time** | **string**| An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**ApiResponsePIItemsStreamValue**](../Responses/ApiResponsePIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **GetValuesAdHoc**
> GetValuesAdHoc(string webIds, string selectedFields = null, string time = null, string timeZone = null)

Returns values of the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **webIds** | **string**| The ID of a stream.  Multiple streams may be specified with multiple instances of the parameter.. |
 **selectedFields** | **string**| List of fields to be returned in the response, separated by semicolons (;). If this parameter is not specified, all available fields will be returned.. |
 **time** | **string**| An AF time string, which is used as the time context to get stream values if it is provided. By default, it is not specified, and the default time context of the AF object will be used.. |
 **timeZone** | **string**| The time zone in which the time string will be interpreted. This parameter will be ignored if a time zone is specified in the time string. If no time zone is specified in either places, the PI Web API server time zone will be used.. |


### Return type

[**PIItemsStreamValue**](../Model/PIItemsStreamValue.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateValueAdHocWithHttpInfo**
> UpdateValueAdHocWithHttpInfo(PIItemsStreamValues values, string bufferOption = null, string updateOption = null)

Updates a single value for the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **values** | **PIItemsStreamValues**| The values to add or update.. |
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. |
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. |


### Return type

[**ApiResponsePIItemsSubstatus**](../Responses/ApiResponsePIItemsSubstatus.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UpdateValueAdHoc**
> UpdateValueAdHoc(PIItemsStreamValues values, string bufferOption = null, string updateOption = null)

Updates a single value for the specified streams.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------
 **values** | **PIItemsStreamValues**| The values to add or update.. |
 **bufferOption** | **string**| The desired AFBufferOption. The default is 'BufferIfPossible'.. |
 **updateOption** | **string**| The desired AFUpdateOption. The default is 'Replace'.. |


### Return type

[**PIItemsSubstatus**](../Model/PIItemsSubstatus.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)
