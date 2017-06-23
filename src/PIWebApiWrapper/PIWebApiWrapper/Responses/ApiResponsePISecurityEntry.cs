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
	[Guid("679EE5AE-4378-43DA-8902-E59229B64E00")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityEntry
	{
		[DispId(1)]
		PISecurityEntry Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("783A9390-971B-48CC-BE3B-34F17E176AF5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityEntry))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityEntry")]
	public class ApiResponsePISecurityEntry : ApiParentResponse, IApiResponsePISecurityEntry
	{
		public PISecurityEntry Data { get; set; }
		public ApiResponsePISecurityEntry(int statusCode, IDictionary<string, string> headers, PISecurityEntry data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
