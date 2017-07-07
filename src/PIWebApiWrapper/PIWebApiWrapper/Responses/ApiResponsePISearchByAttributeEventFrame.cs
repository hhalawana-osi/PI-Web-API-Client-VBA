// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;
using PIWebAPIWrapper.Model;

namespace PIWebAPIWrapper.Responses
{
	[Guid("6F218E0E-641F-4F20-A7D6-87558A39153D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISearchByAttributeEventFrame
	{
		[DispId(1)]
		PISearchByAttributeEventFrame Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("C2C9B37E-756B-45CB-B5E4-1D6F5BB5E27D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISearchByAttributeEventFrame))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISearchByAttributeEventFrame")]
	public class ApiResponsePISearchByAttributeEventFrame : ApiParentResponse, IApiResponsePISearchByAttributeEventFrame
	{
		public PISearchByAttributeEventFrame Data { get; set; }
		public ApiResponsePISearchByAttributeEventFrame(int statusCode, IDictionary<string, string> headers, PISearchByAttributeEventFrame data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
