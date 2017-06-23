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
	[Guid("761A868A-6E87-457A-ADDD-9181AC59EEAA")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITimedValue
	{
		[DispId(1)]
		PITimedValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("59B490BF-984A-40F4-A4CD-DE214C1FB99B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITimedValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITimedValue")]
	public class ApiResponsePITimedValue : ApiParentResponse, IApiResponsePITimedValue
	{
		public PITimedValue Data { get; set; }
		public ApiResponsePITimedValue(int statusCode, IDictionary<string, string> headers, PITimedValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
