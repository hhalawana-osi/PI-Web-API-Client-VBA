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
	[Guid("D28281EB-784D-4F98-A171-7C1B411276F4")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsAttributeTrait
	{
		[DispId(1)]
		PIItemsAttributeTrait Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("3530D587-7181-452A-B37B-FF8852B3DDCE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsAttributeTrait))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsAttributeTrait")]
	public class ApiResponsePIItemsAttributeTrait : ApiParentResponse, IApiResponsePIItemsAttributeTrait
	{
		public PIItemsAttributeTrait Data { get; set; }
		public ApiResponsePIItemsAttributeTrait(int statusCode, IDictionary<string, string> headers, PIItemsAttributeTrait data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
