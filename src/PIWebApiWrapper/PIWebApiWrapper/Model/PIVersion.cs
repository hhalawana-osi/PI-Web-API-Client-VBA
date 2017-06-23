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

	[Guid("B305C419-6385-4DDA-A423-50F89C872B67")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIVersion
	{
		[DispId(1)]
		string FullVersion { get; set; }

		[DispId(2)]
		string MajorMinorRevision { get; set; }

		[DispId(3)]
		string Build { get; set; }

	}

	[Guid("2D616CB5-510C-4908-967F-043B43FABD60")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIVersion))]
	[ProgId("PIWebAPIWrapper.PIVersion")]
	[DataContract]

	public class PIVersion : IPIVersion
	{
		public PIVersion()
		{
		}

		[DataMember(Name = "FullVersion", EmitDefaultValue = false)]
		public string FullVersion { get; set; }

		[DataMember(Name = "MajorMinorRevision", EmitDefaultValue = false)]
		public string MajorMinorRevision { get; set; }

		[DataMember(Name = "Build", EmitDefaultValue = false)]
		public string Build { get; set; }

	}
}
