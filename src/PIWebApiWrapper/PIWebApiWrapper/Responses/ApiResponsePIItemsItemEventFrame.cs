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
	[Guid("3421FC86-C1D0-4A81-90D1-8B2613B76071")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsItemEventFrame
	{
		[DispId(1)]
		PIItemsItemEventFrame Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("5BFE7349-B401-4B17-A405-2EF9A9336B58")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsItemEventFrame))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsItemEventFrame")]
	public class ApiResponsePIItemsItemEventFrame : ApiParentResponse, IApiResponsePIItemsItemEventFrame
	{
		public PIItemsItemEventFrame Data { get; set; }
		public ApiResponsePIItemsItemEventFrame(int statusCode, IDictionary<string, string> headers, PIItemsItemEventFrame data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
