namespace Meraki.Api.Data;

/// <summary>
/// LAN configuration
/// </summary>
[DataContract]
public class LanConfiguration
{
	/// <summary>
	/// Subnet
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;

	/// <summary>
	/// Appliance ip
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "applianceIp")]
	public string ApplianceIp { get; set; } = string.Empty;

	/// <summary>
	/// ipV6
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipv6")]

	public LanConfigurationIpv6? Ipv6 { get; set; }

	/// <summary>
	/// FixedIpAssignments - No documentation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fixedIpAssignments")]
	public object FixedIpAssignments { get; set; } = new();

	/// <summary>
	/// ReservedIpRanges - No documentation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "reservedIpRanges")]
	public List<object> ReservedIpRanges { get; set; } = [];

	/// <summary>
	/// DnsNameservers - No documentation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dnsNameservers")]
	public string DnsNameservers { get; set; } = string.Empty;

	/// <summary>
	/// DnsCustomNameservers - No documentation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dnsCustomNameservers")]
	public List<object> DnsCustomNameservers { get; set; } = [];

	/// <summary>
	/// DhcpHandling - No documentation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpHandling")]
	public string DhcpHandling { get; set; } = string.Empty;

	/// <summary>
	/// DhcpLeaseTime - No documentation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpLeaseTime")]
	public string DhcpLeaseTime { get; set; } = string.Empty;

	/// <summary>
	/// DhcpBootOptionsEnabled - No documentation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpBootOptionsEnabled")]
	public bool DhcpBootOptionsEnabled { get; set; }

	/// <summary>
	/// DhcpOptions - No documentation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpOptions")]
	public List<object> DhcpOptions { get; set; } = [];

	/// <summary>
	/// mandatoryDhcp - No documentation
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mandatoryDhcp")]
	public MandatoryDhcp MandatoryDhcp { get; set; } = new();
}
