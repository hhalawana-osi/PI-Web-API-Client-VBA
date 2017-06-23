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

	[Guid("92C290BD-AFC8-4250-8C1E-EB4977FD6300")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAssetDatabase
	{
		[DispId(1)]
		PIAssetDatabase[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAssetDatabase GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAssetDatabase values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("EAB2D00B-1FC0-44CF-B5EE-1A2204CE1523")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAssetDatabase))]
	[ProgId("PIWebAPIWrapper.PIItemsAssetDatabase")]
	[DataContract]

	public class PIItemsAssetDatabase : IPIItemsAssetDatabase
	{
		public PIItemsAssetDatabase()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAssetDatabase[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAssetDatabase GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAssetDatabase values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAssetDatabase[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
