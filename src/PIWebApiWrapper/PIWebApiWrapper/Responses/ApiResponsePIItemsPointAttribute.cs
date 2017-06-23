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
	[Guid("FADE7B09-69BA-435A-A69A-BDA52F30F7E0")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsPointAttribute
	{
		[DispId(1)]
		PIItemsPointAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("9257955A-62B4-49CF-8D10-ADD034E79FAC")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsPointAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsPointAttribute")]
	public class ApiResponsePIItemsPointAttribute : ApiParentResponse, IApiResponsePIItemsPointAttribute
	{
		public PIItemsPointAttribute Data { get; set; }
		public ApiResponsePIItemsPointAttribute(int statusCode, IDictionary<string, string> headers, PIItemsPointAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
