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
	[Guid("D6FECB94-F392-4B39-B935-C7AF174E581A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsElementCategory
	{
		[DispId(1)]
		PIItemsElementCategory Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("263975B0-0AAC-4D44-BE13-5437F83F04A9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsElementCategory))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsElementCategory")]
	public class ApiResponsePIItemsElementCategory : ApiParentResponse, IApiResponsePIItemsElementCategory
	{
		public PIItemsElementCategory Data { get; set; }
		public ApiResponsePIItemsElementCategory(int statusCode, IDictionary<string, string> headers, PIItemsElementCategory data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
