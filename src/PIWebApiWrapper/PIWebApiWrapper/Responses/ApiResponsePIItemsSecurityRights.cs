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
	[Guid("66438D83-E85F-46F1-9E04-577F8AE23A69")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSecurityRights
	{
		[DispId(1)]
		PIItemsSecurityRights Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("20AC99C8-0992-4BF4-96E0-5148394B0394")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSecurityRights))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSecurityRights")]
	public class ApiResponsePIItemsSecurityRights : ApiParentResponse, IApiResponsePIItemsSecurityRights
	{
		public PIItemsSecurityRights Data { get; set; }
		public ApiResponsePIItemsSecurityRights(int statusCode, IDictionary<string, string> headers, PIItemsSecurityRights data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
