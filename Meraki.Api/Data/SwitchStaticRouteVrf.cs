namespace Meraki.Api.Data;

/// <summary>
/// Static route VRF information
/// </summary>
[DataContract]
public class SwitchStaticRouteVrf
{
	/// <summary>
	/// The name of the VRF this static route belongs to
	/// </summary>
	[ApiKey]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Whether or not next-hop IP is reachable via default VRF
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "leakRouteToDefaultVrf")]
	public bool? LeakRouteToDefaultVrf { get; set; }

}
