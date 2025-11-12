namespace Meraki.Api.Data;

/// <summary>
/// Vlan Spec
/// </summary>
[DataContract]
public class VlanSpec
{
	/// <summary>
	/// Gets the name
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = null!;

	/// <summary>
	/// Gets the subnet
	/// </summary>
	[DataMember(Name = "subnet")]
	public string? Subnet { get; set; }

	/// <summary>
	/// Gets the appliance ip
	/// </summary>
	[DataMember(Name = "applianceIp")]
	public string? ApplianceIp { get; set; }

	/// <summary>
	/// Gets the vpn nat subnet
	/// </summary>
	[DataMember(Name = "vpnNatSubnet")]
	public string? VpnNatSubnet { get; set; }

	/// <summary>
	/// Gets the dhcp handling
	/// </summary>
	[DataMember(Name = "dhcpHandling")]
	public DhcpHandling? DhcpHandling { get; set; }

	/// <summary>
	/// Gets the dhcp relay server ips
	/// </summary>
	[DataMember(Name = "dhcpRelayServerIps")]
	public List<string>? DhcpRelayServerIps { get; set; }

	/// <summary>
	/// Gets the dhcp lease time
	/// </summary>
	[DataMember(Name = "dhcpLeaseTime")]
	public DhcpLeaseTime? DhcpLeaseTime { get; set; }

	/// <summary>
	/// Gets the dhcp boot options enabled
	/// </summary>
	[DataMember(Name = "dhcpBootOptionsEnabled")]
	public bool? DhcpBootOptionsEnabled { get; set; }

	/// <summary>
	/// Gets the dhcp boot next server
	/// </summary>
	[DataMember(Name = "dhcpBootNextServer")]
	public string? DhcpBootNextServer { get; set; }

	/// <summary>
	/// Gets the dhcp boot filename
	/// </summary>
	[DataMember(Name = "dhcpBootFilename")]
	public string? DhcpBootFilename { get; set; }

	/// <summary>
	/// Gets the fixed ip assignments
	/// </summary>
	[DataMember(Name = "fixedIpAssignments")]
	public Dictionary<string, FixedIpAssignment>? FixedIpAssignments { get; set; }

	/// <summary>
	/// Gets the reserved ip ranges
	/// </summary>
	[DataMember(Name = "reservedIpRanges")]
	public List<ReservedIpRange>? ReservedIpRanges { get; set; }

	/// <summary>
	/// Gets the dns nameservers
	/// </summary>
	[DataMember(Name = "dnsNameservers")]
	public string? DnsNameservers { get; set; }

	/// <summary>
	/// Gets the dhcp options
	/// </summary>
	[DataMember(Name = "dhcpOptions")]
	public List<DhcpOption>? DhcpOptions { get; set; }

	/// <summary>
	/// Gets the ipv6
	/// </summary>
	[DataMember(Name = "ipv6")]
	public VlanIpv6? Ipv6 { get; set; }

	/// <summary>
	/// Only settable for templates
	/// </summary>
	[DataMember(Name = "templateVlanType")]
	public string? TemplateVlanType { get; set; }

	/// <summary>
	/// Cidr
	/// </summary>
	[DataMember(Name = "cidr")]
	public string? Cidr { get; set; }

	/// <summary>
	/// Mask
	/// </summary>
	[DataMember(Name = "mask")]
	public int? Mask { get; set; }

	/// <summary>
	/// GroupPolicyId
	/// </summary>
	[DataMember(Name = "groupPolicyId")]
	public string? GroupPolicyId { get; set; }

	/// <summary>
	/// Mandatory DHCP will enforce that clients connecting to this VLAN must use the IP address assigned by the DHCP server. Clients who use a static IP address won't be able to associate. Only available on firmware versions 17.0 and above
	/// </summary>
	[DataMember(Name = "mandatoryDhcp")]
	public MandatoryDhcp? MandatoryDhcp { get; set; }
}
