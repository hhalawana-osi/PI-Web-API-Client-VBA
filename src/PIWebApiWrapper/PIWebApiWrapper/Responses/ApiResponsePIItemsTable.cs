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
	[Guid("54C7F79D-F76C-4F5A-869F-3AF752D3A1BF")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsTable
	{
		[DispId(1)]
		PIItemsTable Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("EE05BE2A-7E73-4815-A96C-D1F6032B885D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsTable))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsTable")]
	public class ApiResponsePIItemsTable : ApiParentResponse, IApiResponsePIItemsTable
	{
		public PIItemsTable Data { get; set; }
		public ApiResponsePIItemsTable(int statusCode, IDictionary<string, string> headers, PIItemsTable data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
