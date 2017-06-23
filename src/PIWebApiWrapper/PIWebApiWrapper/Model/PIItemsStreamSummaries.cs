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

	[Guid("9B1C1A15-3BF6-46CE-9121-8B85D6B74AF0")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsStreamSummaries
	{
		[DispId(1)]
		PIStreamSummaries[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIStreamSummaries GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIStreamSummaries values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("14255C06-7E9E-47DB-990D-7D74FC73CA1F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsStreamSummaries))]
	[ProgId("PIWebAPIWrapper.PIItemsStreamSummaries")]
	[DataContract]

	public class PIItemsStreamSummaries : IPIItemsStreamSummaries
	{
		public PIItemsStreamSummaries()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIStreamSummaries[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIStreamSummaries GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIStreamSummaries values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIStreamSummaries[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
