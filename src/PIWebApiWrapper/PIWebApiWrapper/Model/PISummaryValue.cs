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

	[Guid("11CA2C19-9F59-4253-BE95-990773DBB9F5")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISummaryValue
	{
		[DispId(1)]
		string Type { get; set; }

		[DispId(2)]
		PITimedValue Value { get; set; }

	}

	[Guid("A9426051-B0BA-41FC-9373-DBF227919912")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISummaryValue))]
	[ProgId("PIWebAPIWrapper.PISummaryValue")]
	[DataContract]

	public class PISummaryValue : IPISummaryValue
	{
		public PISummaryValue()
		{
		}

		[DataMember(Name = "Type", EmitDefaultValue = false)]
		public string Type { get; set; }

		[DataMember(Name = "Value", EmitDefaultValue = false)]
		public PITimedValue Value { get; set; }

	}
}
