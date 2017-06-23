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
	[Guid("0C579730-8135-4EF2-B276-E777F18890E5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSubstatus
	{
		[DispId(1)]
		PIItemsSubstatus Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("D195E972-CA64-4677-8C22-155035A02A5D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSubstatus))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSubstatus")]
	public class ApiResponsePIItemsSubstatus : ApiParentResponse, IApiResponsePIItemsSubstatus
	{
		public PIItemsSubstatus Data { get; set; }
		public ApiResponsePIItemsSubstatus(int statusCode, IDictionary<string, string> headers, PIItemsSubstatus data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
