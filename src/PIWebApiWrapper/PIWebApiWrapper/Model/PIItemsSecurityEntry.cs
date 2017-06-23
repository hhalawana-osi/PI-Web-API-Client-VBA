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

	[Guid("97AB71F3-24F3-40A3-95E6-F2E3298F978E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsSecurityEntry
	{
		[DispId(1)]
		PISecurityEntry[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PISecurityEntry GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PISecurityEntry values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("E4EDD98F-6C64-4876-B614-94F2F6D0E029")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsSecurityEntry))]
	[ProgId("PIWebAPIWrapper.PIItemsSecurityEntry")]
	[DataContract]

	public class PIItemsSecurityEntry : IPIItemsSecurityEntry
	{
		public PIItemsSecurityEntry()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PISecurityEntry[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PISecurityEntry GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PISecurityEntry values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PISecurityEntry[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
