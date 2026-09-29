namespace Meraki.Api.Data;

/// <summary>
/// The status of a third-party VPN peer as reported on an appliance VPN status
/// </summary>
[DataContract]
public class VpnStatusThirdPartyVpnPeer
{
	/// <summary>
	/// Name of the peer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Public IP of the peer
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "publicIp")]
	public string? PublicIp { get; set; }

	/// <summary>
	/// Reachability
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "reachability")]
	public string? Reachability { get; set; }
}
