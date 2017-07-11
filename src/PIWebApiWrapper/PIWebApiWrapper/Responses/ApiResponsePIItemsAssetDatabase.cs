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
	[Guid("9DF9BFA0-B945-487B-9ADF-D7867869C8AF")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAssetDatabase
	{
		[DispId(1)]
		PIItemsAssetDatabase Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B445EC89-9838-4F64-A80B-A4C7BE69465F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAssetDatabase))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAssetDatabase")]
	public class ApiResponsePIItemsAssetDatabase : ApiParentResponse, IApiResponsePIItemsAssetDatabase
	{
		public PIItemsAssetDatabase Data { get; set; }
		public ApiResponsePIItemsAssetDatabase(int statusCode, IDictionary<string, string> headers, PIItemsAssetDatabase data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
