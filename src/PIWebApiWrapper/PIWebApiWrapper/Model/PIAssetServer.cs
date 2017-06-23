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

	[Guid("CF933941-7AD4-4972-89C0-5DC62C96338D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAssetServer
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
		string Path { get; set; }

		[DispId(6)]
		bool IsConnected { get; set; }

		[DispId(7)]
		string ServerVersion { get; set; }

		[DispId(8)]
		object ExtendedProperties { get; set; }

		[DispId(9)]
		object Links { get; set; }

	}

	[Guid("EBD3B6F3-8307-4E8C-8B07-2F398280FA33")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAssetServer))]
	[ProgId("PIWebAPIWrapper.PIAssetServer")]
	[DataContract]

	public class PIAssetServer : IPIAssetServer
	{
		public PIAssetServer()
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

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "IsConnected", EmitDefaultValue = false)]
		public bool IsConnected { get; set; }

		[DataMember(Name = "ServerVersion", EmitDefaultValue = false)]
		public string ServerVersion { get; set; }

		[DataMember(Name = "ExtendedProperties", EmitDefaultValue = false)]
		public object ExtendedProperties { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
