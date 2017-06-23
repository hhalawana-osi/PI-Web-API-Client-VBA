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

	[Guid("5EBEB21E-436F-406F-89AB-A4B8FD05211F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsElementTemplate
	{
		[DispId(1)]
		PIElementTemplate[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIElementTemplate GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIElementTemplate values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("9EE82859-9E9D-422D-8EA7-57E136D58C75")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsElementTemplate))]
	[ProgId("PIWebAPIWrapper.PIItemsElementTemplate")]
	[DataContract]

	public class PIItemsElementTemplate : IPIItemsElementTemplate
	{
		public PIItemsElementTemplate()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIElementTemplate[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIElementTemplate GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIElementTemplate values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIElementTemplate[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
