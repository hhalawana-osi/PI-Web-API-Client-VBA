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
	[Guid("9221CED5-A08F-4D2B-BA9B-6BB27F5065ED")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsStreamValue
	{
		[DispId(1)]
		PIItemsStreamValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("3463C21B-9FFF-453F-A155-08EC9626469F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsStreamValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsStreamValue")]
	public class ApiResponsePIItemsStreamValue : ApiParentResponse, IApiResponsePIItemsStreamValue
	{
		public PIItemsStreamValue Data { get; set; }
		public ApiResponsePIItemsStreamValue(int statusCode, IDictionary<string, string> headers, PIItemsStreamValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
