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

	[Guid("A23EF5E6-F8E4-48C2-BE2C-A6F7CE3F102B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsElementCategory
	{
		[DispId(1)]
		PIElementCategory[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIElementCategory GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIElementCategory values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("A0A85911-D411-4044-AEF3-5B331823C4CE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsElementCategory))]
	[ProgId("PIWebAPIWrapper.PIItemsElementCategory")]
	[DataContract]

	public class PIItemsElementCategory : IPIItemsElementCategory
	{
		public PIItemsElementCategory()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIElementCategory[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIElementCategory GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIElementCategory values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIElementCategory[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
