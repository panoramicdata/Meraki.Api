namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IWirelessBilling
{
	/// <summary>
	/// Return the billing settings of this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/wireless/billing")]
	Task<NetworkWirelessBilling> GetNetworkWirelessBillingAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the billing settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkWirelessBilling">Body for updating network wireless billing</param>
	[Put("/networks/{networkId}/wireless/billing")]
	Task<NetworkWirelessBilling> UpdateNetworkWirelessBillingAsync(
		[AliasAs("networkId")] string networkId,
		[Body] NetworkWirelessBilling updateNetworkWirelessBilling,
		CancellationToken cancellationToken = default
		);
}
