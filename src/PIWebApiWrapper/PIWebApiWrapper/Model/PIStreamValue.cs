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

	[Guid("BE8B3E8C-C5E2-4F33-83A5-95643912A3F8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIStreamValue
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Name { get; set; }

		[DispId(3)]
		string Path { get; set; }

		[DispId(4)]
		PITimedValue Value { get; set; }

		[DispId(5)]
		object Links { get; set; }

	}

	[Guid("209811B6-2DAA-450C-9F17-DF552D9691B9")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIStreamValue))]
	[ProgId("PIWebAPIWrapper.PIStreamValue")]
	[DataContract]

	public class PIStreamValue : IPIStreamValue
	{
		public PIStreamValue()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public PITimedValue Value { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
