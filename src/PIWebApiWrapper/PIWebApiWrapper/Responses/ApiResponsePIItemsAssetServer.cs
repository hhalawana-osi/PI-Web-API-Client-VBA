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
	[Guid("E9773131-3A44-4B49-A107-23541DB6AB31")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAssetServer
	{
		[DispId(1)]
		PIItemsAssetServer Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("969F3C2C-2F16-49F4-8F93-74FEC3C5849F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAssetServer))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAssetServer")]
	public class ApiResponsePIItemsAssetServer : ApiParentResponse, IApiResponsePIItemsAssetServer
	{
		public PIItemsAssetServer Data { get; set; }
		public ApiResponsePIItemsAssetServer(int statusCode, IDictionary<string, string> headers, PIItemsAssetServer data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
