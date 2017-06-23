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
	[Guid("DDD9EA2B-BFC8-4DA2-9CF6-81E29EE54982")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysis
	{
		[DispId(1)]
		PIAnalysis Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("F2191C49-28C3-4781-80DC-A44BA5A0CDEB")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysis))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysis")]
	public class ApiResponsePIAnalysis : ApiParentResponse, IApiResponsePIAnalysis
	{
		public PIAnalysis Data { get; set; }
		public ApiResponsePIAnalysis(int statusCode, IDictionary<string, string> headers, PIAnalysis data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
