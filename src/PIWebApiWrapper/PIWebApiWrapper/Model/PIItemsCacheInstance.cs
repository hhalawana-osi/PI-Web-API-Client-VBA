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

	[Guid("A38B2063-C12D-4D49-99F7-4F7A748C30B0")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsCacheInstance
	{
		[DispId(1)]
		PICacheInstance[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PICacheInstance GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PICacheInstance values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("8EE2D0AD-53BC-4F2B-8C6B-47DCC7FCE69D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsCacheInstance))]
	[ProgId("PIWebAPIWrapper.PIItemsCacheInstance")]
	[DataContract]

	public class PIItemsCacheInstance : IPIItemsCacheInstance
	{
		public PIItemsCacheInstance()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PICacheInstance[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PICacheInstance GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PICacheInstance values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PICacheInstance[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
