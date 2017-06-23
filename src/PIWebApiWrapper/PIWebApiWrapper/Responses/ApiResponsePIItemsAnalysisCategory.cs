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
	[Guid("4EE05FFF-8804-4425-88CB-05136BFE45A2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnalysisCategory
	{
		[DispId(1)]
		PIItemsAnalysisCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("33DFAFAA-61E7-4B39-BF57-83447BFEF430")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnalysisCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnalysisCategory")]
	public class ApiResponsePIItemsAnalysisCategory : ApiParentResponse, IApiResponsePIItemsAnalysisCategory
	{
		public PIItemsAnalysisCategory Data { get; set; }
		public ApiResponsePIItemsAnalysisCategory(int statusCode, IDictionary<string, string> headers, PIItemsAnalysisCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
