namespace Meraki.Api.Data;

/// <summary>
/// NAT traversal settings for the site-to-site VPN - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class SiteToSiteVpnNatTraversal
{
	/// <summary>
	/// The NAT traversal mode. 'automatic' and 'manual' have been observed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public string? Mode { get; set; }

	/// <summary>
	/// The public IP address used for NAT traversal. Returned in 'manual' mode
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "publicIp")]
	public string? PublicIp { get; set; }

	/// <summary>
	/// The public port used for NAT traversal. Returned in 'manual' mode
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "publicPort")]
	public int? PublicPort { get; set; }
}
