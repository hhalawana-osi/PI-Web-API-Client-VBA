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
	[Guid("DDCAE5D0-75A0-4CBA-BA88-A00CA4D5DC6A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAttributeTemplate
	{
		[DispId(1)]
		PIItemsAttributeTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("3EAEA40B-977D-4318-967F-2712B84EDE58")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAttributeTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAttributeTemplate")]
	public class ApiResponsePIItemsAttributeTemplate : ApiParentResponse, IApiResponsePIItemsAttributeTemplate
	{
		public PIItemsAttributeTemplate Data { get; set; }
		public ApiResponsePIItemsAttributeTemplate(int statusCode, IDictionary<string, string> headers, PIItemsAttributeTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
