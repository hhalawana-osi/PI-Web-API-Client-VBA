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
	[Guid("D3DB3821-D026-4830-BB38-6A62E9B3FFF9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysisRule
	{
		[DispId(1)]
		PIAnalysisRule Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B3D4F998-8EC0-4DF5-933F-297FDDE72305")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysisRule))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysisRule")]
	public class ApiResponsePIAnalysisRule : ApiParentResponse, IApiResponsePIAnalysisRule
	{
		public PIAnalysisRule Data { get; set; }
		public ApiResponsePIAnalysisRule(int statusCode, IDictionary<string, string> headers, PIAnalysisRule data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
