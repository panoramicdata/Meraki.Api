namespace Meraki.Api.Data;

/// <summary>
/// VRRP preemption settings for a routing interface - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class RoutingInterfaceVrrpIpv4Preemption
{
	/// <summary>
	/// Whether this interface preempts a lower-priority VRRP master
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}