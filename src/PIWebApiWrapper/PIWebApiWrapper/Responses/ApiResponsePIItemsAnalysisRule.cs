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
	[Guid("5468BE4E-08C3-436F-AFC2-065B5E0A9C86")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnalysisRule
	{
		[DispId(1)]
		PIItemsAnalysisRule Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("C66BB8DE-DBE0-4743-894A-AE5A23BEB467")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnalysisRule))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnalysisRule")]
	public class ApiResponsePIItemsAnalysisRule : ApiParentResponse, IApiResponsePIItemsAnalysisRule
	{
		public PIItemsAnalysisRule Data { get; set; }
		public ApiResponsePIItemsAnalysisRule(int statusCode, IDictionary<string, string> headers, PIItemsAnalysisRule data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
