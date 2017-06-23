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

	[Guid("2AD8ED1E-AD74-486D-8456-3F40B2B5C48E")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPICacheInstance
	{
		[DispId(1)]
		string Id { get; set; }

		[DispId(2)]
		string LastRefreshTime { get; set; }

		[DispId(3)]
		string WillRefreshAfter { get; set; }

		[DispId(4)]
		string ScheduledExpirationTime { get; set; }

		[DispId(5)]
		string User { get; set; }

	}

	[Guid("E51433F8-BDE8-4DF0-B1DD-B422EF0B75B3")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPICacheInstance))]
	[ProgId("PIWebAPIWrapper.PICacheInstance")]
	[DataContract]

	public class PICacheInstance : IPICacheInstance
	{
		public PICacheInstance()
		{
		}

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "LastRefreshTime", EmitDefaultValue = false)]
		public string LastRefreshTime { get; set; }

		[DataMember(Name = "WillRefreshAfter", EmitDefaultValue = false)]
		public string WillRefreshAfter { get; set; }

		[DataMember(Name = "ScheduledExpirationTime", EmitDefaultValue = false)]
		public string ScheduledExpirationTime { get; set; }

		[DataMember(Name = "User", EmitDefaultValue = false)]
		public string User { get; set; }

	}
}
