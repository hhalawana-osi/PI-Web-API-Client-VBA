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
	[Guid("232B333F-6E96-435A-A8FD-6B985D8DF3E5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAttributeCategory
	{
		[DispId(1)]
		PIItemsAttributeCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("AC801F69-D8CD-413E-81A3-1DB05DAD7B97")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAttributeCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAttributeCategory")]
	public class ApiResponsePIItemsAttributeCategory : ApiParentResponse, IApiResponsePIItemsAttributeCategory
	{
		public PIItemsAttributeCategory Data { get; set; }
		public ApiResponsePIItemsAttributeCategory(int statusCode, IDictionary<string, string> headers, PIItemsAttributeCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
