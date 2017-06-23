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
	[Guid("A3E02970-22F3-4F4C-8B50-9FE51789003F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamValue
	{
		[DispId(1)]
		PIStreamValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("150AE855-D834-4420-8FDA-EF262EF304B4")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamValue")]
	public class ApiResponsePIStreamValue : ApiParentResponse, IApiResponsePIStreamValue
	{
		public PIStreamValue Data { get; set; }
		public ApiResponsePIStreamValue(int statusCode, IDictionary<string, string> headers, PIStreamValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
