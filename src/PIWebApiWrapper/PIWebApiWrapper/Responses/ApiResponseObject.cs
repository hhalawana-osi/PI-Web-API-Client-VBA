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
	[Guid("EEEFC80F-4585-4DB3-8279-B7A16E63A79E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponseObject
	{
		[DispId(1)]
		Object Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E10D8A9A-1714-40BE-B8F5-A43AE0E958EA")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponseObject))]
	[ProgId("PIWebAPIWrapper.ApiResponseObject")]
	public class ApiResponseObject : ApiParentResponse, IApiResponseObject
	{
		public Object Data { get; set; }
		public ApiResponseObject(int statusCode, IDictionary<string, string> headers, Object data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
