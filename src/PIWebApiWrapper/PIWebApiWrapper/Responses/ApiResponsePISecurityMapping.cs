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
	[Guid("460FF09E-3A61-4156-91CC-AFEC44712CC5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityMapping
	{
		[DispId(1)]
		PISecurityMapping Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E940A1F6-A70A-4666-9535-3EC465092635")]
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
