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

	[Guid("E572002B-CC92-4BB9-95AB-4526FDD7F424")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISearchByAttributeElement
	{
		[DispId(1)]
		object SearchRoot { get; set; }

		[DispId(2)]
		object ElementTemplate { get; set; }

		[DispId(3)]
		PIAttributeValueQuery[] ValueQueries { get; set; }

	}

	[Guid("81FE67B7-56F6-41D0-A6F0-3FA8E881E597")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISearchByAttributeElement))]
	[ProgId("PIWebAPIWrapper.PISearchByAttributeElement")]
	[DataContract]

	public class PISearchByAttributeElement : IPISearchByAttributeElement
	{
		public PISearchByAttributeElement()
		{
		}

		[DataMember(Name = "SearchRoot", EmitDefaultValue = false)]
		public object SearchRoot { get; set; }

		[DataMember(Name = "ElementTemplate", EmitDefaultValue = false)]
		public object ElementTemplate { get; set; }

		[DataMember(Name = "ValueQueries", EmitDefaultValue = false)]
		public PIAttributeValueQuery[] ValueQueries { get; set; }

	}
}
