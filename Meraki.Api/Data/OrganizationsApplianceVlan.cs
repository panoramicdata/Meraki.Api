namespace Meraki.Api.Data;

/// <summary>
/// Organizations Appliance Vlan
/// </summary>
[DataContract]
public class OrganizationsApplianceVlan
{
	/// <summary>
	/// Mask used for the subnet of all bound to the template networks. Applicable only for template network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mask")]
	public int Mask { get; set; }

	/// <summary>
	/// The local IP of the appliance on the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "applianceIp")]
	public string ApplianceIp { get; set; } = string.Empty;

	/// <summary>
	/// CIDR of the pool of subnets. Applicable only for template network. Each network bound to the template will automatically pick a subnet from this pool to build its own VLAN.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "cidr")]
	public string Cidr { get; set; } = string.Empty;

	/// <summary>
	/// DHCP boot option to direct boot clients to the server to load the boot file from
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpBootFilename")]
	public string DhcpBootFilename { get; set; } = string.Empty;

	/// <summary>
	/// DHCP boot option to direct boot clients to the server to load the boot file from
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpBootNextServer")]
	public string DhcpBootNextServer { get; set; } = string.Empty;

	/// <summary>
	/// The appliance's handling of DHCP requests on this VLAN. One of: 'Run a DHCP server', 'Relay DHCP to another server' or 'Do not respond to DHCP requests'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpLeaseTime")]
	public string DhcpHandling { get; set; } = string.Empty;

	/// <summary>
	/// The term of DHCP leases if the appliance is running a DHCP server on this VLAN. One of: '30 minutes', '1 hour', '4 hours', '12 hours', '1 day' or '1 week'
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpLeaseTime")]
	public string DhcpLeaseTime { get; set; } = string.Empty;

	/// <summary>
	/// The DNS nameservers used for DHCP responses, either "upstream_dns", "google_dns", "opendns", or a newline seperated string of IP addresses or domain names
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dnsNameservers")]
	public string DnsNameservers { get; set; } = string.Empty;

	/// <summary>
	/// The id of the desired group policy to apply to the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "groupPolicyId")]
	public string GroupPolicyId { get; set; } = string.Empty;

	/// <summary>
	/// The VLAN ID of the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// The interface ID of the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interfaceId")]
	public string InterfaceId { get; set; } = string.Empty;

	/// <summary>
	/// The name of the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The subnet of the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;

	/// <summary>
	/// Type of subnetting of the VLAN. Applicable only for template network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "templateVlanType")]
	public VlanType TemplateVlanType { get; set; }

	/// <summary>
	/// The translated VPN subnet if VPN and VPN subnet translation are enabled on the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "vpnNatSubnet")]
	public string VpnNatSubnet { get; set; } = string.Empty;

	/// <summary>
	/// Use DHCP boot options specified in other properties
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpBootOptionsEnabled")]
	public bool DhcpBootOptionsEnabled { get; set; }

	/// <summary>
	/// The DHCP fixed IP assignments on the VLAN. This should be an object that contains mappings from MAC addresses to objects that themselves each contain "ip" and "name" string fields. See the sample request/response for more details.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "fixedIpAssignments")]
	public OrganizationsApplianceVlanFixedIpAssignments FixedIpAssignments { get; set; } = new();

	/// <summary>
	/// The IPs of the DHCP servers that DHCP requests should be relayed to
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpRelayServerIps")]
	public List<string> DhcpRelayServerIps { get; set; } = [];

	/// <summary>
	/// IPv6 configuration on the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv6")]
	public OrganizationsApplianceVlanIpv6 Ipv6 { get; set; } = new();

	/// <summary>
	/// Mandatory DHCP will enforce that clients connecting to this VLAN must use the IP address assigned by the DHCP server. Clients who use a static IP address won't be able to associate. Only available on firmware versions 17.0 and above
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mandatoryDhcp")]
	public OrganizationsApplianceVlanMandatoryDhcp MandatoryDhcp { get; set; } = new();

	/// <summary>
	/// The list of DHCP options that will be included in DHCP responses. Each object in the list should have "code", "type", and "value" properties.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dhcpOptions")]
	public List<OrganizationsApplianceVlanDhcpOption> DhcpOptions { get; set; } = [];

	/// <summary>
	/// The DHCP reserved IP ranges on the VLAN
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "reservedIpRanges")]
	public List<OrganizationsApplianceVlanReservedIpRange> ReservedIpRanges { get; set; } = [];
}
