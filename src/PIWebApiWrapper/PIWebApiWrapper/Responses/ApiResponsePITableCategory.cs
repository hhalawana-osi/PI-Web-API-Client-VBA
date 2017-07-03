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
	[Guid("D0968BDF-4327-4F1A-9DB8-33EA2E79F608")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITableCategory
	{
		[DispId(1)]
		PITableCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("EEA0D0CB-A3CD-4093-B8AE-C6B856202469")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITableCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITableCategory")]
	public class ApiResponsePITableCategory : ApiParentResponse, IApiResponsePITableCategory
	{
		public PITableCategory Data { get; set; }
		public ApiResponsePITableCategory(int statusCode, IDictionary<string, string> headers, PITableCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
