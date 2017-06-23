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

	[Guid("0646A699-8D1C-404A-A4C3-7D6720113BFC")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsSubstatus
	{
		[DispId(1)]
		PISubstatus[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PISubstatus GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PISubstatus values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("C081635B-84A6-4C8D-A1A8-624B1F36570B")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsSubstatus))]
	[ProgId("PIWebAPIWrapper.PIItemsSubstatus")]
	[DataContract]

	public class PIItemsSubstatus : IPIItemsSubstatus
	{
		public PIItemsSubstatus()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PISubstatus[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PISubstatus GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PISubstatus values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PISubstatus[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
