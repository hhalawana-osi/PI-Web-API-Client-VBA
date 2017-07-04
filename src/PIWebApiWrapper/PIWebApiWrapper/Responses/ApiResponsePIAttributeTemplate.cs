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
	[Guid("CF1DC163-05DA-4AFD-99C2-FB23EC35843E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeTemplate
	{
		[DispId(1)]
		PIAttributeTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("CE1895D4-876C-403E-BFF8-1E3FFA030815")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeTemplate")]
	public class ApiResponsePIAttributeTemplate : ApiParentResponse, IApiResponsePIAttributeTemplate
	{
		public PIAttributeTemplate Data { get; set; }
		public ApiResponsePIAttributeTemplate(int statusCode, IDictionary<string, string> headers, PIAttributeTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
