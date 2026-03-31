namespace Meraki.Api.Data;

/// <summary>
/// VRRP settings for a routing interface
/// </summary>
[DataContract]
public class RoutingInterfaceVrrp
{
	/// <summary>
	/// IPv4 VRRP settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv4")]
	public RoutingInterfaceVrrpIpv4? Ipv4 { get; set; }

	/// <summary>
	/// IPv6 VRRP settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv6")]
	public RoutingInterfaceVrrpIpv6? Ipv6 { get; set; }
}