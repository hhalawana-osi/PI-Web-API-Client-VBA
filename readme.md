PI Web API Wrapper for VBA
===

## Organization
This repository has the source code package of the PI Web API Wrapper for VBA.

## Requirements

PI Web API 2017 installed within your domain using Kerberos or Basic Authentication.
PI ProcessBook 2012 SP1+
.NET Framework 3.5  


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
