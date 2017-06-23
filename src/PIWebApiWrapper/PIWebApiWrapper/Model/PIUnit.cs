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

	[Guid("09CFE224-7A7D-4694-BECD-D1FFE6836E28")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIUnit
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Id { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string Abbreviation { get; set; }

		[DispId(5)]
		string Description { get; set; }

		[DispId(6)]
		string Path { get; set; }

		[DispId(7)]
		double Factor { get; set; }

		[DispId(8)]
		double Offset { get; set; }

		[DispId(9)]
		double ReferenceFactor { get; set; }

		[DispId(10)]
		double ReferenceOffset { get; set; }

		[DispId(11)]
		string ReferenceUnitAbbreviation { get; set; }

		[DispId(12)]
		object Links { get; set; }

	}

	[Guid("1CB6CE66-36D7-42A2-B0EA-FBE1B75C0C19")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIUnit))]
	[ProgId("PIWebAPIWrapper.PIUnit")]
	[DataContract]

	public class PIUnit : IPIUnit
	{
		public PIUnit()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Abbreviation", EmitDefaultValue = false)]
		public string Abbreviation { get; set; }

		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "Factor", EmitDefaultValue = false)]
		public double Factor { get; set; }

		[DataMember(Name = "Offset", EmitDefaultValue = false)]
		public double Offset { get; set; }

		[DataMember(Name = "ReferenceFactor", EmitDefaultValue = false)]
		public double ReferenceFactor { get; set; }

		[DataMember(Name = "ReferenceOffset", EmitDefaultValue = false)]
		public double ReferenceOffset { get; set; }

		[DataMember(Name = "ReferenceUnitAbbreviation", EmitDefaultValue = false)]
		public string ReferenceUnitAbbreviation { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
