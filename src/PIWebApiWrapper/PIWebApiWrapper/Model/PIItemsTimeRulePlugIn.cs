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

	[Guid("2EB12F58-282E-45DB-B998-62536A5A3E80")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsTimeRulePlugIn
	{
		[DispId(1)]
		PITimeRulePlugIn[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PITimeRulePlugIn GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PITimeRulePlugIn values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("7EAE4158-B5CF-48EA-860A-B5E51991C06C")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsTimeRulePlugIn))]
	[ProgId("PIWebAPIWrapper.PIItemsTimeRulePlugIn")]
	[DataContract]

	public class PIItemsTimeRulePlugIn : IPIItemsTimeRulePlugIn
	{
		public PIItemsTimeRulePlugIn()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PITimeRulePlugIn[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PITimeRulePlugIn GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PITimeRulePlugIn values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PITimeRulePlugIn[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
