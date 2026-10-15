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

	/// <summary>
	/// The virtual IPv4 address of the VRRP group. Undocumented property, observed in live API responses only.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string? Address { get; set; }

	/// <summary>
	/// The VRRP group number. Undocumented property, observed in live API responses only.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "group")]
	public int? Group { get; set; }

	/// <summary>
	/// The VRRP priority of this interface. Undocumented property, observed in live API responses only.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "priority")]
	public int? Priority { get; set; }

	/// <summary>
	/// VRRP preemption settings. Undocumented property, observed in live API responses only.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "preemption")]
	public RoutingInterfaceVrrpIpv4Preemption? Preemption { get; set; }
}