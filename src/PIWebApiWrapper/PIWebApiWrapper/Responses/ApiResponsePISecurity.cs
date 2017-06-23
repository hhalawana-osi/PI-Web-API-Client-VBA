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
	[Guid("E28CB57E-B88E-47B6-B42E-6F602167AFB3")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePISecurity
	{
		[DispId(1)]
		PISecurity Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("245AFCD7-40E1-4DDD-8215-12CC4D3481EE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePISecurity))]
	[ProgId("PIWebAPIWrapper.ApiResponsePISecurity")]
	public class ApiResponsePISecurity : ApiParentResponse, IApiResponsePISecurity
	{
		public PISecurity Data { get; set; }
		public ApiResponsePISecurity(int statusCode, IDictionary<string, string> headers, PISecurity data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
