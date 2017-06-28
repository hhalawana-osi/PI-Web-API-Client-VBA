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
	[Guid("FD4E11D8-FE04-4AEB-B21B-C10D6686D380")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsTableCategory
	{
		[DispId(1)]
		PIItemsTableCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("74567929-6E66-4623-81CB-EDA263FF5198")]
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
