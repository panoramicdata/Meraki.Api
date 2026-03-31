namespace Meraki.Api.Data;

/// <summary>
/// IPv4 VRRP settings for a routing interface
/// </summary>
[DataContract]
public class RoutingInterfaceVrrpIpv4
{
	/// <summary>
	/// Whether IPv4 VRRP is enabled on the routing interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}