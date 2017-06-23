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
	[Guid("651518F0-32E8-45F2-844A-4C863329A183")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsCacheInstance
	{
		[DispId(1)]
		PIItemsCacheInstance Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("B6D7A7B1-48D7-4FC1-83B9-30DBDC578B1A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsCacheInstance))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsCacheInstance")]
	public class ApiResponsePIItemsCacheInstance : ApiParentResponse, IApiResponsePIItemsCacheInstance
	{
		public PIItemsCacheInstance Data { get; set; }
		public ApiResponsePIItemsCacheInstance(int statusCode, IDictionary<string, string> headers, PIItemsCacheInstance data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
