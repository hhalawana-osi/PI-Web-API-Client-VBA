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

	[Guid("0CAB0505-1737-417E-A320-E40B43D517C2")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAssetDatabase
	{
		[DispId(1)]
		PIAssetDatabase[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAssetDatabase GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAssetDatabase values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("63E3950E-A519-4E2B-8A66-09F457AF989F")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAssetDatabase))]
	[ProgId("PIWebAPIWrapper.PIItemsAssetDatabase")]
	[DataContract]

	public class PIItemsAssetDatabase : IPIItemsAssetDatabase
	{
		public PIItemsAssetDatabase()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAssetDatabase[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAssetDatabase GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAssetDatabase values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAssetDatabase[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
