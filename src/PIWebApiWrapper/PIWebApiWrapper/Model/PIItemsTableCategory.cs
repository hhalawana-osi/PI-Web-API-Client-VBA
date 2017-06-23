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

	[Guid("D5BB97C7-94D7-4E7C-ABAF-968595F3DB70")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsTableCategory
	{
		[DispId(1)]
		PITableCategory[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PITableCategory GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PITableCategory values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("1E9BC980-8659-449C-8801-DD997BA8635D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsTableCategory))]
	[ProgId("PIWebAPIWrapper.PIItemsTableCategory")]
	[DataContract]

	public class PIItemsTableCategory : IPIItemsTableCategory
	{
		public PIItemsTableCategory()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PITableCategory[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PITableCategory GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PITableCategory values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PITableCategory[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
