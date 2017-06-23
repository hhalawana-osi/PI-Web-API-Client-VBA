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
	[Guid("70D851BF-6E01-45C0-B604-BB9D4E394A76")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSecurityIdentity
	{
		[DispId(1)]
		PIItemsSecurityIdentity Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("AAD55D6C-5AB7-4D14-B004-AA347933B307")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSecurityIdentity))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSecurityIdentity")]
	public class ApiResponsePIItemsSecurityIdentity : ApiParentResponse, IApiResponsePIItemsSecurityIdentity
	{
		public PIItemsSecurityIdentity Data { get; set; }
		public ApiResponsePIItemsSecurityIdentity(int statusCode, IDictionary<string, string> headers, PIItemsSecurityIdentity data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
