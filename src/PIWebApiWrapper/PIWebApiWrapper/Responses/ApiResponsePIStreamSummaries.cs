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
	[Guid("389522AF-614C-47B7-A8E6-D7647D03CD85")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamSummaries
	{
		[DispId(1)]
		PIStreamSummaries Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("FDF9F4A3-248C-4C02-A72E-38DFA59488C2")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamSummaries))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamSummaries")]
	public class ApiResponsePIStreamSummaries : ApiParentResponse, IApiResponsePIStreamSummaries
	{
		public PIStreamSummaries Data { get; set; }
		public ApiResponsePIStreamSummaries(int statusCode, IDictionary<string, string> headers, PIStreamSummaries data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
