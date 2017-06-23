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

	[Guid("0A02DA2A-2DF3-44F7-B75C-4145C26B18E8")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIUnitClass
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Id { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string Description { get; set; }

		[DispId(5)]
		string CanonicalUnitName { get; set; }

		[DispId(6)]
		string CanonicalUnitAbbreviation { get; set; }

		[DispId(7)]
		string Path { get; set; }

		[DispId(8)]
		object Links { get; set; }

	}

	[Guid("D9E32123-3DCB-4D47-9E8C-D0621EE7F039")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIUnitClass))]
	[ProgId("PIWebAPIWrapper.PIUnitClass")]
	[DataContract]

	public class PIUnitClass : IPIUnitClass
	{
		public PIUnitClass()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Description", EmitDefaultValue = false)]
		public string Description { get; set; }

		[DataMember(Name = "CanonicalUnitName", EmitDefaultValue = false)]
		public string CanonicalUnitName { get; set; }

		[DataMember(Name = "CanonicalUnitAbbreviation", EmitDefaultValue = false)]
		public string CanonicalUnitAbbreviation { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
