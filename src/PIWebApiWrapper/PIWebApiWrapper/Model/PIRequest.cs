using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;

namespace PIWebAPIWrapper.Model
{

	[Guid("1BA92D88-6C0E-4F8D-8638-BE67DE0825FB")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIRequest
	{
		[DispId(1)]
		string Method { get; set; }

		[DispId(2)]
		string Resource { get; set; }

		[DispId(3)]
		PIRequestTemplate RequestTemplate { get; set; }

		[DispId(4)]
		string[] Parameters { get; set; }

		[DispId(5)]
		object Headers { get; set; }

		[DispId(6)]
		string Content { get; set; }

		[DispId(7)]
		string[] ParentIds { get; set; }

	}

	[Guid("1130787C-1427-4B18-9816-583294728B8F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIRequest))]
	[ProgId("PIWebAPIWrapper.PIRequest")]
	[DataContract]

	public class PIRequest : IPIRequest
	{
		public PIRequest()
		{
		}

		[DataMember(Name = "Method", EmitDefaultValue = false)]
		public string Method { get; set; }

		[DataMember(Name = "Resource", EmitDefaultValue = false)]
		public string Resource { get; set; }

		[DataMember(Name = "RequestTemplate", EmitDefaultValue = false)]
		public PIRequestTemplate RequestTemplate { get; set; }

		[DataMember(Name = "Parameters", EmitDefaultValue = false)]
		public string[] Parameters { get; set; }

		[DataMember(Name = "Headers", EmitDefaultValue = false)]
		public object Headers { get; set; }

		[DataMember(Name = "Content", EmitDefaultValue = false)]
		public string Content { get; set; }

		[DataMember(Name = "ParentIds", EmitDefaultValue = false)]
		public string[] ParentIds { get; set; }

	}
}
