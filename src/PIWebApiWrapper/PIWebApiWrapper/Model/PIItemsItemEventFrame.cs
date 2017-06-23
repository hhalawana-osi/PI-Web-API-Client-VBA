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

	[Guid("D978443C-DF8B-4589-B8B1-7EBEA681ABEC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsItemEventFrame
	{
		[DispId(1)]
		PIItemEventFrame[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIItemEventFrame GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIItemEventFrame values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("C774A4E9-D018-49D6-AEE3-A34F74B72677")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsItemEventFrame))]
	[ProgId("PIWebAPIWrapper.PIItemsItemEventFrame")]
	[DataContract]

	public class PIItemsItemEventFrame : IPIItemsItemEventFrame
	{
		public PIItemsItemEventFrame()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIItemEventFrame[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIItemEventFrame GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIItemEventFrame values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIItemEventFrame[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
