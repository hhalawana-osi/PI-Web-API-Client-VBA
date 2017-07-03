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
	[Guid("B169DEC1-96EE-441A-9659-193D9797F625")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITable
	{
		[DispId(1)]
		PITable Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("83CB8DF7-0E12-449C-A06B-F5E7A892C3FF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITable))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITable")]
	public class ApiResponsePITable : ApiParentResponse, IApiResponsePITable
	{
		public PITable Data { get; set; }
		public ApiResponsePITable(int statusCode, IDictionary<string, string> headers, PITable data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
