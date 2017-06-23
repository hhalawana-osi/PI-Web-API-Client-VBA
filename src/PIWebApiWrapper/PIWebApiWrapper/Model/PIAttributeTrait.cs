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

	[Guid("0BA34CBF-D780-4CE4-9D98-5BF5A953AA12")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAttributeTrait
	{
		[DispId(1)]
		string Name { get; set; }

		[DispId(2)]
		string Abbreviation { get; set; }

		[DispId(3)]
		bool AllowChildAttributes { get; set; }

		[DispId(4)]
		bool AllowDuplicates { get; set; }

		[DispId(5)]
		bool IsAllowedOnRootAttribute { get; set; }

		[DispId(6)]
		bool IsTypeInherited { get; set; }

		[DispId(7)]
		bool IsUOMInherited { get; set; }

		[DispId(8)]
		bool RequireNumeric { get; set; }

		[DispId(9)]
		bool RequireString { get; set; }

		[DispId(10)]
		object Links { get; set; }

	}

	[Guid("AEA98F4C-5CE7-4F01-81A9-3CF1115B35A1")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAttributeTrait))]
	[ProgId("PIWebAPIWrapper.PIAttributeTrait")]
	[DataContract]

	public class PIAttributeTrait : IPIAttributeTrait
	{
		public PIAttributeTrait()
		{
		}

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Abbreviation", EmitDefaultValue = false)]
		public string Abbreviation { get; set; }

		[DataMember(Name = "AllowChildAttributes", EmitDefaultValue = false)]
		public bool AllowChildAttributes { get; set; }

		[DataMember(Name = "AllowDuplicates", EmitDefaultValue = false)]
		public bool AllowDuplicates { get; set; }

		[DataMember(Name = "IsAllowedOnRootAttribute", EmitDefaultValue = false)]
		public bool IsAllowedOnRootAttribute { get; set; }

		[DataMember(Name = "IsTypeInherited", EmitDefaultValue = false)]
		public bool IsTypeInherited { get; set; }

		[DataMember(Name = "IsUOMInherited", EmitDefaultValue = false)]
		public bool IsUOMInherited { get; set; }

		[DataMember(Name = "RequireNumeric", EmitDefaultValue = false)]
		public bool RequireNumeric { get; set; }

		[DataMember(Name = "RequireString", EmitDefaultValue = false)]
		public bool RequireString { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
