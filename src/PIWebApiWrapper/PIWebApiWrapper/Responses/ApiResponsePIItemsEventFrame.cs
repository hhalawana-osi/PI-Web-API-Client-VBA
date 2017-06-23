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
	[Guid("97C82D95-34F6-42A2-83EA-F7195CDE1A1E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsEventFrame
	{
		[DispId(1)]
		PIItemsEventFrame Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("C6A5CF90-DE27-449E-BE76-6C5AA1DA7B07")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsEventFrame))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsEventFrame")]
	public class ApiResponsePIItemsEventFrame : ApiParentResponse, IApiResponsePIItemsEventFrame
	{
		public PIItemsEventFrame Data { get; set; }
		public ApiResponsePIItemsEventFrame(int statusCode, IDictionary<string, string> headers, PIItemsEventFrame data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
