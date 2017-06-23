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
	[Guid("B4ADA351-FF2E-4748-ABDA-8202F3B7C9F2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemEventFrame
	{
		[DispId(1)]
		PIItemEventFrame Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1D040AA0-4352-4E95-9453-65F83453F732")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemEventFrame))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemEventFrame")]
	public class ApiResponsePIItemEventFrame : ApiParentResponse, IApiResponsePIItemEventFrame
	{
		public PIItemEventFrame Data { get; set; }
		public ApiResponsePIItemEventFrame(int statusCode, IDictionary<string, string> headers, PIItemEventFrame data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
