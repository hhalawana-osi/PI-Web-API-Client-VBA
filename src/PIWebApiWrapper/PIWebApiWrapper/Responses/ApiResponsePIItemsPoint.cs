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
	[Guid("19939892-4D29-4CCE-A625-0A52AEF0AC34")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IApiResponsePIItemsPoint
	{
		[DispId(1)]
		PIItemsPoint Data { get; set; }
	
		[DispId(2)]
		int StatusCode { get; set; }
	}

	[Guid("127B2A6F-8428-43BD-885F-1C415196C990")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IApiResponsePIItemsPoint))]
	[ProgId("PIWebAPIWrapper.ApiResponsePIItemsPoint")]
	public class ApiResponsePIItemsPoint : ApiParentResponse, IApiResponsePIItemsPoint
	{
		public PIItemsPoint Data { get; set; }
		public ApiResponsePIItemsPoint(int statusCode, IDictionary<string, string> headers, PIItemsPoint data)
			: base(statusCode, headers)
		{
			this.Data = data;
		}
	}
}
