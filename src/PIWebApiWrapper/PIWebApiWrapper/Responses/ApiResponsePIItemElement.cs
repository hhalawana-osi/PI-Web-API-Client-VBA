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
	[Guid("ED47345B-1290-4899-B240-C54FFC1DE7A2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemElement
	{
		[DispId(1)]
		PIItemElement Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("75EA80A1-5786-4C4D-AB88-2C7CA7A4FD9E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemElement))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemElement")]
	public class ApiResponsePIItemElement : ApiParentResponse, IApiResponsePIItemElement
	{
		public PIItemElement Data { get; set; }
		public ApiResponsePIItemElement(int statusCode, IDictionary<string, string> headers, PIItemElement data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
