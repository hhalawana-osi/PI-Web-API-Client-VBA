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
	[Guid("635AF76E-62C9-4580-859A-EA1E19461D5C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsElement
	{
		[DispId(1)]
		PIItemsElement Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("D2E6ACE8-0FA3-4070-9B78-5AE7D3D8E089")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsElement))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsElement")]
	public class ApiResponsePIItemsElement : ApiParentResponse, IApiResponsePIItemsElement
	{
		public PIItemsElement Data { get; set; }
		public ApiResponsePIItemsElement(int statusCode, IDictionary<string, string> headers, PIItemsElement data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
