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

	[Guid("954729E6-9E1A-4448-A6AD-639206873562")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsUnitClass
	{
		[DispId(1)]
		PIUnitClass[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIUnitClass GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIUnitClass values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("B5F24815-FC8D-4612-9A52-0E81D9A3F841")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsUnitClass))]
	[ProgId("PIWebAPIWrapper.PIItemsUnitClass")]
	[DataContract]

	public class PIItemsUnitClass : IPIItemsUnitClass
	{
		public PIItemsUnitClass()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIUnitClass[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIUnitClass GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIUnitClass values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIUnitClass[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
