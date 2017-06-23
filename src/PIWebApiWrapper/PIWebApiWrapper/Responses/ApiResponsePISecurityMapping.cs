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
	[Guid("F8F02C47-2F14-49EA-9AA5-7BBA6D55F2EF")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurityMapping
	{
		[DispId(1)]
		PISecurityMapping Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("140EC93D-EEC3-4F06-8F6C-44B377C691EE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurityMapping))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurityMapping")]
	public class ApiResponsePISecurityMapping : ApiParentResponse, IApiResponsePISecurityMapping
	{
		public PISecurityMapping Data { get; set; }
		public ApiResponsePISecurityMapping(int statusCode, IDictionary<string, string> headers, PISecurityMapping data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
