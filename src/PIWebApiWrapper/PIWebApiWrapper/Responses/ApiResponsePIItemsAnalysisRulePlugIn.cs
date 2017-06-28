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
	[Guid("6CF8E1A6-E46C-4E66-B9F7-3BB514524486")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnalysisRulePlugIn
	{
		[DispId(1)]
		PIItemsAnalysisRulePlugIn Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("25C8C8DD-83FC-41B5-9742-ED4F2A0161CE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnalysisRulePlugIn))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnalysisRulePlugIn")]
	public class ApiResponsePIItemsAnalysisRulePlugIn : ApiParentResponse, IApiResponsePIItemsAnalysisRulePlugIn
	{
		public PIItemsAnalysisRulePlugIn Data { get; set; }
		public ApiResponsePIItemsAnalysisRulePlugIn(int statusCode, IDictionary<string, string> headers, PIItemsAnalysisRulePlugIn data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
