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
	[Guid("CDBD6B1E-4068-4DB9-8E9D-A9A44977A84C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnnotation
	{
		[DispId(1)]
		PIItemsAnnotation Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("48B7D761-4548-4C43-9D5F-AB04C2376EC5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnnotation))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnnotation")]
	public class ApiResponsePIItemsAnnotation : ApiParentResponse, IApiResponsePIItemsAnnotation
	{
		public PIItemsAnnotation Data { get; set; }
		public ApiResponsePIItemsAnnotation(int statusCode, IDictionary<string, string> headers, PIItemsAnnotation data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
