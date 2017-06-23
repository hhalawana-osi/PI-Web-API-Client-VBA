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

	[Guid("6E71269E-F9C8-4B1C-A54F-A558F1308498")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAttributeCategory
	{
		[DispId(1)]
		PIAttributeCategory[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAttributeCategory GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAttributeCategory values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("517AB2A6-1F18-455C-80BC-35719BA958CB")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAttributeCategory))]
	[ProgId("PIWebAPIWrapper.PIItemsAttributeCategory")]
	[DataContract]

	public class PIItemsAttributeCategory : IPIItemsAttributeCategory
	{
		public PIItemsAttributeCategory()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAttributeCategory[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAttributeCategory GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAttributeCategory values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAttributeCategory[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
