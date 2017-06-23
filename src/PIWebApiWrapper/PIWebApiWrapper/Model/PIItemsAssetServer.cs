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

	[Guid("B479CDFD-2C32-4CA3-91EE-02EF3905B3BD")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAssetServer
	{
		[DispId(1)]
		PIAssetServer[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAssetServer GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAssetServer values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("0A4294ED-3B88-40F9-8D6A-B1EA02C33B18")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAssetServer))]
	[ProgId("PIWebAPIWrapper.PIItemsAssetServer")]
	[DataContract]

	public class PIItemsAssetServer : IPIItemsAssetServer
	{
		public PIItemsAssetServer()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAssetServer[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAssetServer GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAssetServer values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAssetServer[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
