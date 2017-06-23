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
	[Guid("1BD65383-2147-49C5-84E2-A65AEF356652")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIUnit
	{
		[DispId(1)]
		PIUnit Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("BB90E863-0922-4BE1-9AD7-F6689B6F2753")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIUnit))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIUnit")]
	public class ApiResponsePIUnit : ApiParentResponse, IApiResponsePIUnit
	{
		public PIUnit Data { get; set; }
		public ApiResponsePIUnit(int statusCode, IDictionary<string, string> headers, PIUnit data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
