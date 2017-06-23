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

	[Guid("7BE46BEA-0BBE-4406-8BD5-68733A0F1383")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISecurityEntry
	{
		[DispId(1)]
		string Name { get; set; }

		[DispId(2)]
		string SecurityIdentityName { get; set; }

		[DispId(3)]
		string[] AllowRights { get; set; }

		[DispId(4)]
		string[] DenyRights { get; set; }

		[DispId(5)]
		object Links { get; set; }

	}

	[Guid("29AB9138-514A-4FDA-9C9D-3A57DB2A886A")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISecurityEntry))]
	[ProgId("PIWebAPIWrapper.PISecurityEntry")]
	[DataContract]

	public class PISecurityEntry : IPISecurityEntry
	{
		public PISecurityEntry()
		{
		}

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "SecurityIdentityName", EmitDefaultValue = false)]
		public string SecurityIdentityName { get; set; }

		[DataMember(Name = "AllowRights", EmitDefaultValue = false)]
		public string[] AllowRights { get; set; }

		[DataMember(Name = "DenyRights", EmitDefaultValue = false)]
		public string[] DenyRights { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
