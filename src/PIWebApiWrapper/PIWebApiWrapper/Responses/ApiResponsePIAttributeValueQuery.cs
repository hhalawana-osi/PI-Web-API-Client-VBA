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
	[Guid("8023C6E0-7F03-452E-ADAA-5DED13498ACB")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeValueQuery
	{
		[DispId(1)]
		PIAttributeValueQuery Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("66848A72-F731-4840-9799-6B2D69DBE5ED")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeValueQuery))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeValueQuery")]
	public class ApiResponsePIAttributeValueQuery : ApiParentResponse, IApiResponsePIAttributeValueQuery
	{
		public PIAttributeValueQuery Data { get; set; }
		public ApiResponsePIAttributeValueQuery(int statusCode, IDictionary<string, string> headers, PIAttributeValueQuery data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}