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
	[Guid("95132DAE-2753-4701-B725-7DD08C291E9F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSummaryValue
	{
		[DispId(1)]
		PIItemsSummaryValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("A5384488-BB1D-45D4-8D68-AB3AB58C13EC")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSummaryValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSummaryValue")]
	public class ApiResponsePIItemsSummaryValue : ApiParentResponse, IApiResponsePIItemsSummaryValue
	{
		public PIItemsSummaryValue Data { get; set; }
		public ApiResponsePIItemsSummaryValue(int statusCode, IDictionary<string, string> headers, PIItemsSummaryValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
