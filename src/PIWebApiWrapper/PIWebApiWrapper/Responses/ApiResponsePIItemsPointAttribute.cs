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
	[Guid("0EBD3B1B-1BA5-4AAE-B520-8C6F102A943C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsPointAttribute
	{
		[DispId(1)]
		PIItemsPointAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("7C46E0E0-96F5-4637-9E91-CECB25D83D7D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsPointAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsPointAttribute")]
	public class ApiResponsePIItemsPointAttribute : ApiParentResponse, IApiResponsePIItemsPointAttribute
	{
		public PIItemsPointAttribute Data { get; set; }
		public ApiResponsePIItemsPointAttribute(int statusCode, IDictionary<string, string> headers, PIItemsPointAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
