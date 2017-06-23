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

	[Guid("C89D9661-C890-4D82-8896-4EF20153B8B9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAnalysisCategory
	{
		[DispId(1)]
		PIAnalysisCategory[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAnalysisCategory GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAnalysisCategory values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("68117598-8538-475A-BDE7-EAD4BCAA24EF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAnalysisCategory))]
	[ProgId("PIWebAPIWrapper.PIItemsAnalysisCategory")]
	[DataContract]

	public class PIItemsAnalysisCategory : IPIItemsAnalysisCategory
	{
		public PIItemsAnalysisCategory()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAnalysisCategory[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAnalysisCategory GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAnalysisCategory values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAnalysisCategory[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
