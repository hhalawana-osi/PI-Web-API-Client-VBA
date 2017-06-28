# PIStreamValues

## Properties
Name | Type | Notes
------------ | ------------- | -------------
**WebId** | **string**
**Name** | **string**
**Path** | **string**
**Items** | **[**PITimedValue[]**](../Model/PITimedValue.md)**
**UnitsAbbreviation** | **string**
**Links** | **[**object**](../Model/Object.md)**

## Methods

# ** SetItem**
> void  SetItem(int i, PITimedValue values)

Set an item of the Items array.

### Parameters

Name | Type
------------- | -------------
 **i** | **int**
 **values** | **PITimedValue**

### Return type

void


# ** GetItem**
> PITimedValue  GetItem(int i)

Get item of the Items array.

### Parameters

Name | Type
------------- | -------------
 **i** | **int**

### Return type

PITimedValue


# ** GetItemsLength**
> int  GetItemsLength()

Get the length of the Items array.


### Return type

int


# **CreateItemsArray**
> void CreateItemsArray(int i)

Create an array on the Items property.

### Parameters

Name | Type
------------- | -------------
 **i** | **int**

### Return type

void

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)
