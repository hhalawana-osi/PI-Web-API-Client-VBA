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
	[Guid("3F37AAD1-C23A-4684-9499-F64081321BB8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSecurityRights
	{
		[DispId(1)]
		PIItemsSecurityRights Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("90032C5B-1A32-4932-A060-6D968158F63B")]
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
