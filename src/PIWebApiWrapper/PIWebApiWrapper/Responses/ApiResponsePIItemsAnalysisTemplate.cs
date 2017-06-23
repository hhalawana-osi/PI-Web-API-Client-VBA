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
	[Guid("DB27BCAD-DCF5-41C4-8330-258A3B9EFFDC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnalysisTemplate
	{
		[DispId(1)]
		PIItemsAnalysisTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("D027C70F-ED18-4E61-A955-5CC35F5A99D7")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnalysisTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnalysisTemplate")]
	public class ApiResponsePIItemsAnalysisTemplate : ApiParentResponse, IApiResponsePIItemsAnalysisTemplate
	{
		public PIItemsAnalysisTemplate Data { get; set; }
		public ApiResponsePIItemsAnalysisTemplate(int statusCode, IDictionary<string, string> headers, PIItemsAnalysisTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
