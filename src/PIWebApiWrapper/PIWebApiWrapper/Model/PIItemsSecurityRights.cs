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

	[Guid("BEAADD3D-7569-4799-8C37-F1E787399747")]
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

	[Guid("D475769C-A3CB-45DB-9818-C5A28969865D")]
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
