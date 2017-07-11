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
	[Guid("03899CE6-0984-433B-90C2-6BCAA78484F4")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIUnitClass
	{
		[DispId(1)]
		PIUnitClass Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("96BB319F-C6C9-44C4-BAE4-7C94A4AC1109")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIUnitClass))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIUnitClass")]
	public class ApiResponsePIUnitClass : ApiParentResponse, IApiResponsePIUnitClass
	{
		public PIUnitClass Data { get; set; }
		public ApiResponsePIUnitClass(int statusCode, IDictionary<string, string> headers, PIUnitClass data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
