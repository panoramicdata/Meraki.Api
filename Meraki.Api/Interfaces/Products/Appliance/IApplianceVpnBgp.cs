namespace Meraki.Api.Interfaces.Products.Appliance;

public interface IApplianceVpnBgp
{
	/// <summary>
	/// Return a Hub BGP Configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/appliance/vpn/bgp")]
	Task<VpnBgp> GetNetworkApplianceVpnBgpAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return a Hub BGP Configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateVpnBgp"></param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/appliance/vpn/bgp")]
	Task<VpnBgp> UpdateNetworkApplianceVpnBgpAsync(
		string networkId,
		[Body] VpnBgp updateVpnBgp,
		CancellationToken cancellationToken = default
		);
}
