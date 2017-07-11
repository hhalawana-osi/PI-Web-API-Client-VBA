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
	[Guid("D5BDF776-5119-45E8-A75C-AEB0D1952D03")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITimedValue
	{
		[DispId(1)]
		PITimedValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B39D0037-3DB6-4B6C-B86C-6C9B9A8B7EBE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITimedValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITimedValue")]
	public class ApiResponsePITimedValue : ApiParentResponse, IApiResponsePITimedValue
	{
		public PITimedValue Data { get; set; }
		public ApiResponsePITimedValue(int statusCode, IDictionary<string, string> headers, PITimedValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
