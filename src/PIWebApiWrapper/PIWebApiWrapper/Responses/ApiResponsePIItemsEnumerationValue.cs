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
	[Guid("856D85ED-9F77-4753-BBD8-B9A829BF8F19")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsEnumerationValue
	{
		[DispId(1)]
		PIItemsEnumerationValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E80D4C76-CDE4-4700-9FA7-9624573A53AE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsEnumerationValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsEnumerationValue")]
	public class ApiResponsePIItemsEnumerationValue : ApiParentResponse, IApiResponsePIItemsEnumerationValue
	{
		public PIItemsEnumerationValue Data { get; set; }
		public ApiResponsePIItemsEnumerationValue(int statusCode, IDictionary<string, string> headers, PIItemsEnumerationValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
