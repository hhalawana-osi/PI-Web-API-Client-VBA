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
	[Guid("1ECA8784-8089-459A-9B07-C122F697502F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnalysisRulePlugIn
	{
		[DispId(1)]
		PIAnalysisRulePlugIn Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("3DB150A7-E67D-4F5B-9633-FFCDD7E91DA3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnalysisRulePlugIn))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnalysisRulePlugIn")]
	public class ApiResponsePIAnalysisRulePlugIn : ApiParentResponse, IApiResponsePIAnalysisRulePlugIn
	{
		public PIAnalysisRulePlugIn Data { get; set; }
		public ApiResponsePIAnalysisRulePlugIn(int statusCode, IDictionary<string, string> headers, PIAnalysisRulePlugIn data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
