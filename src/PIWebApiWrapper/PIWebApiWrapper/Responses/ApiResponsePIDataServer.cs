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
	[Guid("5EB4CFC6-BF11-45D4-929B-C9AC8990A643")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIDataServer
	{
		[DispId(1)]
		PIDataServer Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("5B99CBA8-B495-41F2-B3FE-2A143AA7FA04")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIDataServer))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIDataServer")]
	public class ApiResponsePIDataServer : ApiParentResponse, IApiResponsePIDataServer
	{
		public PIDataServer Data { get; set; }
		public ApiResponsePIDataServer(int statusCode, IDictionary<string, string> headers, PIDataServer data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
