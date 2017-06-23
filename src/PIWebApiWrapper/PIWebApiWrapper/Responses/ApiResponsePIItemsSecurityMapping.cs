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
	[Guid("5CADB392-24A3-4383-A68C-B6D09B14583E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsSecurityMapping
	{
		[DispId(1)]
		PIItemsSecurityMapping Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("5B4704EC-2B20-438D-BC86-278E1A6D790A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsSecurityMapping))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsSecurityMapping")]
	public class ApiResponsePIItemsSecurityMapping : ApiParentResponse, IApiResponsePIItemsSecurityMapping
	{
		public PIItemsSecurityMapping Data { get; set; }
		public ApiResponsePIItemsSecurityMapping(int statusCode, IDictionary<string, string> headers, PIItemsSecurityMapping data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
