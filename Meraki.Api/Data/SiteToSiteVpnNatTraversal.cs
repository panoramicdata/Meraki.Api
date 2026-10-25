namespace Meraki.Api.Data;

/// <summary>
/// NAT traversal settings for the site-to-site VPN - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class SiteToSiteVpnNatTraversal
{
	/// <summary>
	/// The NAT traversal mode. Only 'automatic' has been observed
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "mode")]
	public string? Mode { get; set; }
}
