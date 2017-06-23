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
	[Guid("500A2D03-0C9C-4C02-A530-E5A41088084A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysisTemplate
	{
		[DispId(1)]
		PIAnalysisTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("9044E22E-85BB-4D4A-B8A5-EE60EFD61161")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysisTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysisTemplate")]
	public class ApiResponsePIAnalysisTemplate : ApiParentResponse, IApiResponsePIAnalysisTemplate
	{
		public PIAnalysisTemplate Data { get; set; }
		public ApiResponsePIAnalysisTemplate(int statusCode, IDictionary<string, string> headers, PIAnalysisTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
