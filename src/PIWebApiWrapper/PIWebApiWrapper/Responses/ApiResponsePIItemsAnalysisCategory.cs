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
	[Guid("71E6AD0A-7D97-43DB-BA48-E1C8C941FBFD")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnalysisCategory
	{
		[DispId(1)]
		PIItemsAnalysisCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("2C519818-1FE3-40D6-9314-7B9AF0563345")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnalysisCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnalysisCategory")]
	public class ApiResponsePIItemsAnalysisCategory : ApiParentResponse, IApiResponsePIItemsAnalysisCategory
	{
		public PIItemsAnalysisCategory Data { get; set; }
		public ApiResponsePIItemsAnalysisCategory(int statusCode, IDictionary<string, string> headers, PIItemsAnalysisCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
