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
	[Guid("426A1F22-961E-42AF-88D1-109628D024CC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIErrors
	{
		[DispId(1)]
		PIErrors Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("367F739B-E506-4CE2-BAB1-405B4A8E052A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIErrors))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIErrors")]
	public class ApiResponsePIErrors : ApiParentResponse, IApiResponsePIErrors
	{
		public PIErrors Data { get; set; }
		public ApiResponsePIErrors(int statusCode, IDictionary<string, string> headers, PIErrors data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
