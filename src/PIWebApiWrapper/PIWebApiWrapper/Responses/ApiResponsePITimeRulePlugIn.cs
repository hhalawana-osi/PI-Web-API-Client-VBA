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
	[Guid("CC04A9BE-E47B-480E-B8D0-70B8E704CE01")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITimeRulePlugIn
	{
		[DispId(1)]
		PITimeRulePlugIn Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("93ECFB61-56CA-47F4-ACC1-F8B348ED5F33")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITimeRulePlugIn))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITimeRulePlugIn")]
	public class ApiResponsePITimeRulePlugIn : ApiParentResponse, IApiResponsePITimeRulePlugIn
	{
		public PITimeRulePlugIn Data { get; set; }
		public ApiResponsePITimeRulePlugIn(int statusCode, IDictionary<string, string> headers, PITimeRulePlugIn data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
