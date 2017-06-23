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
	[Guid("F47C08E5-D97F-4CB3-B24B-9F4FBB5ED585")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISubstatus
	{
		[DispId(1)]
		PISubstatus Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B61228E4-4E3E-4A29-A310-C33D6F797416")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISubstatus))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISubstatus")]
	public class ApiResponsePISubstatus : ApiParentResponse, IApiResponsePISubstatus
	{
		public PISubstatus Data { get; set; }
		public ApiResponsePISubstatus(int statusCode, IDictionary<string, string> headers, PISubstatus data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
