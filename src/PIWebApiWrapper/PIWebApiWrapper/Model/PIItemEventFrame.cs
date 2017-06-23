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

	[Guid("B6B06723-920C-400B-B33D-16A2614AA69F")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemEventFrame
	{
		[DispId(1)]
		string Identifier { get; set; }

		[DispId(2)]
		string IdentifierType { get; set; }

		[DispId(3)]
		PIEventFrame Object { get; set; }

		[DispId(4)]
		PIErrors Exception { get; set; }

	}

	[Guid("403BB441-0336-48A0-A250-86FD2134B6AF")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemEventFrame))]
	[ProgId("PIWebAPIWrapper.PIItemEventFrame")]
	[DataContract]

	public class PIItemEventFrame : IPIItemEventFrame
	{
		public PIItemEventFrame()
		{
		}

		[DataMember(Name = "Identifier", EmitDefaultValue = false)]
		public string Identifier { get; set; }

		[DataMember(Name = "IdentifierType", EmitDefaultValue = false)]
		public string IdentifierType { get; set; }

		[DataMember(Name = "Object", EmitDefaultValue = false)]
		public PIEventFrame Object { get; set; }

		[DataMember(Name = "Exception", EmitDefaultValue = false)]
		public PIErrors Exception { get; set; }

	}
}
