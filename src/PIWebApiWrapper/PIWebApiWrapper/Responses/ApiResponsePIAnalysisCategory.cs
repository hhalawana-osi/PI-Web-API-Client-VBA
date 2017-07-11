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
	[Guid("8BDAC6AA-60DE-4D9E-9684-DC2BCBA42191")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysisCategory
	{
		[DispId(1)]
		PIAnalysisCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("D9AB537C-B964-4F0D-8CA7-51BEA81BBD94")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysisCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysisCategory")]
	public class ApiResponsePIAnalysisCategory : ApiParentResponse, IApiResponsePIAnalysisCategory
	{
		public PIAnalysisCategory Data { get; set; }
		public ApiResponsePIAnalysisCategory(int statusCode, IDictionary<string, string> headers, PIAnalysisCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
