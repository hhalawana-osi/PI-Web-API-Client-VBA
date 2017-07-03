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
	[Guid("5A63096C-77DE-4D85-A0AE-435552583250")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsStreamSummaries
	{
		[DispId(1)]
		PIItemsStreamSummaries Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("529F33EB-87C1-4C0F-8C00-A12CC7B9FF3F")]
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
