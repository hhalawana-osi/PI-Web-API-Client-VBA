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
	[Guid("BBE5EFBF-A3AB-41C6-BD4B-8AF65A3D48AC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISearchByAttributeEventFrame
	{
		[DispId(1)]
		PISearchByAttributeEventFrame Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("AEC5423E-58B9-4E8E-8C8E-17037AE60238")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISearchByAttributeEventFrame))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISearchByAttributeEventFrame")]
	public class ApiResponsePISearchByAttributeEventFrame : ApiParentResponse, IApiResponsePISearchByAttributeEventFrame
	{
		public PISearchByAttributeEventFrame Data { get; set; }
		public ApiResponsePISearchByAttributeEventFrame(int statusCode, IDictionary<string, string> headers, PISearchByAttributeEventFrame data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
