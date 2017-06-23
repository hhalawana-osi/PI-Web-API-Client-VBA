PI Web API Wrapper for VBA
===

## Organization
This repository has the source code package of the PI Web API Wrapper for VBA.

## Requirements

 - PI Web API 2017 installed within your domain using Kerberos or Basic Authentication.
 - PI ProcessBook 2012 SP1+
 - .NET Framework 3.5  


## Installation

 - Download this source code
 - Create a new folder under %PIHOME% named WebAPIWrapper 
 - Copy all files from the dist folder to %PIHOME%\WebAPIWrapper 
 - Run as Administrator the reg.bat located on %PIHOME%\WebAPIWrapper in order to register the PIWebApiWrapper assmebly.


```vb#  
Protected Overrides Function GetAutomationObject() As Object  
    Return New DocumentUtilities()  
End Function  
``` 



## Examples

Please refer to the following examples to understand how to use this library: 


### Create an intance of the piwebapi top level object.

```vb# 
Dim client As New PIWebApiClient
Dim connectedToPIWebAPI As Boolean
connectedToPIWebAPI = client.DefineProperties("https://marc-web-sql.marc.net/piwebapi", True)
``` 

If you want to use basic authentication instead of Kerberos, set useKerberos to False and set the username and password accordingly.


### Get the PI Data Archive WebId

```vb# 
    Set dataServer = client.dataServer.GetByName(tbPIDataArchiveName.Text)
```


### Get PI Points WebIds

```vb# 
    Set point1 = client.point.GetByPath("\\" + tbPIDataArchiveName.Text + "\" + tbTagName1.Text)
    Set point2 = client.point.GetByPath("\\" + tbPIDataArchiveName.Text + "\" + tbTagName2.Text)
    Set point3 = client.point.GetByPath("\\" + tbPIDataArchiveName.Text + "\" + tbTagName3.Text)
```

### Get recorded values in bulk using the StreamSet/GetRecordedAdHoc

```vb# 
    webIds = point1.webId + "," + point2.webId + "," + point3.webId
    Set compressedData = client.StreamSet.GetRecordedAdHoc(webIds, True, 1000)
```

### Send values in bulk using the StreamSet/UpdateValuesAdHoc

```vb# 
    Call GetPIPoints
    Dim streamValuesItems As New PIItemsStreamValues
    Dim streamValue1 As New PIStreamValues
    Dim streamValue2 As New PIStreamValues
    Dim streamValue3 As New PIStreamValues
    Dim value1 As New PITimedValue
    Dim value2 As New PITimedValue
    Dim value3 As New PITimedValue
    Dim value4 As New PITimedValue
    Dim value5 As New PITimedValue
    Dim value6 As New PITimedValue

    streamValuesItems.CreateItemsArray (3)
    value1.SetValueWithInt (2)
    value1.Timestamp = "*-1d"
    value2.SetValueWithInt (3)
    value2.Timestamp = "*-2d"
    value3.SetValueWithInt (4)
    value3.Timestamp = "*-1d"
    value4.SetValueWithInt (5)
    value4.Timestamp = "*-2d"
    value5.SetValueWithInt (6)
    value5.Timestamp = "*-1d"
    value6.SetValueWithInt (7)
    value6.Timestamp = "*-2d"

    streamValue1.webId = point1.webId
    streamValue1.CreateItemsArray (2)
    Call streamValue1.SetItem(0, value1)
    Call streamValue1.SetItem(1, value2)
    Call streamValuesItems.SetItem(0, streamValue1)

    streamValue2.webId = point2.webId
    streamValue2.CreateItemsArray (2)
    Call streamValue2.SetItem(0, value3)
    Call streamValue2.SetItem(1, value4)
    Call streamValuesItems.SetItem(1, streamValue2)

    streamValue3.webId = point2.webId
    streamValue3.CreateItemsArray (2)
    Call streamValue3.SetItem(0, value5)
    Call streamValue3.SetItem(1, value6)
    Call streamValuesItems.SetItem(2, streamValue3)

    Dim response As ApiResponsePIItemsItemsSubstatus
    Set response = client.StreamSet.UpdateValuesAdHocWithHttpInfo(streamValuesItems)
```


### Get AF Attribute given an AF Element path

```vb# 
    Set elem = client.element.GetByPath(ERD.CurrentContext(ThisDisplay))
    ElemDesc.Contents = elem.Description
    Dim attributes As PIItemsAttribute
    Set attributes = client.element.GetAttributes(elem.webId, 1000, False, False, False, 0)
```


### Get current value given an AF Attribute path

```vb# 
    attributePath = ERD.CurrentContext(ThisDisplay) + "|" + AttrList.Text
    Set attr = client.attribute.GetByPath(attributePath)
    Set timedValue = client.Stream.GetEnd(attr.webId)
    AttrValue.Contents = timedValue.value
```

### Get Event Frames given an AF database path

```vb# 
  Set db = client.AssetData.GetByPath(dbPath)
  Set efs = client.AssetData.GetEventFrames(db.webId, False, False, 100, True, 0, "", "*", "", elem.Name, elem.templateName, "", "", "None", "", "", "*-900", "*")
```


## Licensing
Copyright 2017 OSIsoft, LLC.

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
   
Please see the file named [LICENSE.md](LICENSE.md).
