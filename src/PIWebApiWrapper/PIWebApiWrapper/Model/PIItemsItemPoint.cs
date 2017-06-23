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

	[Guid("8D2B1054-AAA9-4434-8747-42E921A13D12")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsItemPoint
	{
		[DispId(1)]
		PIItemPoint[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIItemPoint GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIItemPoint values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("20695277-4753-47D0-8887-7550896FCFBB")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsItemPoint))]
	[ProgId("PIWebAPIWrapper.PIItemsItemPoint")]
	[DataContract]

	public class PIItemsItemPoint : IPIItemsItemPoint
	{
		public PIItemsItemPoint()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIItemPoint[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIItemPoint GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIItemPoint values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIItemPoint[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
