namespace Meraki.Api.Sections.Products.Appliance;

public class ApplianceVpnSection
{
	public IApplianceVpnBgp Bgp { get; internal set; } = null!;
	public IApplianceVpnSiteToSiteVpn SiteToSiteVpn { get; internal set; } = null!;
	public IApplianceVpnStats Stats { get; internal set; } = null!;
	public IApplianceVpnStatuses Statuses { get; internal set; } = null!;
	public IApplianceVpnThirdPartyVpnPeers ThirdPartyVpnPeers { get; internal set; } = null!;
	public IApplianceVpnVpnFirewallRules VpnFirewallRules { get; internal set; } = null!;
}