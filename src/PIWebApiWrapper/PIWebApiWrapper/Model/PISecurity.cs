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

	[Guid("8AB1F8E6-8EBC-4F63-9055-55580A9B6B60")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPISecurity
	{
		[DispId(1)]
		bool CanAnnotate { get; set; }

		[DispId(2)]
		bool CanDelete { get; set; }

		[DispId(3)]
		bool CanExecute { get; set; }

		[DispId(4)]
		bool CanRead { get; set; }

		[DispId(5)]
		bool CanReadData { get; set; }

		[DispId(6)]
		bool CanSubscribe { get; set; }

		[DispId(7)]
		bool CanSubscribeOthers { get; set; }

		[DispId(8)]
		bool CanWrite { get; set; }

		[DispId(9)]
		bool CanWriteData { get; set; }

		[DispId(10)]
		bool HasAdmin { get; set; }

		[DispId(11)]
		string[] Rights { get; set; }

	}

	[Guid("EA053E76-0075-43B4-9552-C2707A79F673")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPISecurity))]
	[ProgId("PIWebAPIWrapper.PISecurity")]
	[DataContract]

	public class PISecurity : IPISecurity
	{
		public PISecurity()
		{
		}

		[DataMember(Name = "CanAnnotate", EmitDefaultValue = false)]
		public bool CanAnnotate { get; set; }

		[DataMember(Name = "CanDelete", EmitDefaultValue = false)]
		public bool CanDelete { get; set; }

		[DataMember(Name = "CanExecute", EmitDefaultValue = false)]
		public bool CanExecute { get; set; }

		[DataMember(Name = "CanRead", EmitDefaultValue = false)]
		public bool CanRead { get; set; }

		[DataMember(Name = "CanReadData", EmitDefaultValue = false)]
		public bool CanReadData { get; set; }

		[DataMember(Name = "CanSubscribe", EmitDefaultValue = false)]
		public bool CanSubscribe { get; set; }

		[DataMember(Name = "CanSubscribeOthers", EmitDefaultValue = false)]
		public bool CanSubscribeOthers { get; set; }

		[DataMember(Name = "CanWrite", EmitDefaultValue = false)]
		public bool CanWrite { get; set; }

		[DataMember(Name = "CanWriteData", EmitDefaultValue = false)]
		public bool CanWriteData { get; set; }

		[DataMember(Name = "HasAdmin", EmitDefaultValue = false)]
		public bool HasAdmin { get; set; }

		[DataMember(Name = "Rights", EmitDefaultValue = false)]
		public string[] Rights { get; set; }

	}
}
