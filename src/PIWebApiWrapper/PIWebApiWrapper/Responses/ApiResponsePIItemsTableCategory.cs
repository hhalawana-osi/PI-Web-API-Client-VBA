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
	[Guid("1C397FD6-A926-42CF-BAC3-DB9EC5ADCD91")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsTableCategory
	{
		[DispId(1)]
		PIItemsTableCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("F8DFA800-01F2-4359-81D9-D53855ABA285")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsTableCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsTableCategory")]
	public class ApiResponsePIItemsTableCategory : ApiParentResponse, IApiResponsePIItemsTableCategory
	{
		public PIItemsTableCategory Data { get; set; }
		public ApiResponsePIItemsTableCategory(int statusCode, IDictionary<string, string> headers, PIItemsTableCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
