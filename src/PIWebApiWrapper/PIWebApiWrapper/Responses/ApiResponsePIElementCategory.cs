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
	[Guid("225AC2BF-360F-4347-A717-500EFEB041B9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIElementCategory
	{
		[DispId(1)]
		PIElementCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("FB098250-7B87-4B70-B913-80DB48A6E111")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIElementCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIElementCategory")]
	public class ApiResponsePIElementCategory : ApiParentResponse, IApiResponsePIElementCategory
	{
		public PIElementCategory Data { get; set; }
		public ApiResponsePIElementCategory(int statusCode, IDictionary<string, string> headers, PIElementCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
