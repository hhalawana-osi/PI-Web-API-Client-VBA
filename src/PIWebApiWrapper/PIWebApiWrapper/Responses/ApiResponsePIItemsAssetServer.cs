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
	[Guid("B607AEE6-36F2-4D6B-95EB-98A87F4CDA0D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAssetServer
	{
		[DispId(1)]
		PIItemsAssetServer Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E79316AC-2D92-460C-B19D-FD5B33EBEDCF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAssetServer))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAssetServer")]
	public class ApiResponsePIItemsAssetServer : ApiParentResponse, IApiResponsePIItemsAssetServer
	{
		public PIItemsAssetServer Data { get; set; }
		public ApiResponsePIItemsAssetServer(int statusCode, IDictionary<string, string> headers, PIItemsAssetServer data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
