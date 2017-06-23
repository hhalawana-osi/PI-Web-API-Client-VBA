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
	[Guid("0D75A176-C9F1-498F-A4C9-E9908EAE03CC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAssetServer
	{
		[DispId(1)]
		PIAssetServer Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("080CBCD8-B821-4A35-B570-41B004B5E3A2")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAssetServer))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAssetServer")]
	public class ApiResponsePIAssetServer : ApiParentResponse, IApiResponsePIAssetServer
	{
		public PIAssetServer Data { get; set; }
		public ApiResponsePIAssetServer(int statusCode, IDictionary<string, string> headers, PIAssetServer data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
