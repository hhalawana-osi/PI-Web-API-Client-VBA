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

	[Guid("F9ECD514-CEE1-4483-AE58-F29300DF2FE3")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAnalysisRulePlugIn
	{
		[DispId(1)]
		PIAnalysisRulePlugIn[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAnalysisRulePlugIn GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAnalysisRulePlugIn values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("D4B81238-9A18-429C-AE89-9B05C528C971")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAnalysisRulePlugIn))]
	[ProgId("PIWebAPIWrapper.PIItemsAnalysisRulePlugIn")]
	[DataContract]

	public class PIItemsAnalysisRulePlugIn : IPIItemsAnalysisRulePlugIn
	{
		public PIItemsAnalysisRulePlugIn()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAnalysisRulePlugIn[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAnalysisRulePlugIn GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAnalysisRulePlugIn values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAnalysisRulePlugIn[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
