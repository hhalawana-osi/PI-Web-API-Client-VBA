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

	[Guid("E05038D8-EF83-4277-B362-8D24E61292B6")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsEnumerationValue
	{
		[DispId(1)]
		PIEnumerationValue[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIEnumerationValue GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIEnumerationValue values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("E59741AB-1054-4EF2-A8E2-0220F3CF58CF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsEnumerationValue))]
	[ProgId("PIWebAPIWrapper.PIItemsEnumerationValue")]
	[DataContract]

	public class PIItemsEnumerationValue : IPIItemsEnumerationValue
	{
		public PIItemsEnumerationValue()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIEnumerationValue[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIEnumerationValue GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIEnumerationValue values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIEnumerationValue[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
