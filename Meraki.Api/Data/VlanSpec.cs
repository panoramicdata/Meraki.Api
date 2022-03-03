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
	public DhcpHandling DhcpHandling { get; set; }

	[DataMember(Name = "dhcpRelayServerIps")]
	public List<string> DhcpRelayServerIps { get; set; } = null!;

	[DataMember(Name = "dhcpLeaseTime")]
	public DhcpLeaseTime DhcpLeaseTime { get; set; }

	[DataMember(Name = "dhcpBootOptionsEnabled")]
	public bool DhcpBootOptionsEnabled { get; set; }

	[DataMember(Name = "dhcpBootNextServer")]
	public string DhcpBootNextServer { get; set; } = null!;

	[DataMember(Name = "dhcpBootFilename")]
	public string DhcpBootFilename { get; set; } = null!;

	[DataMember(Name = "fixedIpAssignments")]
	public Dictionary<string, FixedIpAssignment> FixedIpAssignments { get; set; } = null!;

	[DataMember(Name = "reservedIpRanges")]
	public List<ReservedIpRange> ReservedIpRanges { get; set; } = null!;

	[DataMember(Name = "dnsNameservers")]
	public string DnsNameservers { get; set; } = null!;

	[DataMember(Name = "dhcpOptions")]
	public List<DhcpOption> DhcpOptions { get; set; } = null!;
}
