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
	[Guid("C10D57FE-31F0-4E12-B8BC-631FB987A114")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISystemStatus
	{
		[DispId(1)]
		PISystemStatus Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("04FD819F-8B65-4A8A-A47A-6C31B2CF6BFA")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISystemStatus))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISystemStatus")]
	public class ApiResponsePISystemStatus : ApiParentResponse, IApiResponsePISystemStatus
	{
		public PISystemStatus Data { get; set; }
		public ApiResponsePISystemStatus(int statusCode, IDictionary<string, string> headers, PISystemStatus data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
