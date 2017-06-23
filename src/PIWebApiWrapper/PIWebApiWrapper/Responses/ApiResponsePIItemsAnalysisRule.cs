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
	[Guid("3C2E690E-DFC7-4380-B869-F61B14D5611D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnalysisRule
	{
		[DispId(1)]
		PIItemsAnalysisRule Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("26A61A81-BB1F-4282-A6F2-69354AC5472A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnalysisRule))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnalysisRule")]
	public class ApiResponsePIItemsAnalysisRule : ApiParentResponse, IApiResponsePIItemsAnalysisRule
	{
		public PIItemsAnalysisRule Data { get; set; }
		public ApiResponsePIItemsAnalysisRule(int statusCode, IDictionary<string, string> headers, PIItemsAnalysisRule data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
