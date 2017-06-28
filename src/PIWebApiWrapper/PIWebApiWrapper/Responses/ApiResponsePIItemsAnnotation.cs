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
	[Guid("7397FE58-57A9-4722-AFA2-C87B576E5393")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnnotation
	{
		[DispId(1)]
		PIItemsAnnotation Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("385F92AE-7367-4961-8CAA-9BC6141DE080")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnnotation))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnnotation")]
	public class ApiResponsePIItemsAnnotation : ApiParentResponse, IApiResponsePIItemsAnnotation
	{
		public PIItemsAnnotation Data { get; set; }
		public ApiResponsePIItemsAnnotation(int statusCode, IDictionary<string, string> headers, PIItemsAnnotation data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
