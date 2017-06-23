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

	[Guid("60559549-63AA-4AE7-9357-B71A813042E4")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAttributeTemplate
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
		string Type { get; set; }

		[DispId(7)]
		string TypeQualifier { get; set; }

		[DispId(8)]
		string DefaultUnitsName { get; set; }

		[DispId(9)]
		object DefaultValue { get; set; }

		[DispId(10)]
		string DataReferencePlugIn { get; set; }

		[DispId(11)]
		string ConfigString { get; set; }

		[DispId(12)]
		bool IsConfigurationItem { get; set; }

		[DispId(13)]
		bool IsExcluded { get; set; }

		[DispId(14)]
		bool IsHidden { get; set; }

		[DispId(15)]
		bool IsManualDataEntry { get; set; }

		[DispId(16)]
		bool HasChildren { get; set; }

		[DispId(17)]
		string[] CategoryNames { get; set; }

		[DispId(18)]
		string TraitName { get; set; }

		[DispId(19)]
		object Links { get; set; }

	}

	[Guid("D0DED139-7495-4557-8CE0-8361948C1146")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAttributeTemplate))]
	[ProgId("PIWebAPIWrapper.PIAttributeTemplate")]
	[DataContract]

	public class PIAttributeTemplate : IPIAttributeTemplate
	{
		public PIAttributeTemplate()
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

		[DataMember(Name = "Type", EmitDefaultValue = false)]
		public string Type { get; set; }

		[DataMember(Name = "TypeQualifier", EmitDefaultValue = false)]
		public string TypeQualifier { get; set; }

		[DataMember(Name = "DefaultUnitsName", EmitDefaultValue = false)]
		public string DefaultUnitsName { get; set; }

		[DataMember(Name = "DefaultValue", EmitDefaultValue = false)]
		public object DefaultValue { get; set; }

		[DataMember(Name = "DataReferencePlugIn", EmitDefaultValue = false)]
		public string DataReferencePlugIn { get; set; }

		[DataMember(Name = "ConfigString", EmitDefaultValue = false)]
		public string ConfigString { get; set; }

		[DataMember(Name = "IsConfigurationItem", EmitDefaultValue = false)]
		public bool IsConfigurationItem { get; set; }

		[DataMember(Name = "IsExcluded", EmitDefaultValue = false)]
		public bool IsExcluded { get; set; }

		[DataMember(Name = "IsHidden", EmitDefaultValue = false)]
		public bool IsHidden { get; set; }

		[DataMember(Name = "IsManualDataEntry", EmitDefaultValue = false)]
		public bool IsManualDataEntry { get; set; }

		[DataMember(Name = "HasChildren", EmitDefaultValue = false)]
		public bool HasChildren { get; set; }

		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public string[] CategoryNames { get; set; }

		[DataMember(Name = "TraitName", EmitDefaultValue = false)]
		public string TraitName { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
