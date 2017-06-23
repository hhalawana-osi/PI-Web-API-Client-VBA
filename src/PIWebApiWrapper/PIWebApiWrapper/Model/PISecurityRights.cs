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

	[Guid("434DF425-39DF-475D-B3CD-96ADDEC339C4")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISecurityRights
	{
		[DispId(1)]
		string OwnerWebId { get; set; }

		[DispId(2)]
		string SecurityItem { get; set; }

		[DispId(3)]
		string UserIdentity { get; set; }

		[DispId(4)]
		object Links { get; set; }

	}

	[Guid("3D3D8376-E61E-4C2E-A9BC-BB969B25B3B5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISecurityRights))]
	[ProgId("PIWebAPIWrapper.PISecurityRights")]
	[DataContract]

	public class PISecurityRights : IPISecurityRights
	{
		public PISecurityRights()
		{
		}

		[DataMember(Name = "OwnerWebId", EmitDefaultValue = false)]
		public string OwnerWebId { get; set; }

		[DataMember(Name = "SecurityItem", EmitDefaultValue = false)]
		public string SecurityItem { get; set; }

		[DataMember(Name = "UserIdentity", EmitDefaultValue = false)]
		public string UserIdentity { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
