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

	[Guid("1F001A3A-20A8-46AE-A593-535188A387D8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIStreamValues
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Name { get; set; }

		[DispId(3)]
		string Path { get; set; }

		[DispId(4)]
		PITimedValue[] Items { get; set; }

		[DispId(5)]
		int GetItemsLength();

		[DispId(6)]
		PITimedValue GetItem(int i);

		[DispId(7)]
		void SetItem(int i, PITimedValue values);

		[DispId(8)]
		void CreateItemsArray(int i);

		[DispId(9)]
		string UnitsAbbreviation { get; set; }

		[DispId(10)]
		object Links { get; set; }

	}

	[Guid("9F80DD0E-EECE-4325-BAE5-05040A902E2A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIStreamValues))]
	[ProgId("PIWebAPIWrapper.PIStreamValues")]
	[DataContract]

	public class PIStreamValues : IPIStreamValues
	{
		public PIStreamValues()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

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

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
