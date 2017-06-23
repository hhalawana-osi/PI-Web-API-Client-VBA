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
	[Guid("3E87CB2F-8F19-46AC-8091-26935C06FAF0")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIEnumerationValue
	{
		[DispId(1)]
		PIEnumerationValue Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("9E11E611-7EE5-4C09-B2CE-5AAE92F33338")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIEnumerationValue))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIEnumerationValue")]
	public class ApiResponsePIEnumerationValue : ApiParentResponse, IApiResponsePIEnumerationValue
	{
		public PIEnumerationValue Data { get; set; }
		public ApiResponsePIEnumerationValue(int statusCode, IDictionary<string, string> headers, PIEnumerationValue data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
