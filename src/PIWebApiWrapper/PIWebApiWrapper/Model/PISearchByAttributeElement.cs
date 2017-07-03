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

	[Guid("59F0B67F-DA15-437D-B622-FF5F48DEB49B")]
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

	[Guid("7FBE3CF5-38AC-4A3A-B093-7B3C06D3D9A5")]
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
