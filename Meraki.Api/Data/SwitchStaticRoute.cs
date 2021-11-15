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
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "staticRouteId")]
	public string StaticRouteId { get; set; } = string.Empty;

	/// <summary>
	/// The subnet which is routed via this static route and should be specified in CIDR notation (ex. 1.2.3.0/24)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;

	/// <summary>
	/// IP address of the next hop device to which the device sends its traffic for the subnet
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "nextHopIp")]
	public string NextHopIp { get; set; } = string.Empty;

	/// <summary>
	/// Option to advertise static route via OSPF
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "advertiseViaOspfEnabled")]
	public bool AdvertiseViaOspfEnabled { get; set; }

	/// <summary>
	/// Option to prefer static route over OSPF routes
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "preferOverOspfRoutesEnabled")]
	public bool PreferOverOspfRoutesEnabled { get; set; }
}
