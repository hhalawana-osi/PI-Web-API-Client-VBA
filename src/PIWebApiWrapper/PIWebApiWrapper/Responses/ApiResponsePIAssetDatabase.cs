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
	[Guid("1F7AE720-B86D-428C-AE8E-7983043CDB43")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAssetDatabase
	{
		[DispId(1)]
		PIAssetDatabase Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("83A94B2E-88DE-4E4B-A792-1CBA58478C1F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAssetDatabase))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAssetDatabase")]
	public class ApiResponsePIAssetDatabase : ApiParentResponse, IApiResponsePIAssetDatabase
	{
		public PIAssetDatabase Data { get; set; }
		public ApiResponsePIAssetDatabase(int statusCode, IDictionary<string, string> headers, PIAssetDatabase data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
