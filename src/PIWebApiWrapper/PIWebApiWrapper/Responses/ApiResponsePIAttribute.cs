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
	[Guid("5BD70A59-D7CE-4CEA-918E-EF03B79ACBED")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttribute
	{
		[DispId(1)]
		PIAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1270C8A8-2D4A-4D0B-9FED-6FE1F5C25665")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttribute")]
	public class ApiResponsePIAttribute : ApiParentResponse, IApiResponsePIAttribute
	{
		public PIAttribute Data { get; set; }
		public ApiResponsePIAttribute(int statusCode, IDictionary<string, string> headers, PIAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
