namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchAlternateManagementInterface
{
	/// <summary>
	/// Return the switch alternate management interface for the network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchAlternateManagementInterface")]
	[Get("/networks/{networkId}/switch/alternateManagementInterface")]
	Task<AlternateManagementInterface> GetNetworkSwitchAlternateManagementInterfaceAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the switch alternate management interface for the network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="alternateManagementInterface">Body for updating network switch alternate management interface</param>
	[ApiOperationId("updateNetworkSwitchAlternateManagementInterface")]
	[Put("/networks/{networkId}/switch/alternateManagementInterface")]
	Task<AlternateManagementInterface> UpdateNetworkSwitchAlternateManagementInterfaceAsync(
		string networkId,
		[Body] AlternateManagementInterface alternateManagementInterface,
		CancellationToken cancellationToken = default
		);
}
