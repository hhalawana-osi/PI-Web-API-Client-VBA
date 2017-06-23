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

	[Guid("DC65309E-6F7D-41CD-B6FF-675D08E0F060")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAnnotation
	{
		[DispId(1)]
		string Id { get; set; }

		[DispId(2)]
		string Name { get; set; }

		[DispId(3)]
		string Description { get; set; }

		[DispId(4)]
		object Value { get; set; }

		[DispId(5)]
		void SetValueWithString(string value);

		[DispId(6)]
		void SetValueWithInt(int value);

		[DispId(7)]
		void SetValueWithDouble(double value);

		[DispId(8)]
		string Creator { get; set; }

		[DispId(9)]
		string CreationDate { get; set; }

		[DispId(10)]
		string Modifier { get; set; }

		[DispId(11)]
		string ModifyDate { get; set; }

		[DispId(12)]
		object Links { get; set; }

	}

	[Guid("1F9C475F-FCCE-42A5-BCB9-4E416DC2A484")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAnnotation))]
	[ProgId("PIWebAPIWrapper.PIAnnotation")]
	[DataContract]

	public class PIAnnotation : IPIAnnotation
	{
		public PIAnnotation()
		{
		}

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public object Value { get; set; }

		public void SetValueWithString(string value)
		{
			Value = value;
		}

		public void SetValueWithInt(int value)
		{
			Value = value;
		}

		public void SetValueWithDouble(double value)
		{
			Value = value;
		}

		[DataMember(Name = "Creator", EmitDefaultValue = false)]
		public string Creator { get; set; }

		[DataMember(Name = "CreationDate", EmitDefaultValue = false)]
		public string CreationDate { get; set; }

		[DataMember(Name = "Modifier", EmitDefaultValue = false)]
		public string Modifier { get; set; }

		[DataMember(Name = "ModifyDate", EmitDefaultValue = false)]
		public string ModifyDate { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
