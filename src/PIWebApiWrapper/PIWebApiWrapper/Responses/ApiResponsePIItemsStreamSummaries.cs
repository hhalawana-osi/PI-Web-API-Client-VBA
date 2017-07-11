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
	[Guid("D47990BE-5D5C-46E0-8074-02E9B94C69C5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsStreamSummaries
	{
		[DispId(1)]
		PIItemsStreamSummaries Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("77B7479A-BABB-43C3-B3AE-36E65550F508")]
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
