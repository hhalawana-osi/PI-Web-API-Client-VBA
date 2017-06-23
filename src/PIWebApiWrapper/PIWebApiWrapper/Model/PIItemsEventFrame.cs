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

	[Guid("B30E1215-93F4-4E07-B734-AD75C76D9C08")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsEventFrame
	{
		[DispId(1)]
		PIEventFrame[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIEventFrame GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIEventFrame values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("8A7BAA22-CCCB-4222-BF21-C240BF9F3332")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsEventFrame))]
	[ProgId("PIWebAPIWrapper.PIItemsEventFrame")]
	[DataContract]

	public class PIItemsEventFrame : IPIItemsEventFrame
	{
		public PIItemsEventFrame()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIEventFrame[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIEventFrame GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIEventFrame values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIEventFrame[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
