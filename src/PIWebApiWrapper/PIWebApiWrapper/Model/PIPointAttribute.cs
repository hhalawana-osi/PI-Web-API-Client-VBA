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

	[Guid("B7A43ED8-CE1F-4D75-AFF2-3AEE5A581A2F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIPointAttribute
	{
		[DispId(1)]
		string Name { get; set; }

		[DispId(2)]
		object Value { get; set; }

		[DispId(3)]
		void SetValueWithString(string value);

		[DispId(4)]
		void SetValueWithInt(int value);

		[DispId(5)]
		void SetValueWithDouble(double value);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("302387C5-7C75-4FB9-A987-0BCB68241A6A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIPointAttribute))]
	[ProgId("PIWebAPIWrapper.PIPointAttribute")]
	[DataContract]

	public class PIPointAttribute : IPIPointAttribute
	{
		public PIPointAttribute()
		{
		}

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

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

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
