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
	[Guid("22E1DB65-7173-42FB-B497-C6C84C28C39A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSecurityEntry
	{
		[DispId(1)]
		PIItemsSecurityEntry Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("C9460706-0788-406E-9B4A-177FF992F8F1")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSecurityEntry))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSecurityEntry")]
	public class ApiResponsePIItemsSecurityEntry : ApiParentResponse, IApiResponsePIItemsSecurityEntry
	{
		public PIItemsSecurityEntry Data { get; set; }
		public ApiResponsePIItemsSecurityEntry(int statusCode, IDictionary<string, string> headers, PIItemsSecurityEntry data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
