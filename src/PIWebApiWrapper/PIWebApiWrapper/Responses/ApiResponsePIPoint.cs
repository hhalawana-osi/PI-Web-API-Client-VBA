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
	[Guid("3320A0F9-098D-4228-97D9-316C562A2B8D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIPoint
	{
		[DispId(1)]
		PIPoint Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("6DD6ED34-7E7A-42C4-9D2F-837077D3B22B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIPoint))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIPoint")]
	public class ApiResponsePIPoint : ApiParentResponse, IApiResponsePIPoint
	{
		public PIPoint Data { get; set; }
		public ApiResponsePIPoint(int statusCode, IDictionary<string, string> headers, PIPoint data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
