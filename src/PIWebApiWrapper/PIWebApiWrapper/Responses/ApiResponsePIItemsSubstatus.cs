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
	[Guid("89CC1611-65D7-46A7-AE98-D8BE23412AE2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSubstatus
	{
		[DispId(1)]
		PIItemsSubstatus Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("ED4A695F-C7AB-4750-9BED-05530B866DE2")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSubstatus))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSubstatus")]
	public class ApiResponsePIItemsSubstatus : ApiParentResponse, IApiResponsePIItemsSubstatus
	{
		public PIItemsSubstatus Data { get; set; }
		public ApiResponsePIItemsSubstatus(int statusCode, IDictionary<string, string> headers, PIItemsSubstatus data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
