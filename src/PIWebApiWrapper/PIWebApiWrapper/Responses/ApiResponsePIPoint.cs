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
	[Guid("56B8D01E-515C-47F7-B7D9-D0B7F0F1E4CD")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIPoint
	{
		[DispId(1)]
		PIPoint Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("94AED43F-44F3-40E5-B3D0-ABE9A29166FC")]
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
