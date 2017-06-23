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

	[Guid("315E76E8-D483-4A94-8E34-86ACD503268D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAttributeTrait
	{
		[DispId(1)]
		PIAttributeTrait[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAttributeTrait GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAttributeTrait values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("4A4A1081-DE3E-48C3-B2BF-B1D9494C229A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAttributeTrait))]
	[ProgId("PIWebAPIWrapper.PIItemsAttributeTrait")]
	[DataContract]

	public class PIItemsAttributeTrait : IPIItemsAttributeTrait
	{
		public PIItemsAttributeTrait()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAttributeTrait[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAttributeTrait GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAttributeTrait values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAttributeTrait[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
