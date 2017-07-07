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
	[Guid("733CB74F-8A3B-4628-80B7-A97F23AA0A4C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAttribute
	{
		[DispId(1)]
		PIItemsAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("6E7CE040-48DD-4216-B973-69AD94F63704")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAttribute")]
	public class ApiResponsePIItemsAttribute : ApiParentResponse, IApiResponsePIItemsAttribute
	{
		public PIItemsAttribute Data { get; set; }
		public ApiResponsePIItemsAttribute(int statusCode, IDictionary<string, string> headers, PIItemsAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
