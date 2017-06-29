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
	[Guid("6E792AC4-4B27-4CB7-91B0-615E7725160D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISystemStatus
	{
		[DispId(1)]
		PISystemStatus Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("10F4FDB0-A625-4B76-8301-5D27BBB548C9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISystemStatus))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISystemStatus")]
	public class ApiResponsePISystemStatus : ApiParentResponse, IApiResponsePISystemStatus
	{
		public PISystemStatus Data { get; set; }
		public ApiResponsePISystemStatus(int statusCode, IDictionary<string, string> headers, PISystemStatus data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
