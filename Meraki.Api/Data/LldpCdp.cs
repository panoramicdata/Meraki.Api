using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// LLDP CDP
	/// </summary>
	[DataContract]
	public class LldpCdp
	{
		/// <summary>
		/// Source mac
		/// </summary>
		[DataMember(Name = "sourceMac")]
		public string SourceMac { get; set; } = string.Empty;

		/// <summary>
		/// Ports
		/// </summary>
		[DataMember(Name = "ports")]
		public LldpCdpPorts Ports { get; set; } = new();
	}
}
