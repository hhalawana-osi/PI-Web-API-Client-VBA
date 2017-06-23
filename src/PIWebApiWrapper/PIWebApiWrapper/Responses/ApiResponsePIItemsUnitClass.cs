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
	[Guid("52D34767-844E-42E0-8E47-B70FBDE1767E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsUnitClass
	{
		[DispId(1)]
		PIItemsUnitClass Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1C4E984A-EFF6-4D43-9BC8-6550CE811A7E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsUnitClass))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsUnitClass")]
	public class ApiResponsePIItemsUnitClass : ApiParentResponse, IApiResponsePIItemsUnitClass
	{
		public PIItemsUnitClass Data { get; set; }
		public ApiResponsePIItemsUnitClass(int statusCode, IDictionary<string, string> headers, PIItemsUnitClass data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
