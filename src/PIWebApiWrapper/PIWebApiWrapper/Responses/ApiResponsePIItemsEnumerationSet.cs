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
	[Guid("1DCDF1B1-F58F-48BE-933C-C11AC8964E13")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsEnumerationSet
	{
		[DispId(1)]
		PIItemsEnumerationSet Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("D6805CB6-FD50-41B1-8C99-657DE9FE0F4C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsEnumerationSet))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsEnumerationSet")]
	public class ApiResponsePIItemsEnumerationSet : ApiParentResponse, IApiResponsePIItemsEnumerationSet
	{
		public PIItemsEnumerationSet Data { get; set; }
		public ApiResponsePIItemsEnumerationSet(int statusCode, IDictionary<string, string> headers, PIItemsEnumerationSet data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
