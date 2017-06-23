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

	[Guid("3D08BDDB-3B04-4C19-A2FD-88F8862B6EA5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsPoint
	{
		[DispId(1)]
		PIPoint[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIPoint GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIPoint values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("32277296-40EA-4B58-BBE6-AF29FA276A4D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsPoint))]
	[ProgId("PIWebAPIWrapper.PIItemsPoint")]
	[DataContract]

	public class PIItemsPoint : IPIItemsPoint
	{
		public PIItemsPoint()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIPoint[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIPoint GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIPoint values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIPoint[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
