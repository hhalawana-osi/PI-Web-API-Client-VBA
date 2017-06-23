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
	[Guid("F92DC3BC-B97C-4D65-9400-1D3B5486C921")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsElement
	{
		[DispId(1)]
		PIItemsElement Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B966FFE6-3407-4B06-876C-E4EDEED3F321")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsElement))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsElement")]
	public class ApiResponsePIItemsElement : ApiParentResponse, IApiResponsePIItemsElement
	{
		public PIItemsElement Data { get; set; }
		public ApiResponsePIItemsElement(int statusCode, IDictionary<string, string> headers, PIItemsElement data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
