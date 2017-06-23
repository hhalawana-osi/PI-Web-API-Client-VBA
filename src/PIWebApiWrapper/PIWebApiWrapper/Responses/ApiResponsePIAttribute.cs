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
	[Guid("F2178A72-A6A5-4AE3-998E-83E0E4A3BD92")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttribute
	{
		[DispId(1)]
		PIAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("694B5865-0F35-4E2C-BAC1-F50AFBF20F0A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttribute")]
	public class ApiResponsePIAttribute : ApiParentResponse, IApiResponsePIAttribute
	{
		public PIAttribute Data { get; set; }
		public ApiResponsePIAttribute(int statusCode, IDictionary<string, string> headers, PIAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
