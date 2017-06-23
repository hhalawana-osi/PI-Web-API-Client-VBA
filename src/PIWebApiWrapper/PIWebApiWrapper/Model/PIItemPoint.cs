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

	[Guid("FF3FAC34-907A-4CB6-936B-CB582D9FC1E9")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIItemPoint
	{
		[DispId(1)]
		string Identifier { get; set; }

		[DispId(2)]
		string IdentifierType { get; set; }

		[DispId(3)]
		PIPoint Object { get; set; }

		[DispId(4)]
		PIErrors Exception { get; set; }

	}

	[Guid("FAFD9FE9-CF36-454D-BDBC-7D19686AC3F7")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIItemPoint))]
	[ProgId("PIWebAPIWrapper.PIItemPoint")]
	[DataContract]

	public class PIItemPoint : IPIItemPoint
	{
		public PIItemPoint()
		{
		}

		[DataMember(Name = "Identifier", EmitDefaultValue = false)]
		public string Identifier { get; set; }

		[DataMember(Name = "IdentifierType", EmitDefaultValue = false)]
		public string IdentifierType { get; set; }

		[DataMember(Name = "Object", EmitDefaultValue = false)]
		public PIPoint Object { get; set; }

		[DataMember(Name = "Exception", EmitDefaultValue = false)]
		public PIErrors Exception { get; set; }

	}
}
