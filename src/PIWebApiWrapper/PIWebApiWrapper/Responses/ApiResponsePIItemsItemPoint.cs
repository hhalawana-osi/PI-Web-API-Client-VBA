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
	[Guid("01D09F24-3152-4119-86E5-A3EF3F425812")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsItemPoint
	{
		[DispId(1)]
		PIItemsItemPoint Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("111D1D6F-3BDF-4B88-9371-288DB9E8A788")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsItemPoint))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsItemPoint")]
	public class ApiResponsePIItemsItemPoint : ApiParentResponse, IApiResponsePIItemsItemPoint
	{
		public PIItemsItemPoint Data { get; set; }
		public ApiResponsePIItemsItemPoint(int statusCode, IDictionary<string, string> headers, PIItemsItemPoint data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
