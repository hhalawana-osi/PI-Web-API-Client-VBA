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

	[Guid("B298BF3C-E515-4F99-A0C8-3D623FB21EC5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIValue
	{
		[DispId(1)]
		object Value { get; set; }

		[DispId(2)]
		void SetValueWithString(string value);

		[DispId(3)]
		void SetValueWithInt(int value);

		[DispId(4)]
		void SetValueWithDouble(double value);

		[DispId(5)]
		PIErrors Exception { get; set; }

	}

	[Guid("6D2A1556-7B6B-4CB1-A564-447C7F9C93FF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIValue))]
	[ProgId("PIWebAPIWrapper.PIValue")]
	[DataContract]

	public class PIValue : IPIValue
	{
		public PIValue()
		{
		}

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

		[DataMember(Name = "Exception", EmitDefaultValue = false)]
		public PIErrors Exception { get; set; }

	}
}
