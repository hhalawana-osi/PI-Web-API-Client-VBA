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
	[Guid("E8C64345-EED6-4573-A28C-7335E2D2982F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIAnnotation
	{
		[DispId(1)]
		PIAnnotation Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("19F487CE-1791-420B-90C2-C469E77A0F1E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIAnnotation))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIAnnotation")]
	public class ApiResponsePIAnnotation : ApiParentResponse, IApiResponsePIAnnotation
	{
		public PIAnnotation Data { get; set; }
		public ApiResponsePIAnnotation(int statusCode, IDictionary<string, string> headers, PIAnnotation data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
