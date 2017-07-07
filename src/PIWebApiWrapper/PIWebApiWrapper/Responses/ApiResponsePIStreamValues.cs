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
	[Guid("5CBE12C4-1B4B-44A4-91A1-82C783C32517")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamValues
	{
		[DispId(1)]
		PIStreamValues Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("0BEFE61F-D71F-4669-9CCB-AAACD3437909")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamValues))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamValues")]
	public class ApiResponsePIStreamValues : ApiParentResponse, IApiResponsePIStreamValues
	{
		public PIStreamValues Data { get; set; }
		public ApiResponsePIStreamValues(int statusCode, IDictionary<string, string> headers, PIStreamValues data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
