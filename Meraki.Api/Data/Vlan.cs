using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A VLAN
	/// </summary>
	[DataContract]
	public class Vlan : NamedItem
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = null!;


		/// <summary>
		/// Network Id
		/// </summary>
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Appliance IP
		/// </summary>
		[DataMember(Name = "applianceIp")]
		public string ApplianceIp { get; set; } = string.Empty;

		/// <summary>
		/// Subnet
		/// </summary>
		[DataMember(Name = "subnet")]
		public string Subnet { get; set; } = string.Empty;

		/// <summary>
		/// Fixed IP assignments
		/// </summary>
		[DataMember(Name = "fixedIpAssignment")]
		public Dictionary<string, FixedIpAssignment> FixedIpAssignments { get; set; } = new Dictionary<string, FixedIpAssignment>();

		/// <summary>
		/// Reserved IP ranges
		/// </summary>
		[DataMember(Name = "reservedIpRanges")]
		public List<ReservedIpRange> ReservedIpRanges { get; set; } = new List<ReservedIpRange>();

		/// <summary>
		/// DNS nameservers
		/// </summary>
		[DataMember(Name = "dnsNameservers")]
		public string DnsNameservers { get; set; } = string.Empty;

		/// <summary>
		/// DHCP handling
		/// </summary>
		[DataMember(Name = "dhcpHandling")]
		public string DhcpHandling { get; set; } = string.Empty;

		/// <summary>
		/// DHCP lease time
		/// </summary>
		[DataMember(Name = "dhcpLeaseTime")]
		public string DhcpLeaseTime { get; set; } = string.Empty;

		/// <summary>
		/// DHCP Boot options enabled
		/// </summary>
		[DataMember(Name = "dhcpBootOptionsEnabled")]
		public bool DhcpBootOptionsEnabled { get; set; }

		/// <summary>
		/// DHCP boot next server
		/// </summary>
		[DataMember(Name = "dhcpBootNextServer")]
		public object DhcpBootNextServer { get; set; }

		/// <summary>
		/// DHCP boot filename
		/// </summary>
		[DataMember(Name = "dhcpBootFilename")]
		public object DhcpBootFilename { get; set; }

		/// <summary>
		/// DHCP options
		/// </summary>
		[DataMember(Name = "dhcpOptions")]
		public List<DhcpOption> DhcpOptions { get; set; } = new List<DhcpOption>();
	}
}