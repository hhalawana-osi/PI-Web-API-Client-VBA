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

	[Guid("D7A2BF23-821C-4EA6-A015-91E1B2944498")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAttributeTemplate
	{
		[DispId(1)]
		PIAttributeTemplate[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAttributeTemplate GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAttributeTemplate values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("268BE94D-3EE7-475C-BB46-A1CDA95D4D58")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAttributeTemplate))]
	[ProgId("PIWebAPIWrapper.PIItemsAttributeTemplate")]
	[DataContract]

	public class PIItemsAttributeTemplate : IPIItemsAttributeTemplate
	{
		public PIItemsAttributeTemplate()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAttributeTemplate[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAttributeTemplate GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAttributeTemplate values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAttributeTemplate[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
