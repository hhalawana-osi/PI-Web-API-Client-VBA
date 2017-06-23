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

	[Guid("9FD8EB87-E2B0-45AE-A47F-1E2248B840CE")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIUserInfo
	{
		[DispId(1)]
		string IdentityType { get; set; }

		[DispId(2)]
		string Name { get; set; }

		[DispId(3)]
		bool IsAuthenticated { get; set; }

		[DispId(4)]
		string SID { get; set; }

		[DispId(5)]
		string ImpersonationLevel { get; set; }

	}

	[Guid("5E628B68-8D6A-4B8C-BF8F-04E62A3FDDAE")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIUserInfo))]
	[ProgId("PIWebAPIWrapper.PIUserInfo")]
	[DataContract]

	public class PIUserInfo : IPIUserInfo
	{
		public PIUserInfo()
		{
		}

		[DataMember(Name = "IdentityType", EmitDefaultValue = false)]
		public string IdentityType { get; set; }

		[DataMember(Name = "Name", EmitDefaultValue = false)]
		public string Name { get; set; }

		[DataMember(Name = "IsAuthenticated", EmitDefaultValue = false)]
		public bool IsAuthenticated { get; set; }

		[DataMember(Name = "SID", EmitDefaultValue = false)]
		public string SID { get; set; }

		[DataMember(Name = "ImpersonationLevel", EmitDefaultValue = false)]
		public string ImpersonationLevel { get; set; }

	}
}
