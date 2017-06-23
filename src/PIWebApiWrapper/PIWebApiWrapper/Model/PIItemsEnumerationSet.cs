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

	[Guid("D10EBD0F-F247-4D5C-9DEB-567073E1BA40")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsEnumerationSet
	{
		[DispId(1)]
		PIEnumerationSet[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIEnumerationSet GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIEnumerationSet values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("7D09D43E-7E32-4746-B047-2073FAF2142D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsEnumerationSet))]
	[ProgId("PIWebAPIWrapper.PIItemsEnumerationSet")]
	[DataContract]

	public class PIItemsEnumerationSet : IPIItemsEnumerationSet
	{
		public PIItemsEnumerationSet()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIEnumerationSet[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIEnumerationSet GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIEnumerationSet values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIEnumerationSet[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
