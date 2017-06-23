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
	[Guid("AB566829-F4E8-4E6C-9580-26F1480FE78E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsItemsSubstatus
	{
		[DispId(1)]
		PIItemsItemsSubstatus Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("A05960B3-F18D-4FDC-9804-B80E17860373")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsItemsSubstatus))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsItemsSubstatus")]
	public class ApiResponsePIItemsItemsSubstatus : ApiParentResponse, IApiResponsePIItemsItemsSubstatus
	{
		public PIItemsItemsSubstatus Data { get; set; }
		public ApiResponsePIItemsItemsSubstatus(int statusCode, IDictionary<string, string> headers, PIItemsItemsSubstatus data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
