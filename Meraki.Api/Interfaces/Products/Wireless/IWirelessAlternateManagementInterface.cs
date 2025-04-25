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
	/// <param name="cancellationToken">Cancellation Token</param>
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
	/// <param name="cancellationToken">Cancellation Token</param>
	[Put("/networks/{networkId}/wireless/alternateManagementInterface")]
	Task<WirelessAlternateManagementInterface> UpdateNetworkWirelessAlternateManagementInterfaceAsync(
		string networkId,
		[Body] WirelessAlternateManagementInterface updateNetworkWirelessAlternateManagementInterface,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update alternate management interface IPv6 address
	/// </summary>
	/// <param name="serial">The serial</param>
	/// <param name="updateDeviceWirelessAlternateManagementInterfaceIpv6"></param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[Put("/networks/{serial}/wireless/alternateManagementInterface/ipv6")]
	Task<WirelessAlternateMangementInterfaceIpv6Request> UpdateDeviceWirelessAlternateManagementInterfaceIpv6(
		string serial,
		[Body] WirelessAlternateMangementInterfaceIpv6Request updateDeviceWirelessAlternateManagementInterfaceIpv6,
		CancellationToken cancellationToken = default
		);
}
