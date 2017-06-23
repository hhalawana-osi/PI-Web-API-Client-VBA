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
	[Guid("B0BAA79B-ABF7-4CFA-A4F3-D33356BFBDCF")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsItemPoint
	{
		[DispId(1)]
		PIItemsItemPoint Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("BA589B75-62D8-4109-B21F-6DF9914AB00A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsItemPoint))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsItemPoint")]
	public class ApiResponsePIItemsItemPoint : ApiParentResponse, IApiResponsePIItemsItemPoint
	{
		public PIItemsItemPoint Data { get; set; }
		public ApiResponsePIItemsItemPoint(int statusCode, IDictionary<string, string> headers, PIItemsItemPoint data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
