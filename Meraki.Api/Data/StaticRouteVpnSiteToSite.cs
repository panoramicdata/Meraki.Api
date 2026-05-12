namespace Meraki.Api.Data;

/// <summary>
/// Site-to-site VPN settings for a static route
/// </summary>
[DataContract]
public class StaticRouteVpnSiteToSite
{
    /// <summary>
    /// Whether site-to-site VPN is enabled for the static route
    /// </summary>
    [ApiAccess(ApiAccess.Read)]
    [DataMember(Name = "enabled")]
    public bool? Enabled { get; set; }
}
