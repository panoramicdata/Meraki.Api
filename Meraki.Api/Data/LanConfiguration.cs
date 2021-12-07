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
	/// FixedIpAssignments - No documentation
	/// </summary>
	[DataMember(Name = "fixedIpAssignments")]
	public object FixedIpAssignments { get; set; } = new();

	/// <summary>
	/// ReservedIpRanges - No documentation
	/// </summary>
	[DataMember(Name = "reservedIpRanges")]
	public List<object> ReservedIpRanges { get; set; } = new();

	/// <summary>
	/// DnsNameservers - No documentation
	/// </summary>
	[DataMember(Name = "dnsNameservers")]
	public string DnsNameservers { get; set; } = string.Empty;

	/// <summary>
	/// DnsCustomNameservers - No documentation
	/// </summary>
	[DataMember(Name = "dnsCustomNameservers")]
	public List<object> DnsCustomNameservers { get; set; } = new();

	/// <summary>
	/// DhcpHandling - No documentation
	/// </summary>
	[DataMember(Name = "dhcpHandling")]
	public string DhcpHandling { get; set; } = string.Empty;

	/// <summary>
	/// DhcpLeaseTime - No documentation
	/// </summary>
	[DataMember(Name = "dhcpLeaseTime")]
	public string DhcpLeaseTime { get; set; } = string.Empty;

	/// <summary>
	/// DhcpBootOptionsEnabled - No documentation
	/// </summary>
	[DataMember(Name = "dhcpBootOptionsEnabled")]
	public bool DhcpBootOptionsEnabled { get; set; }

	/// <summary>
	/// DhcpOptions - No documentation
	/// </summary>
	[DataMember(Name = "dhcpOptions")]
	public List<object> DhcpOptions { get; set; } = new();

	/// <summary>
	/// mandatoryDhcp - No documentation
	/// </summary>
	[DataMember(Name = "mandatoryDhcp")]
	public MandatoryDhcp MandatoryDhcp { get; set; } = new();
}
