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
	[Guid("18967FE2-7185-48A5-812A-972956FBE825")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAttributeTrait
	{
		[DispId(1)]
		PIItemsAttributeTrait Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("848AEF0F-09BA-435A-84C6-8FDE8A2BFFF6")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAttributeTrait))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAttributeTrait")]
	public class ApiResponsePIItemsAttributeTrait : ApiParentResponse, IApiResponsePIItemsAttributeTrait
	{
		public PIItemsAttributeTrait Data { get; set; }
		public ApiResponsePIItemsAttributeTrait(int statusCode, IDictionary<string, string> headers, PIItemsAttributeTrait data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
