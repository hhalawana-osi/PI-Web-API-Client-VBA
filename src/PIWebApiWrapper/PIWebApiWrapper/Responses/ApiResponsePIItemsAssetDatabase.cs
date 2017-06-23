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
	[Guid("4B374E85-5E49-4CFE-ADF1-3DE7BBA50582")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAssetDatabase
	{
		[DispId(1)]
		PIItemsAssetDatabase Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("74C5D79C-F27C-4658-B82A-2CE4938A9FAD")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAssetDatabase))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAssetDatabase")]
	public class ApiResponsePIItemsAssetDatabase : ApiParentResponse, IApiResponsePIItemsAssetDatabase
	{
		public PIItemsAssetDatabase Data { get; set; }
		public ApiResponsePIItemsAssetDatabase(int statusCode, IDictionary<string, string> headers, PIItemsAssetDatabase data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
