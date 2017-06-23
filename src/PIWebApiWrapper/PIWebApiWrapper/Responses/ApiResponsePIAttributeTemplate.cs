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
	[Guid("51B49852-7A1A-4182-A8A9-8F3B3B209728")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAttributeTemplate
	{
		[DispId(1)]
		PIAttributeTemplate Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("D777C057-599A-4B69-BE48-4A14219B9C53")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAttributeTemplate))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAttributeTemplate")]
	public class ApiResponsePIAttributeTemplate : ApiParentResponse, IApiResponsePIAttributeTemplate
	{
		public PIAttributeTemplate Data { get; set; }
		public ApiResponsePIAttributeTemplate(int statusCode, IDictionary<string, string> headers, PIAttributeTemplate data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
