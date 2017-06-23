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

	[Guid("68146A2B-4F0C-4FE9-BD3E-D0D3D8ECB7EA")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsSecurityRights
	{
		[DispId(1)]
		PISecurityRights[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PISecurityRights GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PISecurityRights values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("697E10E4-82BC-4499-BFE4-C0448AF52C8D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsSecurityRights))]
	[ProgId("PIWebAPIWrapper.PIItemsSecurityRights")]
	[DataContract]

	public class PIItemsSecurityRights : IPIItemsSecurityRights
	{
		public PIItemsSecurityRights()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PISecurityRights[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PISecurityRights GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PISecurityRights values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PISecurityRights[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
