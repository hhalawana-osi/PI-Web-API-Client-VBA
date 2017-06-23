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
	[Guid("733848B6-7D52-4001-B746-ADBA7355ACF6")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIUserInfo
	{
		[DispId(1)]
		PIUserInfo Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("5DDF08C4-743B-4A6B-B89F-06C7F271B049")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIUserInfo))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIUserInfo")]
	public class ApiResponsePIUserInfo : ApiParentResponse, IApiResponsePIUserInfo
	{
		public PIUserInfo Data { get; set; }
		public ApiResponsePIUserInfo(int statusCode, IDictionary<string, string> headers, PIUserInfo data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
