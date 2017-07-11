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
	[Guid("E10A051A-0816-4B1F-832F-D9532F8D29C7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISearchByAttributeElement
	{
		[DispId(1)]
		PISearchByAttributeElement Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("C01CF0EB-C6A5-412D-8A46-288D3B4874CA")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISearchByAttributeElement))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISearchByAttributeElement")]
	public class ApiResponsePISearchByAttributeElement : ApiParentResponse, IApiResponsePISearchByAttributeElement
	{
		public PISearchByAttributeElement Data { get; set; }
		public ApiResponsePISearchByAttributeElement(int statusCode, IDictionary<string, string> headers, PISearchByAttributeElement data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
