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

	[Guid("A77AC1CC-AF1E-4CF7-810C-86A90F07ACBD")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsItemsSubstatus
	{
		[DispId(1)]
		PIItemsSubstatus[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIItemsSubstatus GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIItemsSubstatus values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("2EC35DB3-77DC-4E36-8355-2A64ECF67B02")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsItemsSubstatus))]
	[ProgId("PIWebAPIWrapper.PIItemsItemsSubstatus")]
	[DataContract]

	public class PIItemsItemsSubstatus : IPIItemsItemsSubstatus
	{
		public PIItemsItemsSubstatus()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIItemsSubstatus[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIItemsSubstatus GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIItemsSubstatus values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIItemsSubstatus[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
