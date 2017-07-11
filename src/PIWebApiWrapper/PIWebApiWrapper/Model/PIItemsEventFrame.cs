// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

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

	[Guid("53C82507-42FE-41F4-BE90-0498564632B8")]
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

	[Guid("CEC1A945-0214-45B6-B927-CE0CB04AA78A")]
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
