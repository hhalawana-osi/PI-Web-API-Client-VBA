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
	[Guid("FB23ECF2-DD59-4F7B-9977-8B51CB13FEB0")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePICacheInstance
	{
		[DispId(1)]
		PICacheInstance Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("ADBC4A30-52FE-41A4-BCAC-12D4E491D28B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePICacheInstance))]
	[ProgId("PIWebAPIWrapper.ApiResponsePICacheInstance")]
	public class ApiResponsePICacheInstance : ApiParentResponse, IApiResponsePICacheInstance
	{
		public PICacheInstance Data { get; set; }
		public ApiResponsePICacheInstance(int statusCode, IDictionary<string, string> headers, PICacheInstance data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
