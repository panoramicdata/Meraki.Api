namespace Meraki.Api.Data;

/// <summary>
/// CreateNetworkVlan
/// </summary>
[DataContract]
public class VlanCreationRequest
{
	/// <summary>
	/// The VLAN ID of the new VLAN (must be between 1 and 4094)
	/// </summary>
	/// <value>The VLAN ID of the new VLAN (must be between 1 and 4094)</value>
	[DataMember(Name = "id")]
	public string Id { get; set; } = null!;

	/// <summary>
	/// The name of the new VLAN
	/// </summary>
	/// <value>The name of the new VLAN</value>
	[DataMember(Name = "name")]
	public string Name { get; set; } = null!;

	/// <summary>
	/// The subnet of the VLAN
	/// </summary>
	/// <value>The subnet of the VLAN</value>
	[DataMember(Name = "subnet")]
	public string? Subnet { get; set; }

	/// <summary>
	/// The local IP of the appliance on the VLAN
	/// </summary>
	/// <value>The local IP of the appliance on the VLAN</value>
	[DataMember(Name = "applianceIp")]
	public string? ApplianceIp { get; set; }

	/// <summary>
	/// The id of the desired group policy to apply to the VLAN
	/// </summary>
	/// <value>The id of the desired group policy to apply to the VLAN</value>
	[DataMember(Name = "groupPolicyId")]
	public string? GroupPolicyId { get; set; }

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
	/// Template VLAN Type
	/// </summary>
	[DataMember(Name = "templateVlanType")]
	public string? TemplateVlanType { get; set; }

	/// <summary>
	/// Ipv6
	/// </summary>
	[DataMember(Name = "ipv6")]
	public VlanIpv6? Ipv6 { get; set; }

	/// <summary>
	/// Mandatory DHCP will enforce that clients connecting to this VLAN must use the IP address assigned by the DHCP server. Clients who use a static IP address won't be able to associate. Only available on firmware versions 17.0 and above
	/// </summary>
	[DataMember(Name = "mandatoryDhcp")]
	public MandatoryDhcp? MandatoryDhcp { get; set; }

	/// <summary>
	/// The appliance's handling of DHCP requests on this VLAN. One of: 'Run a DHCP server', 'Relay DHCP to another server' or 'Do not respond to DHCP requests'
	/// </summary>
	[DataMember(Name = "dhcpHandling")]
	public DhcpHandling? DhcpHandling { get; set; }

	/// <summary>
	/// The term of DHCP leases if the appliance is running a DHCP server on this VLAN. One of: '30 minutes', '1 hour', '4 hours', '12 hours', '1 day' or '1 week'
	/// </summary>
	[DataMember(Name = "dhcpLeaseTime")]
	public DhcpLeaseTime? DhcpLeaseTime { get; set; }

	/// <summary>
	/// Use DHCP boot options specified in other properties
	/// </summary>
	[DataMember(Name = "dhcpBootOptionsEnabled")]
	public bool? DhcpBootOptionsEnabled { get; set; }

	/// <summary>
	/// The list of DHCP options that will be included in DHCP responses. Each object in the list should have "code", "type", and "value" properties.
	/// </summary>
	[DataMember(Name = "dhcpOptions")]
	public List<DhcpOption>? DhcpOptions { get; set; }
}
