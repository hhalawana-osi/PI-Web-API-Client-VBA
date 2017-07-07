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

	[Guid("7568044C-ED96-4960-93C4-973FE233CE05")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemElement
	{
		[DispId(1)]
		string Identifier { get; set; }

		[DispId(2)]
		string IdentifierType { get; set; }

		[DispId(3)]
		PIElement Object { get; set; }

		[DispId(4)]
		PIErrors Exception { get; set; }

	}

	[Guid("99EEEDF4-BB5F-46DA-9C5D-1DA5893D9ACF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemElement))]
	[ProgId("PIWebAPIWrapper.PIItemElement")]
	[DataContract]

	public class PIItemElement : IPIItemElement
	{
		public PIItemElement()
		{
		}

		[DataMember(Name = "Identifier", EmitDefaultValue = false)]
		public string Identifier { get; set; }

		[DataMember(Name = "IdentifierType", EmitDefaultValue = false)]
		public string IdentifierType { get; set; }

		[DataMember(Name = "Object", EmitDefaultValue = false)]
		public PIElement Object { get; set; }

		[DataMember(Name = "Exception", EmitDefaultValue = false)]
		public PIErrors Exception { get; set; }

	}
}
