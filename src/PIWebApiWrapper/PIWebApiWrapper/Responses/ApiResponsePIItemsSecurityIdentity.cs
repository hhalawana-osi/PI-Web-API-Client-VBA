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
	[Guid("FBB69C3F-A510-48BE-A19C-F84379B929E1")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSecurityIdentity
	{
		[DispId(1)]
		PIItemsSecurityIdentity Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("F4F9E651-059D-43CA-998B-58B637787D7B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSecurityIdentity))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSecurityIdentity")]
	public class ApiResponsePIItemsSecurityIdentity : ApiParentResponse, IApiResponsePIItemsSecurityIdentity
	{
		public PIItemsSecurityIdentity Data { get; set; }
		public ApiResponsePIItemsSecurityIdentity(int statusCode, IDictionary<string, string> headers, PIItemsSecurityIdentity data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
