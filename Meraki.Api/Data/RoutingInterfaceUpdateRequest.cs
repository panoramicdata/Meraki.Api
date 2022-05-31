namespace Meraki.Api.Data;

/// <summary>
/// Routing interface update request
/// </summary>
[DataContract]
public class RoutingInterfaceUpdateRequest : NamedItem
{
	/// <summary>
	/// The VLAN this routed interface is on. VLAN must be between 1 and 4094.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vlanId")]
	public int? VlanId { get; set; }
	
	/// <summary>
	/// The next hop for any traffic that isn't going to a directly connected subnet or over a static route. This IP address must exist in a subnet with a routed interface.
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "defaultGateway")]
	public string? DefaultGateway { get; set; }
	
	/// <summary>
	/// The IP address this switch will use for layer 3 routing on this VLAN or subnet. This cannot be the same as the switch's management IP.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interfaceIp")]
	public string? InterfaceIp { get; set; }
	
	/// <summary>
	/// Enable multicast support if, multicast routing between VLANs is required. Options are, 'disabled', 'enabled' or 'IGMP snooping querier'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "multicastRouting")]
	public MulticastRouting? MulticastRouting { get; set; }

	/// <summary>
	/// The network that this routed interface is on, in CIDR notation (ex. 10.1.1.0/24).
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "subnet")]
	public string? Subnet { get; set; }

	/// <summary>
	/// The IPv6 settings of the interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ipv6")]
	public Ipv6? Ipv6 { get; set; }

	/// <summary>
	/// The OSPF routing settings of the interface.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ospfSettings")]
	public OspfSettings? OspfSettings { get; set; }
}
