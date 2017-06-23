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
	[Guid("48CE7A4D-CF0F-4DA3-BABF-A43060849C7E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsStreamSummaries
	{
		[DispId(1)]
		PIItemsStreamSummaries Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("C5C32AE6-7624-4F92-84C5-C099D2E42413")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsStreamSummaries))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsStreamSummaries")]
	public class ApiResponsePIItemsStreamSummaries : ApiParentResponse, IApiResponsePIItemsStreamSummaries
	{
		public PIItemsStreamSummaries Data { get; set; }
		public ApiResponsePIItemsStreamSummaries(int statusCode, IDictionary<string, string> headers, PIItemsStreamSummaries data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
