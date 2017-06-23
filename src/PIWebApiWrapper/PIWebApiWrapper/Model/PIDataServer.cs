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

	[Guid("23630685-250D-4DA9-B19E-19141323E0AB")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIDataServer
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		string Id { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string Path { get; set; }

		[DispId(5)]
		bool IsConnected { get; set; }

		[DispId(6)]
		string ServerVersion { get; set; }

		[DispId(7)]
		object Links { get; set; }

	}

	[Guid("F9EE2F28-EB4B-43F0-9344-E748E8E5E5CC")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIDataServer))]
	[ProgId("PIWebAPIWrapper.PIDataServer")]
	[DataContract]

	public class PIDataServer : IPIDataServer
	{
		public PIDataServer()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "IsConnected", EmitDefaultValue = false)]
		public bool IsConnected { get; set; }

		[DataMember(Name = "ServerVersion", EmitDefaultValue = false)]
		public string ServerVersion { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
