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
	[Guid("864EE9ED-F2FA-43C1-BE7A-E7B1AA3960E2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIErrors
	{
		[DispId(1)]
		PIErrors Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("7E5A31E5-5B87-489F-A226-EB8DAF39E2D2")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIErrors))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIErrors")]
	public class ApiResponsePIErrors : ApiParentResponse, IApiResponsePIErrors
	{
		public PIErrors Data { get; set; }
		public ApiResponsePIErrors(int statusCode, IDictionary<string, string> headers, PIErrors data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
