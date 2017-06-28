# SystemApi

Method | HTTP request | Description
------------ | ------------- | -------------
[**Landing**](SystemApi.md#landing) | **GET** /system | Get system links for this PI System Web API instance.
[**LandingWithHttpInfo**](SystemApi.md#landingwithhttpinfo) | **GET** /system | Get system links for this PI System Web API instance.
[**CacheInstances**](SystemApi.md#cacheinstances) | **GET** /system/cacheinstances | Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
[**CacheInstancesWithHttpInfo**](SystemApi.md#cacheinstanceswithhttpinfo) | **GET** /system/cacheinstances | Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.
[**Status**](SystemApi.md#status) | **GET** /system/status | Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.
[**StatusWithHttpInfo**](SystemApi.md#statuswithhttpinfo) | **GET** /system/status | Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.
[**UserInfo**](SystemApi.md#userinfo) | **GET** /system/userinfo | Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
[**UserInfoWithHttpInfo**](SystemApi.md#userinfowithhttpinfo) | **GET** /system/userinfo | Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.
[**Versions**](SystemApi.md#versions) | **GET** /system/versions | Get the current versions of the PI Web API instance and all external plugins.
[**VersionsWithHttpInfo**](SystemApi.md#versionswithhttpinfo) | **GET** /system/versions | Get the current versions of the PI Web API instance and all external plugins.


# **LandingWithHttpInfo**
> LandingWithHttpInfo()

Get system links for this PI System Web API instance.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------


### Return type

[**ApiResponsePISystemLanding**](../Responses/ApiResponsePISystemLanding.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Landing**
> Landing()

Get system links for this PI System Web API instance.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------


### Return type

[**PISystemLanding**](../Model/PISystemLanding.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CacheInstancesWithHttpInfo**
> CacheInstancesWithHttpInfo()

Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------


### Return type

[**ApiResponsePIItemsCacheInstance**](../Responses/ApiResponsePIItemsCacheInstance.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **CacheInstances**
> CacheInstances()

Get AF cache instances currently in use by the system. These are caches from which user requests are serviced. The number of instances depends on the number of users connected to the service, the service's authentication method, and the cache instance configuration.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------


### Return type

[**PIItemsCacheInstance**](../Model/PIItemsCacheInstance.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **StatusWithHttpInfo**
> StatusWithHttpInfo()

Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------


### Return type

[**ApiResponsePISystemStatus**](../Responses/ApiResponsePISystemStatus.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Status**
> Status()

Get the system uptime, the system state and the number of cache instances for this PI System Web API instance.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------


### Return type

[**PISystemStatus**](../Model/PISystemStatus.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UserInfoWithHttpInfo**
> UserInfoWithHttpInfo()

Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------


### Return type

[**ApiResponsePIUserInfo**](../Responses/ApiResponsePIUserInfo.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **UserInfo**
> UserInfo()

Get information about the Windows identity used to fulfill the request. This depends on the service's authentication method and the credentials passed by the client. The impersonation level of the Windows identity is included.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------


### Return type

[**PIUserInfo**](../Model/PIUserInfo.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **VersionsWithHttpInfo**
> VersionsWithHttpInfo()

Get the current versions of the PI Web API instance and all external plugins.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------


### Return type

[**ApiResponseObject**](../Responses/ApiResponseObject.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)

# **Versions**
> Versions()

Get the current versions of the PI Web API instance and all external plugins.

### Parameters

Name | Type | Description | Notes
------------ - | ------------- | ------------- | -------------


### Return type

[**Object**](../Model/Object.md)

[[Back to top]](#) [[Back to API list]](../../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../../README.md#documentation-for-models) [[Back to README]](../../../README.md)
