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
	[Guid("EF74B0B0-B34A-4D34-94F7-B24364B6F417")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysisTemplate
	{
		[DispId(1)]
		PIAnalysisTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("04D1C69F-EC10-4C30-8F18-A080543A2773")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysisTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysisTemplate")]
	public class ApiResponsePIAnalysisTemplate : ApiParentResponse, IApiResponsePIAnalysisTemplate
	{
		public PIAnalysisTemplate Data { get; set; }
		public ApiResponsePIAnalysisTemplate(int statusCode, IDictionary<string, string> headers, PIAnalysisTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
