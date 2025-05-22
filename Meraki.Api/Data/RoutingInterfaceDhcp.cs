﻿namespace Meraki.Api.Data;

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
	/// The DHCP relay server IPs to which DHCP packets would get relayed for the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpRelayServerIps")]
	public List<string>? DhcpRelayServerIps { get; set; }

	/// <summary>
	/// The DHCP lease time config for the dhcp server running on switch interface ('30 minutes', '1 hour', '4 hours', '12 hours', '1 day' or '1 week')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpLeaseTime")]
	public string? DhcpLeaseTime { get; set; }

	/// <summary>
	/// The DHCP name server option for the dhcp server running on the switch interface ('googlePublicDns', 'openDns' or 'custom')
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dnsNameserversOption")]
	public string? DnsNameserversOption { get; set; }

	/// <summary>
	/// The DHCP name server IPs when DHCP name server option is 'custom'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dnsCustomNameservers")]
	public List<string>? DnsCustomNameservers { get; set; }

	/// <summary>
	/// Enable DHCP boot options to provide PXE boot options configs for the dhcp server running on the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "bootOptionsEnabled")]
	public bool? BootOptionsEnabled { get; set; }

	/// <summary>
	/// The PXE boot server IP for the DHCP server running on the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "bootNextServer")]
	public string? BootNextServer { get; set; }

	/// <summary>
	/// The PXE boot server filename for the DHCP server running on the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "bootFileName")]
	public string? BootFileName { get; set; }

	/// <summary>
	/// Array of DHCP options consisting of code, type and value for the DHCP server running on the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpOptions")]
	public List<DhcpOption>? DhcpOptions { get; set; }

	/// <summary>
	/// Array of DHCP reserved IP assignments for the DHCP server running on the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "reservedIpRanges")]
	public List<ReservedIpRange>? ReservedIpRanges { get; set; }

	/// <summary>
	/// Array of DHCP fixed IP assignments for the DHCP server running on the switch interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "fixedIpAssignments")]
	public List<FixedIpAssignment>? FixedIpAssignments { get; set; }
}
