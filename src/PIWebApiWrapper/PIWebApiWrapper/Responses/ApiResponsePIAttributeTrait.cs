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
	[Guid("9D3C0BAF-3490-404F-AEEC-B7F2CB15F7A4")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeTrait
	{
		[DispId(1)]
		PIAttributeTrait Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("12FAE1D2-CF15-443D-A631-62E381052EAF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeTrait))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeTrait")]
	public class ApiResponsePIAttributeTrait : ApiParentResponse, IApiResponsePIAttributeTrait
	{
		public PIAttributeTrait Data { get; set; }
		public ApiResponsePIAttributeTrait(int statusCode, IDictionary<string, string> headers, PIAttributeTrait data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
