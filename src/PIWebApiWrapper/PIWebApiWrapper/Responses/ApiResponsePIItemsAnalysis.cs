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
	[Guid("06AFAF8E-B6C2-4DEA-9B34-2A9AB955FB8D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAnalysis
	{
		[DispId(1)]
		PIItemsAnalysis Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("D036DD15-5A78-48A1-8C36-13998A21F736")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAnalysis))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAnalysis")]
	public class ApiResponsePIItemsAnalysis : ApiParentResponse, IApiResponsePIItemsAnalysis
	{
		public PIItemsAnalysis Data { get; set; }
		public ApiResponsePIItemsAnalysis(int statusCode, IDictionary<string, string> headers, PIItemsAnalysis data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
