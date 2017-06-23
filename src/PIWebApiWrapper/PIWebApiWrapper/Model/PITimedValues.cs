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

	[Guid("F750EFC9-9708-46A1-984A-52D308B5E949")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPITimedValues
	{
		[DispId(1)]
		PITimedValue[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PITimedValue GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PITimedValue values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		string UnitsAbbreviation { get; set; }

	}

	[Guid("A22A0871-DDF2-4977-8E18-D025D5D361C4")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPITimedValues))]
	[ProgId("PIWebAPIWrapper.PITimedValues")]
	[DataContract]

	public class PITimedValues : IPITimedValues
	{
		public PITimedValues()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PITimedValue[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PITimedValue GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PITimedValue values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PITimedValue[i];
		}

		[DataMember(Name = "UnitsAbbreviation", EmitDefaultValue = false)]
		public string UnitsAbbreviation { get; set; }

	}
}
