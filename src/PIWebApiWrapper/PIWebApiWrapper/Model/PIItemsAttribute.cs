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

	[Guid("BA1D8E0A-3158-44B6-B217-374CFB1EBFB3")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAttribute
	{
		[DispId(1)]
		PIAttribute[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAttribute GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAttribute values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("A7303710-44D9-42EC-8D2B-919D3514EF13")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAttribute))]
	[ProgId("PIWebAPIWrapper.PIItemsAttribute")]
	[DataContract]

	public class PIItemsAttribute : IPIItemsAttribute
	{
		public PIItemsAttribute()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAttribute[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAttribute GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAttribute values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAttribute[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
