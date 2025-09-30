namespace Meraki.Api.Data;

/// <summary>
/// Routing interface create request
/// </summary>
[DataContract]
public class RoutingInterfaceCreateRequest : NamedItem
{
	/// <summary>
	/// The VLAN this routed interface is on. VLAN must be between 1 and 4094.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlanId")]
	public int VlanId { get; set; }

	/// <summary>
	/// Required. The next hop for any traffic that isn't going to a directly connected subnet or over a static route. This IP address must exist in a subnet with a routed interface.
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "defaultGateway")]
	public string DefaultGateway { get; set; } = string.Empty;

	/// <summary>
	/// Required. The IP address this switch will use for layer 3 routing on this VLAN or subnet. This cannot be the same as the switch's management IP.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interfaceIp")]
	public string InterfaceIp { get; set; } = string.Empty;

	/// <summary>
	/// Enable multicast support if, multicast routing between VLANs is required. Options are, 'disabled', 'enabled' or 'IGMP snooping querier'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "multicastRouting")]
	public MulticastRouting? MulticastRouting { get; set; }

	/// <summary>
	/// Required. The network that this routed interface is on, in CIDR notation (ex. 10.1.1.0/24).
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;

	/// <summary>
	/// Switch Port ID when in Routed mode (CS 17.18 or higher required)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "switchPortId")]
	public string? SwitchPortId { get; set; }

	/// <summary>
	/// The loopback settings of the interface. Documentation incomplete 2025-09-29
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "loopback")]
	public object? Loopback { get; set; }

	/// <summary>
	/// Whether this is the switch's IPv4 uplink
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "uplinkV4")]
	public bool? UplinkV4 { get; set; }

	/// <summary>
	/// Whether this is the switch's IPv6 uplink
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "uplinkV6")]
	public bool? UplinkV6 { get; set; }

	/// <summary>
	/// L3 Interface mode, can be one of 'vlan', 'routed' or 'loopback'. Default is 'vlan'. CS 17.18 or higher is required for 'routed' mode.
	/// enum = ["loopback", "routed", "vlan"]
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "mode")]
	public string? Mode { get; set; }

	/// <summary>
	/// The IPv6 settings of the interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ipv6")]
	public RoutingInterfaceIpv6? Ipv6 { get; set; }

	/// <summary>
	/// The OSPF routing settings of the interface.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ospfSettings")]
	public OspfSettings? OspfSettings { get; set; }

	/// <summary>
	/// VRF settings. Included on networks with IOS XE 17.18 or higher
	/// </summary>
	[DataMember(Name = "vrf")]
	public RoutingInterfaceVrf? Vrf { get; set; }
}
