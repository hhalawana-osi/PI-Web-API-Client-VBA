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

	[Guid("B0BA8D39-E413-4BAB-8BAC-78317F0457FE")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIPoint
	{
		[DispId(1)]
		string WebId { get; set; }

		[DispId(2)]
		int Id { get; set; }

		[DispId(3)]
		string Name { get; set; }

		[DispId(4)]
		string Path { get; set; }

		[DispId(5)]
		string Descriptor { get; set; }

		[DispId(6)]
		string PointClass { get; set; }

		[DispId(7)]
		string PointType { get; set; }

		[DispId(8)]
		string DigitalSetName { get; set; }

		[DispId(9)]
		string EngineeringUnits { get; set; }

		[DispId(10)]
		bool Step { get; set; }

		[DispId(11)]
		bool Future { get; set; }

		[DispId(12)]
		object Links { get; set; }

	}

	[Guid("76EFF458-169E-45B0-9EE8-50A812178C10")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIPoint))]
	[ProgId("PIWebAPIWrapper.PIPoint")]
	[DataContract]

	public class PIPoint : IPIPoint
	{
		public PIPoint()
		{
		}

		[DataMember(Name = "WebId", EmitDefaultValue = false)]
		public string WebId { get; set; }

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public int Id { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "Path", EmitDefaultValue = false)]
		public string Path { get; set; }

		[DataMember(Name = "Descriptor", EmitDefaultValue = false)]
		public string Descriptor { get; set; }

		[DataMember(Name = "PointClass", EmitDefaultValue = false)]
		public string PointClass { get; set; }

		[DataMember(Name = "PointType", EmitDefaultValue = false)]
		public string PointType { get; set; }

		[DataMember(Name = "DigitalSetName", EmitDefaultValue = false)]
		public string DigitalSetName { get; set; }

		[DataMember(Name = "EngineeringUnits", EmitDefaultValue = false)]
		public string EngineeringUnits { get; set; }

		[DataMember(Name = "Step", EmitDefaultValue = false)]
		public bool Step { get; set; }

		[DataMember(Name = "Future", EmitDefaultValue = false)]
		public bool Future { get; set; }

		[DataMember(Name = "Links", EmitDefaultValue = false)]
		public object Links { get; set; }

	}
}
