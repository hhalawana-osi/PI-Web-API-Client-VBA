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

	[Guid("95329705-0861-484F-9F9F-AE61216D3176")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsSubstatus
	{
		[DispId(1)]
		PISubstatus[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PISubstatus GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PISubstatus values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("8FF23B0D-59E6-424A-A9C6-F8B731384481")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsSubstatus))]
	[ProgId("PIWebAPIWrapper.PIItemsSubstatus")]
	[DataContract]

	public class PIItemsSubstatus : IPIItemsSubstatus
	{
		public PIItemsSubstatus()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PISubstatus[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PISubstatus GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PISubstatus values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PISubstatus[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
