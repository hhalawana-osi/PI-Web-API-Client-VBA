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
	[Guid("D07C68CC-9532-481A-AA7F-11E9A6B49ED2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsDataServer
	{
		[DispId(1)]
		PIItemsDataServer Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1BFE187C-C525-455F-AC35-904F315AA621")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsDataServer))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsDataServer")]
	public class ApiResponsePIItemsDataServer : ApiParentResponse, IApiResponsePIItemsDataServer
	{
		public PIItemsDataServer Data { get; set; }
		public ApiResponsePIItemsDataServer(int statusCode, IDictionary<string, string> headers, PIItemsDataServer data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
