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
	[Guid("68094C42-7AFE-4D35-BEF3-25AC5C3EC1E8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsCacheInstance
	{
		[DispId(1)]
		PIItemsCacheInstance Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("66E82CE9-C0C9-4D0A-9640-53683DD1EF19")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsCacheInstance))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsCacheInstance")]
	public class ApiResponsePIItemsCacheInstance : ApiParentResponse, IApiResponsePIItemsCacheInstance
	{
		public PIItemsCacheInstance Data { get; set; }
		public ApiResponsePIItemsCacheInstance(int statusCode, IDictionary<string, string> headers, PIItemsCacheInstance data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
