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

	[Guid("625298F1-6865-48D5-8D7F-4B26B2D8864C")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAnalysis
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
		bool AutoCreated { get; set; }

		[DispId(8)]
		string[] CategoryNames { get; set; }

		[DispId(9)]
		int GroupId { get; set; }

		[DispId(10)]
		bool HasNotification { get; set; }

		[DispId(11)]
		bool HasTarget { get; set; }

		[DispId(12)]
		bool HasTemplate { get; set; }

		[DispId(13)]
		bool IsConfigured { get; set; }

		[DispId(14)]
		bool IsTimeRuleDefinedByTemplate { get; set; }

		[DispId(15)]
		int MaximumQueueSize { get; set; }

		[DispId(16)]
		string OutputTime { get; set; }

		[DispId(17)]
		string Priority { get; set; }

		[DispId(18)]
		bool PublishResults { get; set; }

		[DispId(19)]
		string Status { get; set; }

		[DispId(20)]
		string TargetWebId { get; set; }

		[DispId(21)]
		string TemplateName { get; set; }

		[DispId(22)]
		string TimeRulePlugInName { get; set; }

		[DispId(23)]
		object Links { get; set; }

	}

	[Guid("85CCC5A9-78F5-4F73-9D4F-D10648134B82")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAnalysis))]
	[ProgId("PIWebAPIWrapper.PIAnalysis")]
	[DataContract]

	public class PIAnalysis : IPIAnalysis
	{
		public PIAnalysis()
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

		[DataMember(Name = "AutoCreated", EmitDefaultValue = false)]
		public bool AutoCreated { get; set; }

		[DataMember(Name = "CategoryNames", EmitDefaultValue = false)]
		public string[] CategoryNames { get; set; }

		[DataMember(Name = "GroupId", EmitDefaultValue = false)]
		public int GroupId { get; set; }

		[DataMember(Name = "HasNotification", EmitDefaultValue = false)]
		public bool HasNotification { get; set; }

		[DataMember(Name = "HasTarget", EmitDefaultValue = false)]
		public bool HasTarget { get; set; }

		[DataMember(Name = "HasTemplate", EmitDefaultValue = false)]
		public bool HasTemplate { get; set; }

		[DataMember(Name = "IsConfigured", EmitDefaultValue = false)]
		public bool IsConfigured { get; set; }

		[DataMember(Name = "IsTimeRuleDefinedByTemplate", EmitDefaultValue = false)]
		public bool IsTimeRuleDefinedByTemplate { get; set; }

		[DataMember(Name = "MaximumQueueSize", EmitDefaultValue = false)]
		public int MaximumQueueSize { get; set; }

		[DataMember(Name = "OutputTime", EmitDefaultValue = false)]
		public string OutputTime { get; set; }

		[DataMember(Name = "Priority", EmitDefaultValue = false)]
		public string Priority { get; set; }

		[DataMember(Name = "PublishResults", EmitDefaultValue = false)]
		public bool PublishResults { get; set; }

		[DataMember(Name = "Status", EmitDefaultValue = false)]
		public string Status { get; set; }

		[DataMember(Name = "TargetWebId", EmitDefaultValue = false)]
		public string TargetWebId { get; set; }

		[DataMember(Name = "TemplateName", EmitDefaultValue = false)]
		public string TemplateName { get; set; }

		[DataMember(Name = "TimeRulePlugInName", EmitDefaultValue = false)]
		public string TimeRulePlugInName { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
