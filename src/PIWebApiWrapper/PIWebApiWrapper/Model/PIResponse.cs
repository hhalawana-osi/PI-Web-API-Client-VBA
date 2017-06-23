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

	[Guid("D40FC9FE-7C96-48FB-A12C-3653F8715572")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIResponse
	{
		[DispId(1)]
		int Status { get; set; }

		[DispId(2)]
		object Headers { get; set; }

		[DispId(3)]
		object Content { get; set; }

	}

	[Guid("F216E454-B7E6-4B79-BD5D-DBC60C3A0522")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIResponse))]
	[ProgId("PIWebAPIWrapper.PIResponse")]
	[DataContract]

	public class PIResponse : IPIResponse
	{
		public PIResponse()
		{
		}

		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public int Status { get; set; }

		[DataMember(Name = "Headers", EmitDefaultValue = false)]
		public object Headers { get; set; }

		[DataMember(Name = "Content", EmitDefaultValue = false)]
		public object Content { get; set; }

	}
}
