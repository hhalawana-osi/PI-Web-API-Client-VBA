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
	[Guid("2F9AE78D-821D-479F-BC7F-2EB444534890")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITimeRulePlugIn
	{
		[DispId(1)]
		PITimeRulePlugIn Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("454DA0C0-E05C-4F81-8211-51C0C6F35D5E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITimeRulePlugIn))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITimeRulePlugIn")]
	public class ApiResponsePITimeRulePlugIn : ApiParentResponse, IApiResponsePITimeRulePlugIn
	{
		public PITimeRulePlugIn Data { get; set; }
		public ApiResponsePITimeRulePlugIn(int statusCode, IDictionary<string, string> headers, PITimeRulePlugIn data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
