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
	[Guid("F8E28525-B8DA-4EA7-9C2C-B938A2E4E1FB")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamSummaries
	{
		[DispId(1)]
		PIStreamSummaries Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("95293645-8797-4CE0-843B-364FBA67C0D0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamSummaries))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamSummaries")]
	public class ApiResponsePIStreamSummaries : ApiParentResponse, IApiResponsePIStreamSummaries
	{
		public PIStreamSummaries Data { get; set; }
		public ApiResponsePIStreamSummaries(int statusCode, IDictionary<string, string> headers, PIStreamSummaries data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
