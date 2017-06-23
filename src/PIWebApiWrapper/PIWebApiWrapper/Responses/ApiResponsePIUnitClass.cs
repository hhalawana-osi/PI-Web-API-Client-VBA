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
	[Guid("9430C231-AA22-483A-8021-8E1605AD2D61")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIUnitClass
	{
		[DispId(1)]
		PIUnitClass Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("4D260777-267B-4B75-ACCE-E1C232AF7FD3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIUnitClass))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIUnitClass")]
	public class ApiResponsePIUnitClass : ApiParentResponse, IApiResponsePIUnitClass
	{
		public PIUnitClass Data { get; set; }
		public ApiResponsePIUnitClass(int statusCode, IDictionary<string, string> headers, PIUnitClass data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
