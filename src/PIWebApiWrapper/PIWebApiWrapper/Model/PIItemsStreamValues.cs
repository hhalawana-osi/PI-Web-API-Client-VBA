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

	[Guid("5B5D32D8-F738-4C27-A23F-722B44E98B11")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsStreamValues
	{
		[DispId(1)]
		PIStreamValues[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIStreamValues GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIStreamValues values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("D4EC235C-DA11-42CF-A6E0-2FC159F0CB0C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsStreamValues))]
	[ProgId("PIWebAPIWrapper.PIItemsStreamValues")]
	[DataContract]

	public class PIItemsStreamValues : IPIItemsStreamValues
	{
		public PIItemsStreamValues()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIStreamValues[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIStreamValues GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIStreamValues values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIStreamValues[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
