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

	[Guid("44018CF0-8AF3-4645-93B6-6A666737755D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemAttribute
	{
		[DispId(1)]
		string Identifier { get; set; }

		[DispId(2)]
		string IdentifierType { get; set; }

		[DispId(3)]
		PIAttribute Object { get; set; }

		[DispId(4)]
		PIErrors Exception { get; set; }

	}

	[Guid("8F8A8A42-6208-47C8-9C14-E779D5D70AD6")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemAttribute))]
	[ProgId("PIWebAPIWrapper.PIItemAttribute")]
	[DataContract]

	public class PIItemAttribute : IPIItemAttribute
	{
		public PIItemAttribute()
		{
		}

		[DataMember(Name = "Identifier", EmitDefaultValue = false)]
		public string Identifier { get; set; }

		[DataMember(Name = "IdentifierType", EmitDefaultValue = false)]
		public string IdentifierType { get; set; }

		[DataMember(Name = "Object", EmitDefaultValue = false)]
		public PIAttribute Object { get; set; }

		[DataMember(Name = "Exception", EmitDefaultValue = false)]
		public PIErrors Exception { get; set; }

	}
}
