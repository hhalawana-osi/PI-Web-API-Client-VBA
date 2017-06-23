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
	[Guid("1EB031D5-F787-4541-80A0-B86E19BEA654")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAttribute
	{
		[DispId(1)]
		PIItemsAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("433D33F1-CC19-42B6-957C-5648BD31E3A3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAttribute")]
	public class ApiResponsePIItemsAttribute : ApiParentResponse, IApiResponsePIItemsAttribute
	{
		public PIItemsAttribute Data { get; set; }
		public ApiResponsePIItemsAttribute(int statusCode, IDictionary<string, string> headers, PIItemsAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
