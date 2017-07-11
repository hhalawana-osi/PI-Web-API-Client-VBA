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
	[Guid("76906310-6F78-4C39-B793-0ADF03C7121C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsStreamValue
	{
		[DispId(1)]
		PIItemsStreamValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("86E00E0C-E59E-4672-829E-13215B25FA59")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsStreamValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsStreamValue")]
	public class ApiResponsePIItemsStreamValue : ApiParentResponse, IApiResponsePIItemsStreamValue
	{
		public PIItemsStreamValue Data { get; set; }
		public ApiResponsePIItemsStreamValue(int statusCode, IDictionary<string, string> headers, PIItemsStreamValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
