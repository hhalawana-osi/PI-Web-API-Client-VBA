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
	[Guid("0F620B0F-26A0-4211-B56D-3287314FFF4E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIElementTemplate
	{
		[DispId(1)]
		PIElementTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("9935E0BD-59E3-44BE-98D4-4FEC821A9D3F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIElementTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIElementTemplate")]
	public class ApiResponsePIElementTemplate : ApiParentResponse, IApiResponsePIElementTemplate
	{
		public PIElementTemplate Data { get; set; }
		public ApiResponsePIElementTemplate(int statusCode, IDictionary<string, string> headers, PIElementTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
