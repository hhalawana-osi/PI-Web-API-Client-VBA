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
	[Guid("DA45B165-3EFE-41D8-88CA-1A1D225D74DF")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISummaryValue
	{
		[DispId(1)]
		PISummaryValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("4EE4410C-0DC4-4473-8280-0F04E1DF1981")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISummaryValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISummaryValue")]
	public class ApiResponsePISummaryValue : ApiParentResponse, IApiResponsePISummaryValue
	{
		public PISummaryValue Data { get; set; }
		public ApiResponsePISummaryValue(int statusCode, IDictionary<string, string> headers, PISummaryValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
