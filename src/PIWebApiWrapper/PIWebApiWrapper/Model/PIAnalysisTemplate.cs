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

	[Guid("80B2467F-9D09-4A6B-8223-E79CCDE62785")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAnalysisTemplate
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
		string AnalysisRulePlugInName { get; set; }

		[DispId(7)]
		string[] CategoryNames { get; set; }

		[DispId(8)]
		bool CreateEnabled { get; set; }

		[DispId(9)]
		int GroupId { get; set; }

		[DispId(10)]
		bool HasNotificationTemplate { get; set; }

		[DispId(11)]
		bool HasTarget { get; set; }

		[DispId(12)]
		string OutputTime { get; set; }

		[DispId(13)]
		string TargetName { get; set; }

		[DispId(14)]
		string TimeRulePlugInName { get; set; }

		[DispId(15)]
		object Links { get; set; }

	}

	[Guid("B14C91AA-C1A0-4862-8E3B-EB434DCB6298")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAnalysisTemplate))]
	[ProgId("PIWebAPIWrapper.PIAnalysisTemplate")]
	[DataContract]

	public class PIAnalysisTemplate : IPIAnalysisTemplate
	{
		public PIAnalysisTemplate()
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

		[DataMember(Name = "AnalysisRulePlugInName", EmitDefaultValue = false)]
		public string AnalysisRulePlugInName { get; set; }

		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public string[] CategoryNames { get; set; }

		[DataMember(Name = "CreateEnabled", EmitDefaultValue = false)]
		public bool CreateEnabled { get; set; }

		[DataMember(Name = "GroupId", EmitDefaultValue = false)]
		public int GroupId { get; set; }

		[DataMember(Name = "HasNotificationTemplate", EmitDefaultValue = false)]
		public bool HasNotificationTemplate { get; set; }

		[DataMember(Name = "HasTarget", EmitDefaultValue = false)]
		public bool HasTarget { get; set; }

		[DataMember(Name = "OutputTime", EmitDefaultValue = false)]
		public string OutputTime { get; set; }

		[DataMember(Name = "TargetName", EmitDefaultValue = false)]
		public string TargetName { get; set; }

		[DataMember(Name = "TimeRulePlugInName", EmitDefaultValue = false)]
		public string TimeRulePlugInName { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
