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
	[Guid("877283DF-49AB-4D25-A62E-1EC4CC6D0450")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnalysisRulePlugIn
	{
		[DispId(1)]
		PIItemsAnalysisRulePlugIn Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("AB2F39CD-12C0-4895-BE20-630313D3C075")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnalysisRulePlugIn))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnalysisRulePlugIn")]
	public class ApiResponsePIItemsAnalysisRulePlugIn : ApiParentResponse, IApiResponsePIItemsAnalysisRulePlugIn
	{
		public PIItemsAnalysisRulePlugIn Data { get; set; }
		public ApiResponsePIItemsAnalysisRulePlugIn(int statusCode, IDictionary<string, string> headers, PIItemsAnalysisRulePlugIn data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
