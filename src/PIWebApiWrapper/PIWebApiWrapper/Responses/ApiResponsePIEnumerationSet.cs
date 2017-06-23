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
	[Guid("3A9CAF70-84D4-40AE-97EA-859DBD958A75")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIEnumerationSet
	{
		[DispId(1)]
		PIEnumerationSet Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("0A9953B5-263E-4B79-92D4-2D91FADE1F15")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIEnumerationSet))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIEnumerationSet")]
	public class ApiResponsePIEnumerationSet : ApiParentResponse, IApiResponsePIEnumerationSet
	{
		public PIEnumerationSet Data { get; set; }
		public ApiResponsePIEnumerationSet(int statusCode, IDictionary<string, string> headers, PIEnumerationSet data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
