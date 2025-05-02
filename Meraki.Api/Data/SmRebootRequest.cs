namespace Meraki.Api.Data;

/// <summary>
/// SmRebootRequest
/// </summary>
[DataContract]
public class SmRebootRequest
{
	/// <summary>
	/// Whether or not to notify the user before rebooting the endpoint. Available for macOS 11.3+
	/// </summary>
	[DataMember(Name = "notifyUsers")]
	[ApiAccess(ApiAccess.Create)]
	public bool? NotifyUsers { get; set; }

	/// <summary>
	/// Whether or not to rebuild the kernel cache when rebooting the endpoint. Available for macOS 11+
	/// </summary>
	[DataMember(Name = "rebuildKernelCache")]
	[ApiAccess(ApiAccess.Create)]
	public bool? rebuildKernelCache { get; set; }

	/// <summary>
	/// Whether or not the request requires network tethering. Available for macOS and supervised iOS or tvOS
	/// </summary>
	[DataMember(Name = "rebuildRequiresNetworkTether")]
	[ApiAccess(ApiAccess.Create)]
	public bool? rebuildRequiresNetworkTether { get; set; }

	/// <summary>
	/// The ids of the endpoints to be rebooted.
	/// </summary>
	[DataMember(Name = "ids")]
	[ApiAccess(ApiAccess.Create)]
	public List<string>? Ids { get; set; }

	/// <summary>
	/// The KextPaths of the endpoints to be rebooted. Available for macOS 11+
	/// </summary>
	[DataMember(Name = "kextPaths")]
	[ApiAccess(ApiAccess.Create)]
	public List<string>? KextPaths { get; set; }

	/// <summary>
	/// The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the endpoints to be rebooted.
	/// </summary>
	[DataMember(Name = "scope")]
	[ApiAccess(ApiAccess.Create)]
	public List<string>? Scope { get; set; }

	/// <summary>
	/// The serials of the endpoints to be rebooted.
	/// </summary>
	[DataMember(Name = "serials")]
	[ApiAccess(ApiAccess.Create)]
	public List<string>? Serials { get; set; }

	/// <summary>
	/// The wifiMacs of the endpoints to be rebooted.
	/// </summary>
	[DataMember(Name = "wifiMacs")]
	[ApiAccess(ApiAccess.Create)]
	public List<string>? WifiMacs { get; set; }
}
