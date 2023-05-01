namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IWirelessAlternateManagementInterface
{
	/// <summary>
	/// Return an action batch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/wireless/alternateManagementInterface")]
	Task<WirelessAlternateManagementInterface> GetNetworkWirelessAlternateManagementInterfaceAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update an action batch
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkWirelessAlternateManagementInterface"></param>
	[Put("/networks/{networkId}/wireless/alternateManagementInterface")]
	Task<WirelessAlternateManagementInterface> UpdateNetworkWirelessAlternateManagementInterfaceAsync(
		string networkId,
		[Body] WirelessAlternateManagementInterface updateNetworkWirelessAlternateManagementInterface,
		CancellationToken cancellationToken = default
		);
}
