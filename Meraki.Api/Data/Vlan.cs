namespace Meraki.Api.Data;

/// <summary>
/// A VLAN
/// </summary>
[DataContract]
public class Vlan : NamedIdentifiedItem
{
	/// <summary>
	/// Network Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[ApiForeignKey(typeof(Network))]
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
	/// groupPolicyId
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "groupPolicyId")]
	public string GroupPolicyId { get; set; } = string.Empty;

	/// <summary>
	/// Fixed IP assignments
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "fixedIpAssignments")]
	public Dictionary<string, FixedIpAssignment> FixedIpAssignments { get; set; } = new Dictionary<string, FixedIpAssignment>();

	/// <summary>
	/// Reserved IP ranges
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "reservedIpRanges")]
	public List<ReservedIpRange> ReservedIpRanges { get; set; } = new List<ReservedIpRange>();

	/// <summary>
	/// DNS nameservers
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dnsNameservers")]
	public string DnsNameServers { get; set; } = string.Empty;

	/// <summary>
	/// DHCP handling
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpHandling")]
	public DhcpHandling DhcpHandling { get; set; }

	/// <summary>
	/// DHCP lease time
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpLeaseTime")]
	public DhcpLeaseTime DhcpLeaseTime { get; set; }

	/// <summary>
	/// DHCP Boot options enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpBootOptionsEnabled")]
	public bool DhcpBootOptionsEnabled { get; set; }

	/// <summary>
	/// DHCP boot next server
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpBootNextServer")]
	public string DhcpBootNextServer { get; set; } = string.Empty;

	/// <summary>
	/// DHCP boot filename
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpBootFilename")]
	public string DhcpBootFilename { get; set; } = string.Empty;

	/// <summary>
	/// DHCP options
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpOptions")]
	public List<DhcpOption> DhcpOptions { get; set; } = new List<DhcpOption>();

	/// <summary>
	/// DHCP relay server IPs
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dhcpRelayServerIps")]
	public List<string> DhcpRelayServerIps { get; set; } = new List<string>();

	/// <summary>
	/// Template VLAN Type
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "templateVlanType")]
	public string? TemplateVlanType { get; set; }

	/// <summary>
	/// Cidr
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "cidr")]
	public string? Cidr { get; set; }

	/// <summary>
	/// Mask
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "mask")]
	public int? Mask { get; set; }
}
