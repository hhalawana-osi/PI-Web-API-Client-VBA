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
	[Guid("A59F6E3B-1463-4CE3-8B90-3F7D27A1AF4A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSecurityEntry
	{
		[DispId(1)]
		PIItemsSecurityEntry Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("6C6D67CE-4975-4110-A4EC-10993A094E64")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSecurityEntry))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSecurityEntry")]
	public class ApiResponsePIItemsSecurityEntry : ApiParentResponse, IApiResponsePIItemsSecurityEntry
	{
		public PIItemsSecurityEntry Data { get; set; }
		public ApiResponsePIItemsSecurityEntry(int statusCode, IDictionary<string, string> headers, PIItemsSecurityEntry data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
