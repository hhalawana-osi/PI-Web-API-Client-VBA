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
	[Guid("D5CA0606-929D-44E6-82B2-49250E4AEA13")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnalysis
	{
		[DispId(1)]
		PIItemsAnalysis Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("02426729-89B0-46A0-A7EC-41FF8D5F419A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnalysis))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnalysis")]
	public class ApiResponsePIItemsAnalysis : ApiParentResponse, IApiResponsePIItemsAnalysis
	{
		public PIItemsAnalysis Data { get; set; }
		public ApiResponsePIItemsAnalysis(int statusCode, IDictionary<string, string> headers, PIItemsAnalysis data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
