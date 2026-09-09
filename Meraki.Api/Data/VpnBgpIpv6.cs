namespace Meraki.Api.Data;

/// <summary>
/// IPv6 BGP settings - Undocumented, observed in responses only
/// </summary>
[DataContract]
public class VpnBgpIpv6
{
	/// <summary>
	/// Single peering settings for IPv6 BGP
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "singlePeering")]
	public VpnBgpIpv6SinglePeering? SinglePeering { get; set; }
}
