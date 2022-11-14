namespace Meraki.Api.Data;

[DataContract]
public class VlanSpec
{
	[DataMember(Name = "name")]
	public string Name { get; set; } = null!;

	[DataMember(Name = "subnet")]
	public string? Subnet { get; set; }

	[DataMember(Name = "applianceIp")]
	public string? ApplianceIp { get; set; }

	[DataMember(Name = "vpnNatSubnet")]
	public string? VpnNatSubnet { get; set; }

	[DataMember(Name = "dhcpHandling")]
	public DhcpHandling? DhcpHandling { get; set; }

	[DataMember(Name = "dhcpRelayServerIps")]
	public List<string>? DhcpRelayServerIps { get; set; }

	[DataMember(Name = "dhcpLeaseTime")]
	public DhcpLeaseTime? DhcpLeaseTime { get; set; }

	[DataMember(Name = "dhcpBootOptionsEnabled")]
	public bool? DhcpBootOptionsEnabled { get; set; }

	[DataMember(Name = "dhcpBootNextServer")]
	public string? DhcpBootNextServer { get; set; }

	[DataMember(Name = "dhcpBootFilename")]
	public string? DhcpBootFilename { get; set; }

	[DataMember(Name = "fixedIpAssignments")]
	public Dictionary<string, FixedIpAssignment>? FixedIpAssignments { get; set; }

	[DataMember(Name = "reservedIpRanges")]
	public List<ReservedIpRange>? ReservedIpRanges { get; set; }

	[DataMember(Name = "dnsNameservers")]
	public string? DnsNameservers { get; set; }

	[DataMember(Name = "dhcpOptions")]
	public List<DhcpOption>? DhcpOptions { get; set; }

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
}
