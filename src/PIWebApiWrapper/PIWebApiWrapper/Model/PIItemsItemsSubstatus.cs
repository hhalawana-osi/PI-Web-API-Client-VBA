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

	[Guid("41A7F531-D0A4-4AE6-A358-3F1E146E7233")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsItemsSubstatus
	{
		[DispId(1)]
		PIItemsSubstatus[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIItemsSubstatus GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIItemsSubstatus values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("4E7E1F84-271E-4FC9-89F7-A2B603C3F6F0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsItemsSubstatus))]
	[ProgId("PIWebAPIWrapper.PIItemsItemsSubstatus")]
	[DataContract]

	public class PIItemsItemsSubstatus : IPIItemsItemsSubstatus
	{
		public PIItemsItemsSubstatus()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIItemsSubstatus[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIItemsSubstatus GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIItemsSubstatus values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIItemsSubstatus[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
