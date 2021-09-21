using Meraki.Api.Attributes;
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
		[ApiAccess(ApiAccess.ReadWrite)]
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
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "applianceIp")]
		public string ApplianceIp { get; set; } = string.Empty;

		/// <summary>
		/// Subnet
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "subnet")]
		public string Subnet { get; set; } = string.Empty;

		/// <summary>
		/// Fixed IP assignments
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "fixedIpAssignments")]
		public Dictionary<string, FixedIpAssignment> FixedIpAssignments { get; set; } = new Dictionary<string, FixedIpAssignment>();

		/// <summary>
		/// Reserved IP ranges
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "reservedIpRanges")]
		public List<ReservedIpRange> ReservedIpRanges { get; set; } = new List<ReservedIpRange>();

		/// <summary>
		/// DNS nameservers
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dnsNameservers")]
		public string DnsNameServers { get; set; } = string.Empty;

		/// <summary>
		/// DHCP handling
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dhcpHandling")]
		public string DhcpHandling { get; set; } = string.Empty;

		/// <summary>
		/// DHCP lease time
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dhcpLeaseTime")]
		public DhcpLeaseTime DhcpLeaseTime { get; set; }

		/// <summary>
		/// DHCP Boot options enabled
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dhcpBootOptionsEnabled")]
		public bool DhcpBootOptionsEnabled { get; set; }

		/// <summary>
		/// DHCP boot next server
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dhcpBootNextServer")]
		public object DhcpBootNextServer { get; set; } = new object(); // Not clear if this should be a string

		/// <summary>
		/// DHCP boot filename
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dhcpBootFilename")]
		public object DhcpBootFilename { get; set; } = new object(); // Not clear if this should be a string

		/// <summary>
		/// DHCP options
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dhcpOptions")]
		public List<DhcpOption> DhcpOptions { get; set; } = new List<DhcpOption>();

		/// <summary>
		/// DHCP relay server IPs
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dhcpRelayServerIps")]
		public List<string> DhcpRelayServerIps { get; set; } = new List<string>();
	}
}