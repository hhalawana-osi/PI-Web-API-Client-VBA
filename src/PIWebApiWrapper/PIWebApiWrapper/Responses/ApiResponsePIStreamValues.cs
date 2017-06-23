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
	[Guid("32570CEC-E7D0-4CC6-A466-54A71BEA16F2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIStreamValues
	{
		[DispId(1)]
		PIStreamValues Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("938D5BAC-5188-49D0-BE0A-4C0F46770395")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIStreamValues))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIStreamValues")]
	public class ApiResponsePIStreamValues : ApiParentResponse, IApiResponsePIStreamValues
	{
		public PIStreamValues Data { get; set; }
		public ApiResponsePIStreamValues(int statusCode, IDictionary<string, string> headers, PIStreamValues data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
