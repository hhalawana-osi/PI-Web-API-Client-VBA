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
	[Guid("58D7D37D-DE00-45D4-B2B5-E8777150A803")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIVersion
	{
		[DispId(1)]
		PIVersion Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("8CA52833-41DA-4F94-BD6E-F5B97764BDD5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIVersion))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIVersion")]
	public class ApiResponsePIVersion : ApiParentResponse, IApiResponsePIVersion
	{
		public PIVersion Data { get; set; }
		public ApiResponsePIVersion(int statusCode, IDictionary<string, string> headers, PIVersion data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
