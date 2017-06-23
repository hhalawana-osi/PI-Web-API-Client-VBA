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
	[Guid("2FAC79BF-5E3D-4ECF-9F87-8952EAE5B31F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsStreamValues
	{
		[DispId(1)]
		PIItemsStreamValues Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("518F3884-9CA2-4D35-B843-2FED456D7A38")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsStreamValues))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsStreamValues")]
	public class ApiResponsePIItemsStreamValues : ApiParentResponse, IApiResponsePIItemsStreamValues
	{
		public PIItemsStreamValues Data { get; set; }
		public ApiResponsePIItemsStreamValues(int statusCode, IDictionary<string, string> headers, PIItemsStreamValues data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
