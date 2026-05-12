namespace Meraki.Api.Data;

/// <summary>
/// VPN settings for a static route
/// </summary>
[DataContract]
public class StaticRouteVpn
{
    /// <summary>
    /// Site-to-site VPN settings
    /// </summary>
    [ApiAccess(ApiAccess.Read)]
    [DataMember(Name = "siteToSite")]
    public StaticRouteVpnSiteToSite? SiteToSite { get; set; }
}
