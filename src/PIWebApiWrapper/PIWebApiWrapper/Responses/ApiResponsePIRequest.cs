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
	[Guid("F8850B46-5DD3-468D-866A-96D044C5BFD4")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIRequest
	{
		[DispId(1)]
		PIRequest Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("0094F807-EF8B-4DE4-A225-D0AB4744BBF9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIRequest))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIRequest")]
	public class ApiResponsePIRequest : ApiParentResponse, IApiResponsePIRequest
	{
		public PIRequest Data { get; set; }
		public ApiResponsePIRequest(int statusCode, IDictionary<string, string> headers, PIRequest data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
