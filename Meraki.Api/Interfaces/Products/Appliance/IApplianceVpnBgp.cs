namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceVpnBgp
{
	/// <summary>
	/// Return a Hub BGP Configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/appliance/vpn/bgp")]
	Task<VpnBgp> GetNetworkApplianceVpnBgpAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a Hub BGP Configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateVpnBgp"></param>
	[Put("/networks/{networkId}/appliance/vpn/bgp")]
	Task<VpnBgp> UpdateNetworkApplianceVpnBgpAsync(
		[AliasAs("networkId")] string networkId,
		[Body] VpnBgp updateVpnBgp,
		CancellationToken cancellationToken = default
		);
}
