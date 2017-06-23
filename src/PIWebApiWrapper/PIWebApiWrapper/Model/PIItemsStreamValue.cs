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

	[Guid("2831742D-ECC3-48E9-86E7-C71B50D8BDA7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsStreamValue
	{
		[DispId(1)]
		PIStreamValue[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIStreamValue GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIStreamValue values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("34B0C8F8-6344-4B5D-BE82-86566059CE13")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsStreamValue))]
	[ProgId("PIWebAPIWrapper.PIItemsStreamValue")]
	[DataContract]

	public class PIItemsStreamValue : IPIItemsStreamValue
	{
		public PIItemsStreamValue()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIStreamValue[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIStreamValue GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIStreamValue values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIStreamValue[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
