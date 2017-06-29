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
	[Guid("AB35DF63-2FFB-433F-9303-50F84CACCD47")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityMapping
	{
		[DispId(1)]
		PISecurityMapping Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("A515CA6E-797A-4E78-80B0-3F27E73DCF87")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityMapping))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityMapping")]
	public class ApiResponsePISecurityMapping : ApiParentResponse, IApiResponsePISecurityMapping
	{
		public PISecurityMapping Data { get; set; }
		public ApiResponsePISecurityMapping(int statusCode, IDictionary<string, string> headers, PISecurityMapping data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
