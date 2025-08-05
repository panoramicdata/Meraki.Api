namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceVpnSiteToSiteVpn
{
	/// <summary>
	/// Return the site-to-site VPN settings of a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkApplianceVpnSiteToSiteVpn")]
	[Get("/networks/{networkId}/appliance/vpn/siteToSiteVpn")]
	Task<SiteToSiteVpn> GetNetworkApplianceVpnSiteToSiteVpnAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the site-to-site VPN settings of a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="siteToSiteVpn">Body for updating VPN settings</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkApplianceVpnSiteToSiteVpn")]
	[Put("/networks/{networkId}/appliance/vpn/siteToSiteVpn")]
	Task<SiteToSiteVpn> UpdateNetworkApplianceVpnSiteToSiteVpnAsync(
		string networkId,
		[Body] SiteToSiteVpn siteToSiteVpn,
		CancellationToken cancellationToken = default
		);
}
