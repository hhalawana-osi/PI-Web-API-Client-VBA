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

	[Guid("EBA9E500-2C6D-49F4-91A4-8A0E2C52CEFF")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPITableData
	{
		[DispId(1)]
		object Columns { get; set; }

		[DispId(2)]
		object[] Rows { get; set; }

	}

	[Guid("347291B9-2FE1-4E3C-A520-58F1CA618A83")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPITableData))]
	[ProgId("PIWebAPIWrapper.PITableData")]
	[DataContract]

	public class PITableData : IPITableData
	{
		public PITableData()
		{
		}

		[DataMember(Name = "Columns", EmitDefaultValue = false)]
		public object Columns { get; set; }

		[DataMember(Name = "Rows", EmitDefaultValue = false)]
		public object[] Rows { get; set; }

	}
}
