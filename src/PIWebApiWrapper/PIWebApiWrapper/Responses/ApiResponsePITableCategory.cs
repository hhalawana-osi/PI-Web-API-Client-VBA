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
	[Guid("67AECD53-29E4-4925-8DC6-5C6F1B9E1770")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITableCategory
	{
		[DispId(1)]
		PITableCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("F769A001-DE16-4DF5-9936-7461B89723E9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITableCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITableCategory")]
	public class ApiResponsePITableCategory : ApiParentResponse, IApiResponsePITableCategory
	{
		public PITableCategory Data { get; set; }
		public ApiResponsePITableCategory(int statusCode, IDictionary<string, string> headers, PITableCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
