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
	[Guid("3AEF50A6-D919-4548-91D9-C31E67C98FB7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsItemAttribute
	{
		[DispId(1)]
		PIItemsItemAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("2D570778-48ED-444F-A06A-16E90853720D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsItemAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsItemAttribute")]
	public class ApiResponsePIItemsItemAttribute : ApiParentResponse, IApiResponsePIItemsItemAttribute
	{
		public PIItemsItemAttribute Data { get; set; }
		public ApiResponsePIItemsItemAttribute(int statusCode, IDictionary<string, string> headers, PIItemsItemAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
