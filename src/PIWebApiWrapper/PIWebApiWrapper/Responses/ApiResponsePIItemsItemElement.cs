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
	[Guid("5FEFD798-3217-44C8-941E-E7BCBC7937DB")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsItemElement
	{
		[DispId(1)]
		PIItemsItemElement Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("35545E2E-D553-472F-80EB-663B80EE2C3C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsItemElement))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsItemElement")]
	public class ApiResponsePIItemsItemElement : ApiParentResponse, IApiResponsePIItemsItemElement
	{
		public PIItemsItemElement Data { get; set; }
		public ApiResponsePIItemsItemElement(int statusCode, IDictionary<string, string> headers, PIItemsItemElement data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
