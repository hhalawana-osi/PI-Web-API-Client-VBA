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
	[Guid("05828E3F-395D-49A8-BA6D-3343A90273D9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITimedValues
	{
		[DispId(1)]
		PITimedValues Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("2F5C04F3-A1C5-4059-B5ED-2FCF26F3A689")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITimedValues))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITimedValues")]
	public class ApiResponsePITimedValues : ApiParentResponse, IApiResponsePITimedValues
	{
		public PITimedValues Data { get; set; }
		public ApiResponsePITimedValues(int statusCode, IDictionary<string, string> headers, PITimedValues data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
