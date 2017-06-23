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

	[Guid("6D04F346-AA6B-4EB4-A621-97D8C7E1E6FF")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIErrors
	{
		[DispId(1)]
		string[] Errors { get; set; }

	}

	[Guid("CC5E3710-1754-4E7A-9422-16DF0D245623")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIErrors))]
	[ProgId("PIWebAPIWrapper.PIErrors")]
	[DataContract]

	public class PIErrors : IPIErrors
	{
		public PIErrors()
		{
		}

		[DataMember(Name = "Errors", EmitDefaultValue = false)]
		public string[] Errors { get; set; }

	}
}
