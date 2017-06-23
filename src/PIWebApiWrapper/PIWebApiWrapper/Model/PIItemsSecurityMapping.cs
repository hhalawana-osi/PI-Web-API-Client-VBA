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

	[Guid("935B2EC1-DE7A-420E-B3E4-9C46468F4D29")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsSecurityMapping
	{
		[DispId(1)]
		PISecurityMapping[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PISecurityMapping GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PISecurityMapping values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("E76E41A6-550A-4314-917F-4D78B4F49330")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsSecurityMapping))]
	[ProgId("PIWebAPIWrapper.PIItemsSecurityMapping")]
	[DataContract]

	public class PIItemsSecurityMapping : IPIItemsSecurityMapping
	{
		public PIItemsSecurityMapping()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PISecurityMapping[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PISecurityMapping GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PISecurityMapping values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PISecurityMapping[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
