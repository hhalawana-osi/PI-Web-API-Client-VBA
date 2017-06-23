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

	[Guid("5E2DEFE1-F6C9-4504-A1ED-AF0402CDBAB9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISystemStatus
	{
		[DispId(1)]
		double UpTimeInMinutes { get; set; }

		[DispId(2)]
		string State { get; set; }

		[DispId(3)]
		int CacheInstances { get; set; }

	}

	[Guid("7DE61031-4FB2-44E4-AAFA-AA37CA5AC041")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISystemStatus))]
	[ProgId("PIWebAPIWrapper.PISystemStatus")]
	[DataContract]

	public class PISystemStatus : IPISystemStatus
	{
		public PISystemStatus()
		{
		}

		[DataMember(Name = "UpTimeInMinutes", EmitDefaultValue = false)]
		public double UpTimeInMinutes { get; set; }

		[DataMember(Name = "State", EmitDefaultValue = false)]
		public string State { get; set; }

		[DataMember(Name = "CacheInstances", EmitDefaultValue = false)]
		public int CacheInstances { get; set; }

	}
}
