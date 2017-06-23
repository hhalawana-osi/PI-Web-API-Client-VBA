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

	[Guid("EC2AB5A9-E9A8-4B74-B91A-A10D610F6E19")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsDataServer
	{
		[DispId(1)]
		PIDataServer[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIDataServer GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIDataServer values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("333CCF94-B280-48B0-ABF4-22035BC7C531")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsDataServer))]
	[ProgId("PIWebAPIWrapper.PIItemsDataServer")]
	[DataContract]

	public class PIItemsDataServer : IPIItemsDataServer
	{
		public PIItemsDataServer()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIDataServer[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIDataServer GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIDataServer values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIDataServer[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
