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

	[Guid("88118D5E-78F0-4867-9FE5-794736CE9D08")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsTable
	{
		[DispId(1)]
		PITable[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PITable GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PITable values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("31ECF66C-39DA-4157-9226-8090FAC9D47B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsTable))]
	[ProgId("PIWebAPIWrapper.PIItemsTable")]
	[DataContract]

	public class PIItemsTable : IPIItemsTable
	{
		public PIItemsTable()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PITable[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PITable GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PITable values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PITable[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
