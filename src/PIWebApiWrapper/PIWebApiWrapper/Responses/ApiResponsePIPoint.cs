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
	[Guid("A7149E10-F963-4E6A-83EA-B99FA634003E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIPoint
	{
		[DispId(1)]
		PIPoint Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("2F96EE7E-6956-4DCE-ABA9-E3564DA2C251")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIPoint))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIPoint")]
	public class ApiResponsePIPoint : ApiParentResponse, IApiResponsePIPoint
	{
		public PIPoint Data { get; set; }
		public ApiResponsePIPoint(int statusCode, IDictionary<string, string> headers, PIPoint data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
