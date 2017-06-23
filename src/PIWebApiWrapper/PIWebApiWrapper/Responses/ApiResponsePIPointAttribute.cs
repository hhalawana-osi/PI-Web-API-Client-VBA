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
	[Guid("22395517-1B83-4957-8998-C0A3D70EE55F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIPointAttribute
	{
		[DispId(1)]
		PIPointAttribute Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("387CA80C-F420-434A-B042-4A2BE28A7237")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIPointAttribute))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIPointAttribute")]
	public class ApiResponsePIPointAttribute : ApiParentResponse, IApiResponsePIPointAttribute
	{
		public PIPointAttribute Data { get; set; }
		public ApiResponsePIPointAttribute(int statusCode, IDictionary<string, string> headers, PIPointAttribute data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
