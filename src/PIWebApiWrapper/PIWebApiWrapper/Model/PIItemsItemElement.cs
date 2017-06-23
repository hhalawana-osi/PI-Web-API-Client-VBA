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

	[Guid("C0BB7AB0-99A2-402D-BB7E-0F845A38582A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsItemElement
	{
		[DispId(1)]
		PIItemElement[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIItemElement GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIItemElement values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("9703E685-9E1C-4DF4-B0F3-FCEC29131E57")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsItemElement))]
	[ProgId("PIWebAPIWrapper.PIItemsItemElement")]
	[DataContract]

	public class PIItemsItemElement : IPIItemsItemElement
	{
		public PIItemsItemElement()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIItemElement[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIItemElement GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIItemElement values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIItemElement[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
