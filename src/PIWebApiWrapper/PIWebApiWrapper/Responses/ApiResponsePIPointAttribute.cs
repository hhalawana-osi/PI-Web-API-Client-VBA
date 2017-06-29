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
	[Guid("084D493B-526C-4140-92C4-F09671E5BC8E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIPointAttribute
	{
		[DispId(1)]
		PIPointAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("2B2A2ABF-6DEC-4956-B4DD-DBD6C79FAD30")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIPointAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIPointAttribute")]
	public class ApiResponsePIPointAttribute : ApiParentResponse, IApiResponsePIPointAttribute
	{
		public PIPointAttribute Data { get; set; }
		public ApiResponsePIPointAttribute(int statusCode, IDictionary<string, string> headers, PIPointAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
