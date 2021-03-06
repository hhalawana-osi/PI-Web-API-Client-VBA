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
	[Guid("6ABD890D-911B-48EB-A416-4D65E8A3C206")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemAttribute
	{
		[DispId(1)]
		PIItemAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("D8863DFE-B37C-4958-A783-537912434DE5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemAttribute")]
	public class ApiResponsePIItemAttribute : ApiParentResponse, IApiResponsePIItemAttribute
	{
		public PIItemAttribute Data { get; set; }
		public ApiResponsePIItemAttribute(int statusCode, IDictionary<string, string> headers, PIItemAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
