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
	[Guid("E4D81E1C-0B7A-4671-8390-BD0C1D078BB2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIResponse
	{
		[DispId(1)]
		PIResponse Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E6AAC650-98C0-4675-BEB9-B5325D0BBD9C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIResponse))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIResponse")]
	public class ApiResponsePIResponse : ApiParentResponse, IApiResponsePIResponse
	{
		public PIResponse Data { get; set; }
		public ApiResponsePIResponse(int statusCode, IDictionary<string, string> headers, PIResponse data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
