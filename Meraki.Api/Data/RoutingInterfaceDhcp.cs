using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Routing interface DHCP
/// </summary>
[DataContract]
public class RoutingInterfaceDhcp
{
	/// <summary>
	/// The DHCP mode options for the switch interface ('dhcpDisabled', 'dhcpRelay' or 'dhcpServer')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpMode")]
	public string DhcpMode { get; set; } = string.Empty;

	/// <summary>
	/// The DHCP lease time config for the dhcp server running on switch interface ('30 minutes', '1 hour', '4 hours', '12 hours', '1 day' or '1 week')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpLeaseTime")]
	public string DhcpLeaseTime { get; set; } = string.Empty;

	/// <summary>
	/// The DHCP name server option for the dhcp server running on the switch interface ('googlePublicDns', 'openDns' or 'custom')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dnsNameserversOption")]
	public string DnsNameserversOption { get; set; } = string.Empty;

	/// <summary>
	/// The DHCP name server IPs when DHCP name server option is 'custom'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dnsCustomNameservers")]
	public List<string> DnsCustomNameservers { get; set; } = new();

	/// <summary>
	/// Enable DHCP boot options to provide PXE boot options configs for the dhcp server running on the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "bootOptionsEnabled")]
	public bool BootOptionsEnabled { get; set; }

	/// <summary>
	/// The PXE boot server IP for the DHCP server running on the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "bootNextServer")]
	public string BootNextServer { get; set; } = string.Empty;

	/// <summary>
	/// The PXE boot server filename for the DHCP server running on the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "bootFileName")]
	public string BootFileName { get; set; } = string.Empty;

	/// <summary>
	/// Array of DHCP options consisting of code, type and value for the DHCP server running on the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpOptions")]
	public List<DhcpOption> DhcpOptions { get; set; } = new();

	/// <summary>
	/// Array of DHCP reserved IP assignments for the DHCP server running on the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ReservedIpRanges")]
	public List<ReservedIpRange> ReservedIpRanges { get; set; } = new();

	/// <summary>
	/// Array of DHCP fixed IP assignments for the DHCP server running on the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "fixedIpAssignments")]
	public List<FixedIpAssignment> FixedIpAssignments { get; set; } = new();
}
