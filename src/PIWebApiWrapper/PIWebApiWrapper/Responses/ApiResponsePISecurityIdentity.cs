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
	[Guid("F8818899-2DDF-4DEE-8AD4-63FA85725EF2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityIdentity
	{
		[DispId(1)]
		PISecurityIdentity Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("43F89C0C-1F9E-44AB-BBB5-EEFDAE57F372")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityIdentity))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityIdentity")]
	public class ApiResponsePISecurityIdentity : ApiParentResponse, IApiResponsePISecurityIdentity
	{
		public PISecurityIdentity Data { get; set; }
		public ApiResponsePISecurityIdentity(int statusCode, IDictionary<string, string> headers, PISecurityIdentity data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
