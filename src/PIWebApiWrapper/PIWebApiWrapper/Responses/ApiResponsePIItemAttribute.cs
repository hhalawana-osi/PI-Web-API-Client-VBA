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
	[Guid("1FB6FB6A-5701-4FE3-839A-C7897C995DD1")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemAttribute
	{
		[DispId(1)]
		PIItemAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("43364B4A-D023-4CC0-832F-6C27187A4CFD")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemAttribute")]
	public class ApiResponsePIItemAttribute : ApiParentResponse, IApiResponsePIItemAttribute
	{
		public PIItemAttribute Data { get; set; }
		public ApiResponsePIItemAttribute(int statusCode, IDictionary<string, string> headers, PIItemAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
