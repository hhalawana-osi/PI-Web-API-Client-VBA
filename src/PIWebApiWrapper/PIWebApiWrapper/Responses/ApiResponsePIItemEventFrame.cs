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
	[Guid("9D4D639F-D911-4EE7-A9AC-E3FB7427A0FD")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemEventFrame
	{
		[DispId(1)]
		PIItemEventFrame Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("4A044C4B-44F9-4A03-831F-09A4D5A3D1B9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemEventFrame))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemEventFrame")]
	public class ApiResponsePIItemEventFrame : ApiParentResponse, IApiResponsePIItemEventFrame
	{
		public PIItemEventFrame Data { get; set; }
		public ApiResponsePIItemEventFrame(int statusCode, IDictionary<string, string> headers, PIItemEventFrame data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
