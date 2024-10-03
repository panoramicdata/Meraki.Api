namespace Meraki.Api.Data;

/// <summary>
/// Static route information
/// </summary>
[DataContract]
public class SwitchStaticRouteCreationRequest
{
	/// <summary>
	/// Name
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Subnet
	/// </summary>
	[DataMember(Name = "subnet")]
	public string? Subnet { get; set; }

	/// <summary>
	/// Next hop ip
	/// </summary>
	[DataMember(Name = "nextHopIp")]
	public string? NextHopIp { get; set; }

	/// <summary>
	/// Advertise via ospf enabled
	/// </summary>
	[DataMember(Name = "advertiseViaOspfEnabled")]
	public bool? AdvertiseViaOspfEnabled { get; set; }

	/// <summary>
	/// Optional fallback IP address for management traffic
	/// </summary>
	[DataMember(Name = "managementNextHop")]
	public string? ManagementNextHop { get; set; }

	/// <summary>
	/// Prefer over ospf routes enabled
	/// </summary>
	[DataMember(Name = "preferOverOspfRoutesEnabled")]
	public bool? PreferOverOspfRoutesEnabled { get; set; }
}
