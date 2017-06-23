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
	[Guid("9E018665-764E-42C3-B90C-E7FDEFAB41C9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIVersion
	{
		[DispId(1)]
		PIVersion Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("D5BFCFB8-C3E5-4E90-AFBB-2E4936FFE4B9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIVersion))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIVersion")]
	public class ApiResponsePIVersion : ApiParentResponse, IApiResponsePIVersion
	{
		public PIVersion Data { get; set; }
		public ApiResponsePIVersion(int statusCode, IDictionary<string, string> headers, PIVersion data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
