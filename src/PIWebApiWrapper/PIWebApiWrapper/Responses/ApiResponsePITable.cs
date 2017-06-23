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
	[Guid("C302DBF2-39BA-43C5-9B69-38559B524EF0")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITable
	{
		[DispId(1)]
		PITable Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("5D70E59C-5A34-4C26-9EBE-E6E166B66E6D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITable))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITable")]
	public class ApiResponsePITable : ApiParentResponse, IApiResponsePITable
	{
		public PITable Data { get; set; }
		public ApiResponsePITable(int statusCode, IDictionary<string, string> headers, PITable data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
