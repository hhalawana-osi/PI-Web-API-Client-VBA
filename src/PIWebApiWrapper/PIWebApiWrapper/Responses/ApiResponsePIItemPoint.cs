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
	[Guid("39FF19F8-DC2B-4A8C-B80F-BC24635F2D79")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemPoint
	{
		[DispId(1)]
		PIItemPoint Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("FDE79327-F59F-4AD4-AFE2-28A44C1F0B68")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemPoint))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemPoint")]
	public class ApiResponsePIItemPoint : ApiParentResponse, IApiResponsePIItemPoint
	{
		public PIItemPoint Data { get; set; }
		public ApiResponsePIItemPoint(int statusCode, IDictionary<string, string> headers, PIItemPoint data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
