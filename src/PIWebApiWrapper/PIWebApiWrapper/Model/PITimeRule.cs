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

	[Guid("8F46B71F-79C9-4BEF-8B4D-1BE69DCAF0B0")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPITimeRule
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
		string ConfigString { get; set; }

		[DispId(7)]
		string ConfigStringStored { get; set; }

		[DispId(8)]
		string DisplayString { get; set; }

		[DispId(9)]
		string EditorType { get; set; }

		[DispId(10)]
		bool IsConfigured { get; set; }

		[DispId(11)]
		bool IsInitializing { get; set; }

		[DispId(12)]
		bool MergeDuplicatedItems { get; set; }

		[DispId(13)]
		string PlugInName { get; set; }

		[DispId(14)]
		object Links { get; set; }

	}

	[Guid("FD8933B7-2F45-4DBF-BC01-932276C49DB0")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPITimeRule))]
	[ProgId("PIWebAPIWrapper.PITimeRule")]
	[DataContract]

	public class PITimeRule : IPITimeRule
	{
		public PITimeRule()
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

		[DataMember(Name = "ConfigString", EmitDefaultValue = false)]
		public string ConfigString { get; set; }

		[DataMember(Name = "ConfigStringStored", EmitDefaultValue = false)]
		public string ConfigStringStored { get; set; }

		[DataMember(Name = "DisplayString", EmitDefaultValue = false)]
		public string DisplayString { get; set; }

		[DataMember(Name = "EditorType", EmitDefaultValue = false)]
		public string EditorType { get; set; }

		[DataMember(Name = "IsConfigured", EmitDefaultValue = false)]
		public bool IsConfigured { get; set; }

		[DataMember(Name = "IsInitializing", EmitDefaultValue = false)]
		public bool IsInitializing { get; set; }

		[DataMember(Name = "MergeDuplicatedItems", EmitDefaultValue = false)]
		public bool MergeDuplicatedItems { get; set; }

		[DataMember(Name = "PlugInName", EmitDefaultValue = false)]
		public string PlugInName { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
