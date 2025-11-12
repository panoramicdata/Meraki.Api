namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to appliance vpn API endpoints
/// </summary>
public class ApplianceVpnSection
{
	/// <summary>
	/// Return a Hub BGP Configuration
	/// </summary>

	public IApplianceVpnBgp Bgp { get; internal set; } = null!;
	/// <summary>
	/// Return the site-to-site VPN settings of a network
	/// </summary>

	public IApplianceVpnSiteToSiteVpn SiteToSiteVpn { get; internal set; } = null!;
	/// <summary>
	/// Show VPN history stat for networks in an organization.
	/// </summary>

	public IApplianceVpnStats Stats { get; internal set; } = null!;
	/// <summary>
	/// Show VPN status for networks in an organization
	/// </summary>

	public IApplianceVpnStatuses Statuses { get; internal set; } = null!;
	/// <summary>
	/// Return the third party VPN peers for an organization
	/// </summary>

	public IApplianceVpnThirdPartyVpnPeers ThirdPartyVpnPeers { get; internal set; } = null!;
	/// <summary>
	/// Return the firewall rules for an organization's site-to-site VPN
	/// </summary>

	public IApplianceVpnVpnFirewallRules VpnFirewallRules { get; internal set; } = null!;
}
