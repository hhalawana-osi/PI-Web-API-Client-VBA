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
	[Guid("526C0082-6415-4727-BDCB-3BDFF8240407")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsElementTemplate
	{
		[DispId(1)]
		PIItemsElementTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("D1BDB88D-CD72-4286-B1C4-179FFC839E8B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsElementTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsElementTemplate")]
	public class ApiResponsePIItemsElementTemplate : ApiParentResponse, IApiResponsePIItemsElementTemplate
	{
		public PIItemsElementTemplate Data { get; set; }
		public ApiResponsePIItemsElementTemplate(int statusCode, IDictionary<string, string> headers, PIItemsElementTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
