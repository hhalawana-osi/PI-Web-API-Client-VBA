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
	[Guid("7FDE6004-D13E-40A8-B661-21BBEC27F43A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIRequestTemplate
	{
		[DispId(1)]
		PIRequestTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E6DBA5E2-BF98-4226-8E4D-1D2E085A5BDC")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIRequestTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIRequestTemplate")]
	public class ApiResponsePIRequestTemplate : ApiParentResponse, IApiResponsePIRequestTemplate
	{
		public PIRequestTemplate Data { get; set; }
		public ApiResponsePIRequestTemplate(int statusCode, IDictionary<string, string> headers, PIRequestTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
