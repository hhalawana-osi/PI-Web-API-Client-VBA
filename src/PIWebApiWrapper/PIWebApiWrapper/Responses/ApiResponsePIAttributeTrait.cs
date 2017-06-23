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
	[Guid("28C2ACEC-F341-4417-82FC-2B9816FC1F6F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeTrait
	{
		[DispId(1)]
		PIAttributeTrait Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("0CBA6F22-0E40-44FC-A75C-FCEA391D4B7C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeTrait))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeTrait")]
	public class ApiResponsePIAttributeTrait : ApiParentResponse, IApiResponsePIAttributeTrait
	{
		public PIAttributeTrait Data { get; set; }
		public ApiResponsePIAttributeTrait(int statusCode, IDictionary<string, string> headers, PIAttributeTrait data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
