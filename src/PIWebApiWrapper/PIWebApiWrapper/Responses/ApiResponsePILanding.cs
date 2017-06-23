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
	[Guid("ABD0F251-D2CD-4FD4-B354-89A7ADD8CB9D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePILanding
	{
		[DispId(1)]
		PILanding Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("F70F054F-7B9B-4A34-93E4-3B76F193EAD0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePILanding))]
	[ProgId("PIWebAPIWrapper.ApiResponsePILanding")]
	public class ApiResponsePILanding : ApiParentResponse, IApiResponsePILanding
	{
		public PILanding Data { get; set; }
		public ApiResponsePILanding(int statusCode, IDictionary<string, string> headers, PILanding data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
