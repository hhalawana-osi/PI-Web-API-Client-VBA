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

	[Guid("DD66F068-041F-4F68-BABC-62598C9EA91C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAnalysis
	{
		[DispId(1)]
		PIAnalysis[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAnalysis GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAnalysis values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("77B5793B-0EF7-4B83-90FB-B41D0E44B682")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAnalysis))]
	[ProgId("PIWebAPIWrapper.PIItemsAnalysis")]
	[DataContract]

	public class PIItemsAnalysis : IPIItemsAnalysis
	{
		public PIItemsAnalysis()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAnalysis[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAnalysis GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAnalysis values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAnalysis[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
