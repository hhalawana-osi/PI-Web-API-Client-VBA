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
	[Guid("B124A103-F269-4CB0-8248-BB0016279223")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnnotation
	{
		[DispId(1)]
		PIItemsAnnotation Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("ED5134BF-7175-4343-8F99-033614BD4B2C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnnotation))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnnotation")]
	public class ApiResponsePIItemsAnnotation : ApiParentResponse, IApiResponsePIItemsAnnotation
	{
		public PIItemsAnnotation Data { get; set; }
		public ApiResponsePIItemsAnnotation(int statusCode, IDictionary<string, string> headers, PIItemsAnnotation data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
