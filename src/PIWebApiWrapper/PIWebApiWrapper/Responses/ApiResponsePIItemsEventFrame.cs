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
	[Guid("24B106B7-BB80-408E-BE40-9E22F58D4AA1")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsEventFrame
	{
		[DispId(1)]
		PIItemsEventFrame Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("9B20D823-0127-4FCC-8A22-5A96546595B6")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsEventFrame))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsEventFrame")]
	public class ApiResponsePIItemsEventFrame : ApiParentResponse, IApiResponsePIItemsEventFrame
	{
		public PIItemsEventFrame Data { get; set; }
		public ApiResponsePIItemsEventFrame(int statusCode, IDictionary<string, string> headers, PIItemsEventFrame data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
