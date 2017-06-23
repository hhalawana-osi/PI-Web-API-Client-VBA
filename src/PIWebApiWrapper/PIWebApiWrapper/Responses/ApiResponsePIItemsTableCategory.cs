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
	[Guid("55DECBD8-9C62-4030-A0CD-B05EAA7B2127")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsTableCategory
	{
		[DispId(1)]
		PIItemsTableCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("860E34C2-12E0-4035-9DB7-E28C7C57EE8D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsTableCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsTableCategory")]
	public class ApiResponsePIItemsTableCategory : ApiParentResponse, IApiResponsePIItemsTableCategory
	{
		public PIItemsTableCategory Data { get; set; }
		public ApiResponsePIItemsTableCategory(int statusCode, IDictionary<string, string> headers, PIItemsTableCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
