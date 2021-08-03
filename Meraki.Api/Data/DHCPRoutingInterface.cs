using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Routing interface DHCP
	/// </summary>
	[DataContract]
	public class DHCPRoutingInterface
	{
		/// <summary>
		/// DHCP mode
		/// </summary>
		[DataMember(Name = "dhcpMode")]
		public string DhcpMode { get; set; } = string.Empty;

		/// <summary>
		/// DHCP lease time
		/// </summary>
		[DataMember(Name = "dhcpLeaseTime")]
		public string DhcpLeaseTime { get; set; } = string.Empty;

		/// <summary>
		/// DNS nameservers option
		/// </summary>
		[DataMember(Name = "dnsNameserversOption")]
		public string DnsNameserversOption { get; set; } = string.Empty;

		/// <summary>
		/// DNS custom nameservers
		/// </summary>
		[DataMember(Name = "dnsCustomNameservers")]
		public List<string> DnsCustomNameservers { get; set; } = new();

		/// <summary>
		/// Boot options enabled
		/// </summary>
		[DataMember(Name = "bootOptionsEnabled")]
		public bool BootOptionsEnabled { get; set; }

		/// <summary>
		/// Boot next server
		/// </summary>
		[DataMember(Name = "bootNextServer")]
		public string BootNextServer { get; set; } = string.Empty;

		/// <summary>
		/// Boot file name
		/// </summary>
		[DataMember(Name = "bootFileName")]
		public string BootFileName { get; set; } = string.Empty;

		/// <summary>
		/// DHCP options
		/// </summary>
		[DataMember(Name = "dhcpOptions")]
		public List<DhcpOption> DhcpOptions { get; set; } = new();

		/// <summary>
		/// Reserved ip ranges
		/// </summary>
		[DataMember(Name = "ReservedIpRanges")]
		public List<ReservedIpRange> ReservedIpRanges { get; set; } = new();

		/// <summary>
		/// Fixed ip assignments
		/// </summary>
		[DataMember(Name = "fixedIpAssignments")]
		public List<FixedIpAssignment> FixedIpAssignments { get; set; } = new();
	}
}
