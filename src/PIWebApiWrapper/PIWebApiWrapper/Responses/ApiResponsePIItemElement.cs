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
	[Guid("44ECCBFB-71B9-472D-9C08-149BE0476118")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemElement
	{
		[DispId(1)]
		PIItemElement Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("AC7005F0-9A7C-42E5-A2DD-EBF4ED19531A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemElement))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemElement")]
	public class ApiResponsePIItemElement : ApiParentResponse, IApiResponsePIItemElement
	{
		public PIItemElement Data { get; set; }
		public ApiResponsePIItemElement(int statusCode, IDictionary<string, string> headers, PIItemElement data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
