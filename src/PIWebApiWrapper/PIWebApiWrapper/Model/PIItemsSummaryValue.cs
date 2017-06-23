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

	[Guid("2E4CC466-BF39-429D-9CB0-F736A257A3CF")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsSummaryValue
	{
		[DispId(1)]
		PISummaryValue[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PISummaryValue GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PISummaryValue values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("FB8C3FF5-B3BA-43EB-A18C-94EB8F71C6C5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsSummaryValue))]
	[ProgId("PIWebAPIWrapper.PIItemsSummaryValue")]
	[DataContract]

	public class PIItemsSummaryValue : IPIItemsSummaryValue
	{
		public PIItemsSummaryValue()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PISummaryValue[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PISummaryValue GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PISummaryValue values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PISummaryValue[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
