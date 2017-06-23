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
	[Guid("89C616C1-6C72-4922-BF6A-6A0B18FF22D4")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIEventFrame
	{
		[DispId(1)]
		PIEventFrame Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("A91D3DB7-B27D-48AA-B6C3-F5486ADD3267")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIEventFrame))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIEventFrame")]
	public class ApiResponsePIEventFrame : ApiParentResponse, IApiResponsePIEventFrame
	{
		public PIEventFrame Data { get; set; }
		public ApiResponsePIEventFrame(int statusCode, IDictionary<string, string> headers, PIEventFrame data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
