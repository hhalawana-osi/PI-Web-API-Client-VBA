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
	[Guid("05FC97C0-B85A-4B39-837B-F4268504C863")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsDataServer
	{
		[DispId(1)]
		PIItemsDataServer Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("4EA9AA47-DA64-4EF3-9A7C-6E650E4F6F17")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsDataServer))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsDataServer")]
	public class ApiResponsePIItemsDataServer : ApiParentResponse, IApiResponsePIItemsDataServer
	{
		public PIItemsDataServer Data { get; set; }
		public ApiResponsePIItemsDataServer(int statusCode, IDictionary<string, string> headers, PIItemsDataServer data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
