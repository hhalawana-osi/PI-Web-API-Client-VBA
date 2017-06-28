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
	[Guid("6F0818F0-E039-4C77-9DA4-0BB12B7DB851")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIPoint
	{
		[DispId(1)]
		PIPoint Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("5207EF2F-FD6D-43C7-BC39-B5EB9E24A1F7")]
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
