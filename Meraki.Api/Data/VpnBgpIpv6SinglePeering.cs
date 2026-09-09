namespace Meraki.Api.Data;

/// <summary>
/// Single peering settings for IPv6 BGP
/// </summary>
[DataContract]
public class VpnBgpIpv6SinglePeering
{
	/// <summary>
	/// Whether a single IPv6 BGP peering session is used
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
