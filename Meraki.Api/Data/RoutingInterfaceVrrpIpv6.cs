namespace Meraki.Api.Data;

/// <summary>
/// IPv6 VRRP settings for a routing interface
/// </summary>
[DataContract]
public class RoutingInterfaceVrrpIpv6
{
	/// <summary>
	/// Whether IPv6 VRRP is enabled on the routing interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}