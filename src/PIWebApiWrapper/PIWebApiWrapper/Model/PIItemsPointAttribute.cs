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

	[Guid("A6514D48-4CFB-4A38-A653-D2D8A5E0679B")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsPointAttribute
	{
		[DispId(1)]
		PIPointAttribute[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIPointAttribute GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIPointAttribute values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("99FABD8E-12C3-4844-838E-37DC3B5A3485")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsPointAttribute))]
	[ProgId("PIWebAPIWrapper.PIItemsPointAttribute")]
	[DataContract]

	public class PIItemsPointAttribute : IPIItemsPointAttribute
	{
		public PIItemsPointAttribute()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIPointAttribute[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIPointAttribute GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIPointAttribute values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIPointAttribute[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
