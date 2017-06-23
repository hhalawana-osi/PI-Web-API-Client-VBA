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

	[Guid("A21F991E-1303-461C-B98A-4442C4A49032")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAnalysisTemplate
	{
		[DispId(1)]
		PIAnalysisTemplate[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAnalysisTemplate GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAnalysisTemplate values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("21748D85-F590-42D2-8CCD-DB4EC42F915D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAnalysisTemplate))]
	[ProgId("PIWebAPIWrapper.PIItemsAnalysisTemplate")]
	[DataContract]

	public class PIItemsAnalysisTemplate : IPIItemsAnalysisTemplate
	{
		public PIItemsAnalysisTemplate()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAnalysisTemplate[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAnalysisTemplate GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAnalysisTemplate values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAnalysisTemplate[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
