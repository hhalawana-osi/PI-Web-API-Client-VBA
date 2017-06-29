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
	[Guid("C6F2D065-B407-4DD1-9CC0-D29CCFB6E493")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsItemsSubstatus
	{
		[DispId(1)]
		PIItemsItemsSubstatus Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("732801E5-94CC-4E2C-8CE9-F3C5E3BB9DB0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsItemsSubstatus))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsItemsSubstatus")]
	public class ApiResponsePIItemsItemsSubstatus : ApiParentResponse, IApiResponsePIItemsItemsSubstatus
	{
		public PIItemsItemsSubstatus Data { get; set; }
		public ApiResponsePIItemsItemsSubstatus(int statusCode, IDictionary<string, string> headers, PIItemsItemsSubstatus data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
