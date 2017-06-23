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
	[Guid("CF7B0674-D791-45FE-B10A-C19C12203E39")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsTimeRulePlugIn
	{
		[DispId(1)]
		PIItemsTimeRulePlugIn Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("3095B256-F262-4028-87BB-AFB0B49F7828")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsTimeRulePlugIn))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsTimeRulePlugIn")]
	public class ApiResponsePIItemsTimeRulePlugIn : ApiParentResponse, IApiResponsePIItemsTimeRulePlugIn
	{
		public PIItemsTimeRulePlugIn Data { get; set; }
		public ApiResponsePIItemsTimeRulePlugIn(int statusCode, IDictionary<string, string> headers, PIItemsTimeRulePlugIn data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
