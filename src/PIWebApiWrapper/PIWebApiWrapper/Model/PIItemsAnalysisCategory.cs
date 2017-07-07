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

	[Guid("A1EC6DEC-98DC-49F3-9E83-063533B8B9DA")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemsAnalysisCategory
	{
		[DispId(1)]
		PIAnalysisCategory[] Items { get; set; }

		[DispId(2)]
		int GetItemsLength();

		[DispId(3)]
		PIAnalysisCategory GetItem(int i);

		[DispId(4)]
		void SetItem(int i, PIAnalysisCategory values);

		[DispId(5)]
		void CreateItemsArray(int i);

		[DispId(6)]
		object Links { get; set; }

	}

	[Guid("A30C4344-0CC9-465E-9318-2F4EA1266FBC")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemsAnalysisCategory))]
	[ProgId("PIWebAPIWrapper.PIItemsAnalysisCategory")]
	[DataContract]

	public class PIItemsAnalysisCategory : IPIItemsAnalysisCategory
	{
		public PIItemsAnalysisCategory()
		{
		}

		[DataMember(Name = "Items", EmitDefaultValue = false)]
		public PIAnalysisCategory[] Items { get; set; }

		public int GetItemsLength()
		{
			return Items.Count();
		}

		public PIAnalysisCategory GetItem(int i)
		{
			return Items[i];
		}

		public void SetItem(int i, PIAnalysisCategory values)
		{
			Items[i] = values;
		}

		public void CreateItemsArray(int i)
		{
			Items = new PIAnalysisCategory[i];
		}

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
