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

	[Guid("C22B89A0-BA32-4A89-86FC-9A20D45D9FE7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsElement
	{
		[DispId(1)]
		PIElement[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIElement GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIElement values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("9A0BDA86-5EB9-416A-BEB6-08B6216271F7")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsElement))]
	[ProgId("PIWebAPIWrapper.PIItemsElement")]
	[DataContract]

	public class PIItemsElement : IPIItemsElement
	{
		public PIItemsElement()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIElement[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIElement GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIElement values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIElement[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
