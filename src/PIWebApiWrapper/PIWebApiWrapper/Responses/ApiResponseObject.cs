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
	[Guid("4A4092E1-3930-4A50-A424-85F0744C1F1F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponseObject
	{
		[DispId(1)]
		Object Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("EC67F1D4-136D-495E-8723-62CB4D8DA186")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponseObject))]
	[ProgId("PIWebAPIWrapper.ApiResponseObject")]
	public class ApiResponseObject : ApiParentResponse, IApiResponseObject
	{
		public Object Data { get; set; }
		public ApiResponseObject(int statusCode, IDictionary<string, string> headers, Object data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
