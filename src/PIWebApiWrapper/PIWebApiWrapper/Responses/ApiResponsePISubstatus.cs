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
	[Guid("1C1CCD00-8E3B-4BA4-980F-83D51DFC3A50")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISubstatus
	{
		[DispId(1)]
		PISubstatus Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("6ABC4B1D-0FE8-4C27-A9B2-35CBA0A447DE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISubstatus))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISubstatus")]
	public class ApiResponsePISubstatus : ApiParentResponse, IApiResponsePISubstatus
	{
		public PISubstatus Data { get; set; }
		public ApiResponsePISubstatus(int statusCode, IDictionary<string, string> headers, PISubstatus data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
