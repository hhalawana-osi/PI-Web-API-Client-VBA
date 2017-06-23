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

	[Guid("EFB9F651-979F-479C-812A-405BC6878A8F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsItemAttribute
	{
		[DispId(1)]
		PIItemAttribute[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIItemAttribute GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIItemAttribute values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("8F8FDE52-5B42-4A29-BFF3-5C43136CE41E")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsItemAttribute))]
	[ProgId("PIWebAPIWrapper.PIItemsItemAttribute")]
	[DataContract]

	public class PIItemsItemAttribute : IPIItemsItemAttribute
	{
		public PIItemsItemAttribute()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIItemAttribute[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIItemAttribute GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIItemAttribute values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIItemAttribute[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
