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
	[Guid("7481C72F-B2E4-4C89-89ED-12C8C03371BB")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsTable
	{
		[DispId(1)]
		PIItemsTable Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("19997547-6A6D-4784-86D6-A53C52A007AD")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsTable))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsTable")]
	public class ApiResponsePIItemsTable : ApiParentResponse, IApiResponsePIItemsTable
	{
		public PIItemsTable Data { get; set; }
		public ApiResponsePIItemsTable(int statusCode, IDictionary<string, string> headers, PIItemsTable data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
