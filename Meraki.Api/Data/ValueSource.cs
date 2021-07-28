using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Source
	/// </summary>
	[DataContract]
	public partial class ValueSource
	{
		/// <summary>
		/// Port
		/// </summary>
		[DataMember(Name = "port")]
		public string Port { get; set; } = string.Empty;

		/// <summary>
		/// Cidr
		/// </summary>
		[DataMember(Name = "cidr")]
		public string? Cidr { get; set; }

		/// <summary>
		/// Vlan
		/// </summary>
		[DataMember(Name = "cidr")]
		public int? Vlan { get; set; }

		/// <summary>
		/// Host
		/// </summary>
		[DataMember(Name = "host")]
		public int? Host { get; set; }
	}
}
