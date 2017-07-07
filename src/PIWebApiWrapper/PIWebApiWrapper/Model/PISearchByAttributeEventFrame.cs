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

	[Guid("E44FEA1E-D72D-4B5D-9BEE-BE4CED84BB9C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISearchByAttributeEventFrame
	{
		[DispId(1)]
		object SearchRoot { get; set; }

		[DispId(2)]
		object ElementTemplate { get; set; }

		[DispId(3)]
		PIAttributeValueQuery[] ValueQueries { get; set; }

	}

	[Guid("3284F226-BD6A-4AA2-BA4C-0972B48C2AF0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISearchByAttributeEventFrame))]
	[ProgId("PIWebAPIWrapper.PISearchByAttributeEventFrame")]
	[DataContract]

	public class PISearchByAttributeEventFrame : IPISearchByAttributeEventFrame
	{
		public PISearchByAttributeEventFrame()
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
