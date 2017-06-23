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
	[Guid("6555E521-034A-47C3-98C5-5E59E5E67C73")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsStreamValue
	{
		[DispId(1)]
		PIItemsStreamValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("F7596E27-C76E-4A24-9959-91BC50114C95")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsStreamValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsStreamValue")]
	public class ApiResponsePIItemsStreamValue : ApiParentResponse, IApiResponsePIItemsStreamValue
	{
		public PIItemsStreamValue Data { get; set; }
		public ApiResponsePIItemsStreamValue(int statusCode, IDictionary<string, string> headers, PIItemsStreamValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
