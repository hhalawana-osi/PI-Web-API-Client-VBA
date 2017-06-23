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
	[Guid("7E7D32BF-B0EB-45A9-96A7-89AC31B955F5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityRights
	{
		[DispId(1)]
		PISecurityRights Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B769803D-F60A-44FE-A811-E1DBA13542AF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityRights))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityRights")]
	public class ApiResponsePISecurityRights : ApiParentResponse, IApiResponsePISecurityRights
	{
		public PISecurityRights Data { get; set; }
		public ApiResponsePISecurityRights(int statusCode, IDictionary<string, string> headers, PISecurityRights data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
