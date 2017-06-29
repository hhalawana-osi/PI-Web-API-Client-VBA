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
	[Guid("CDD24A2E-8473-4461-9F2A-98FF165A7C5D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISystemLanding
	{
		[DispId(1)]
		PISystemLanding Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("D9044A2E-8F0D-4740-A72B-B402E8D2F3B4")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISystemLanding))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISystemLanding")]
	public class ApiResponsePISystemLanding : ApiParentResponse, IApiResponsePISystemLanding
	{
		public PISystemLanding Data { get; set; }
		public ApiResponsePISystemLanding(int statusCode, IDictionary<string, string> headers, PISystemLanding data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
