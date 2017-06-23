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

	[Guid("3C330203-F2CC-4669-B5EE-27B3C6CBF644")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIEnumerationValue
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Id { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string Description { get; set; }

		[DispId(5)]
		int Value { get; set; }

		[DispId(6)]
		string Path { get; set; }

		[DispId(7)]
		object Links { get; set; }

		[DispId(8)]
		bool SerializeWebId { get; set; }

		[DispId(9)]
		bool SerializeId { get; set; }

		[DispId(10)]
		bool SerializeDescription { get; set; }

		[DispId(11)]
		bool SerializePath { get; set; }

		[DispId(12)]
		bool SerializeLinks { get; set; }

	}

	[Guid("899DC763-4D2D-40B1-8A2B-3CA6D06EC67D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIEnumerationValue))]
	[ProgId("PIWebAPIWrapper.PIEnumerationValue")]
	[DataContract]

	public class PIEnumerationValue : IPIEnumerationValue
	{
		public PIEnumerationValue()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public int Value { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

		[DataMember(Name = "SerializeWebId", EmitDefaultValue = false)]
		public bool SerializeWebId { get; set; }

		[DataMember(Name = "SerializeId", EmitDefaultValue = false)]
		public bool SerializeId { get; set; }

		[DataMember(Name = "SerializeDescription", EmitDefaultValue = false)]
		public bool SerializeDescription { get; set; }

		[DataMember(Name = "SerializePath", EmitDefaultValue = false)]
		public bool SerializePath { get; set; }

		[DataMember(Name = "SerializeLinks", EmitDefaultValue = false)]
		public bool SerializeLinks { get; set; }

	}
}
