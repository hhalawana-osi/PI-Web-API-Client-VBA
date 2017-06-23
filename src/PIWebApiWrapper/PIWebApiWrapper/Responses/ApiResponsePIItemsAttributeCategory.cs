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
	[Guid("CF0632E7-263C-4807-B53C-7F9180035BA0")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAttributeCategory
	{
		[DispId(1)]
		PIItemsAttributeCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("967E448E-DA79-47E2-BA34-A8BCF966C57F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAttributeCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAttributeCategory")]
	public class ApiResponsePIItemsAttributeCategory : ApiParentResponse, IApiResponsePIItemsAttributeCategory
	{
		public PIItemsAttributeCategory Data { get; set; }
		public ApiResponsePIItemsAttributeCategory(int statusCode, IDictionary<string, string> headers, PIItemsAttributeCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
