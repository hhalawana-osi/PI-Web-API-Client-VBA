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
	[Guid("F29BDC5A-DD7B-44D0-8F05-785CCD9E6FAD")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnalysisRulePlugIn
	{
		[DispId(1)]
		PIItemsAnalysisRulePlugIn Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("4576EEC1-03E8-4A74-B95E-78ADE77793D6")]
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
