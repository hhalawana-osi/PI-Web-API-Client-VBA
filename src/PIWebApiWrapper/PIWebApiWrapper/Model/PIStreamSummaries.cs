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

	[Guid("15853134-090D-4787-B43B-00174A889418")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIStreamSummaries
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Name { get; set; }

		[DispId(3)]
		string Path { get; set; }

		[DispId(4)]
		PISummaryValue[] Items { get; set; }

		[DispId(5)]
		int GetItemsLength();

		[DispId(6)]
		PISummaryValue GetItem(int i);

		[DispId(7)]
		void SetItem(int i, PISummaryValue values);

		[DispId(8)]
		void CreateItemsArray(int i);

		[DispId(9)]
		object Links { get; set; }

	}

	[Guid("7FC5253C-9F7D-4F3C-9517-EDB958035EA7")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIStreamSummaries))]
	[ProgId("PIWebAPIWrapper.PIStreamSummaries")]
	[DataContract]

	public class PIStreamSummaries : IPIStreamSummaries
	{
		public PIStreamSummaries()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

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
