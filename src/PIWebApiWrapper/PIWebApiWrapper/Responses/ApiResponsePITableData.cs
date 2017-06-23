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
	[Guid("284A39C9-17C6-4ACC-89C2-F0D910566F46")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePITableData
	{
		[DispId(1)]
		PITableData Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("316EA7A4-C1F2-4C9F-ACEA-83F84362A128")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePITableData))]
	[ProgId("PIWebAPIWrapper.ApiResponsePITableData")]
	public class ApiResponsePITableData : ApiParentResponse, IApiResponsePITableData
	{
		public PITableData Data { get; set; }
		public ApiResponsePITableData(int statusCode, IDictionary<string, string> headers, PITableData data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
