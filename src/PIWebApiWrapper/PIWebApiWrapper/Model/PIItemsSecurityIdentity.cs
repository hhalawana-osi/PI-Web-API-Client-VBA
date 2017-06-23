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

	[Guid("81F26332-D472-4529-9B98-DAC7A1891786")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsSecurityIdentity
	{
		[DispId(1)]
		PISecurityIdentity[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PISecurityIdentity GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PISecurityIdentity values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("FB7FFFF1-1AE5-41D1-8AEA-6EF0A5292D61")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsSecurityIdentity))]
	[ProgId("PIWebAPIWrapper.PIItemsSecurityIdentity")]
	[DataContract]

	public class PIItemsSecurityIdentity : IPIItemsSecurityIdentity
	{
		public PIItemsSecurityIdentity()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PISecurityIdentity[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PISecurityIdentity GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PISecurityIdentity values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PISecurityIdentity[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
