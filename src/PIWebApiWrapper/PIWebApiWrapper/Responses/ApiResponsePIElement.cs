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
	[Guid("10A47F19-0928-4FD8-A266-83DD398433FA")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIElement
	{
		[DispId(1)]
		PIElement Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("1DBDCC11-4374-4463-8FCF-B25AA2DA1E9B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIElement))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIElement")]
	public class ApiResponsePIElement : ApiParentResponse, IApiResponsePIElement
	{
		public PIElement Data { get; set; }
		public ApiResponsePIElement(int statusCode, IDictionary<string, string> headers, PIElement data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
