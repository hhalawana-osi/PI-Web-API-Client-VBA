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
	[Guid("FE2F217E-8443-401D-B404-18C7C471FBF5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePICacheInstance
	{
		[DispId(1)]
		PICacheInstance Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("E5A38AE3-0037-4E75-A5D7-AE652C2C9CBE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePICacheInstance))]
	[ProgId("PIWebAPIWrapper.ApiResponsePICacheInstance")]
	public class ApiResponsePICacheInstance : ApiParentResponse, IApiResponsePICacheInstance
	{
		public PICacheInstance Data { get; set; }
		public ApiResponsePICacheInstance(int statusCode, IDictionary<string, string> headers, PICacheInstance data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
