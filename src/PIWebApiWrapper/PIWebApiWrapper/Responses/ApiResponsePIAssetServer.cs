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
	[Guid("D77EBDB1-5721-475F-B0D4-D3158AAD5ED3")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAssetServer
	{
		[DispId(1)]
		PIAssetServer Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1CB06CFC-7319-49F2-B964-51722321F3F9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAssetServer))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAssetServer")]
	public class ApiResponsePIAssetServer : ApiParentResponse, IApiResponsePIAssetServer
	{
		public PIAssetServer Data { get; set; }
		public ApiResponsePIAssetServer(int statusCode, IDictionary<string, string> headers, PIAssetServer data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
