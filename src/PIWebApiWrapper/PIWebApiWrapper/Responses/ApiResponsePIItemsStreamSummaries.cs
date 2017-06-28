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
	[Guid("E0DB6E9E-D5EC-4DC5-B357-A9534065D925")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsStreamSummaries
	{
		[DispId(1)]
		PIItemsStreamSummaries Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("8FAD2F26-4DB7-4938-8B2A-874956DEE273")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsStreamSummaries))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsStreamSummaries")]
	public class ApiResponsePIItemsStreamSummaries : ApiParentResponse, IApiResponsePIItemsStreamSummaries
	{
		public PIItemsStreamSummaries Data { get; set; }
		public ApiResponsePIItemsStreamSummaries(int statusCode, IDictionary<string, string> headers, PIItemsStreamSummaries data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
