namespace Meraki.Api.Data;

/// <summary>
/// Static route information
/// </summary>
[DataContract]
public class SwitchStaticRoute : NamedItem
{
	/// <summary>
	/// Static route ip
	/// </summary>
	[ApiKey]
	[DataMember(Name = "staticRouteId")]
	public string StaticRouteId { get; set; } = string.Empty;

	/// <summary>
	/// The subnet which is routed via this static route and should be specified in CIDR notation (ex. 1.2.3.0/24)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "subnet")]
	public string? Subnet { get; set; }

	/// <summary>
	/// IP address of the next hop device to which the device sends its traffic for the subnet
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "nextHopIp")]
	public string? NextHopIp { get; set; }

	/// <summary>
	/// Option to advertise static route via OSPF
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "advertiseViaOspfEnabled")]
	public bool? AdvertiseViaOspfEnabled { get; set; }

	/// <summary>
	/// Option to prefer static route over OSPF routes
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "preferOverOspfRoutesEnabled")]
	public bool? PreferOverOspfRoutesEnabled { get; set; }

	/// <summary>
	/// Optional fallback IP address for management traffic
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "managementNextHop")]
	public string? ManagementNextHop { get; set; }

	/// <summary>
	/// VRF settings. Included on networks with IOS XE 17.18 or higher
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vrf")]
	public SwitchStaticRouteVrf? Vrf { get; set; }
}
