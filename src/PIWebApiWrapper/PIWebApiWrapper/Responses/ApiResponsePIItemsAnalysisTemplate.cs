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
	[Guid("1A43A432-5298-40B5-A3D5-693179393264")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnalysisTemplate
	{
		[DispId(1)]
		PIItemsAnalysisTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("C189B8ED-BD60-44C3-A9BC-22751A59B9A1")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnalysisTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnalysisTemplate")]
	public class ApiResponsePIItemsAnalysisTemplate : ApiParentResponse, IApiResponsePIItemsAnalysisTemplate
	{
		public PIItemsAnalysisTemplate Data { get; set; }
		public ApiResponsePIItemsAnalysisTemplate(int statusCode, IDictionary<string, string> headers, PIItemsAnalysisTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
