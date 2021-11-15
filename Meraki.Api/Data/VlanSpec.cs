namespace Meraki.Api.Data;

[DataContract]
public class VlanSpec
{
	[DataMember(Name = "name")]
	public string Name { get; set; } = null!;

	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = null!;

	[DataMember(Name = "applianceIp")]
	public string ApplianceIp { get; set; } = null!;

	[DataMember(Name = "vpnNatSubnet")]
	public string VpnNatSubnet { get; set; } = null!;

	[DataMember(Name = "dhcpHandling")]
	public string DhcpHandling { get; set; } = null!;

	[DataMember(Name = "dhcpRelayServerIps")]
	public List<string> DhcpRelayServerIps { get; set; } = null!;

	[DataMember(Name = "dhcpLeaseTime")]
	public string DhcpLeaseTime { get; set; } = null!;

	[DataMember(Name = "dhcpBootOptionsEnabled")]
	public string DhcpBootOptionsEnabled { get; set; } = null!;

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
	public string DhcpOptions { get; set; } = null!;
}
