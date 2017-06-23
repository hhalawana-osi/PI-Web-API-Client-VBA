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
	[Guid("B456F82C-E417-4061-B149-A8DB3FC29C30")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAssetDatabase
	{
		[DispId(1)]
		PIAssetDatabase Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E2CDC094-67B6-43C6-BE43-E3CC1C90FE3C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAssetDatabase))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAssetDatabase")]
	public class ApiResponsePIAssetDatabase : ApiParentResponse, IApiResponsePIAssetDatabase
	{
		public PIAssetDatabase Data { get; set; }
		public ApiResponsePIAssetDatabase(int statusCode, IDictionary<string, string> headers, PIAssetDatabase data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
