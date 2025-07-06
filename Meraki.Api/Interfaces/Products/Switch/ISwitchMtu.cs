namespace Meraki.Api.Interfaces.Products.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchMtu
{
	/// <summary>
	/// Return the MTU configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkSwitchMtu")]
	[Get("/networks/{networkId}/switch/mtu")]
	Task<SwitchMtu> GetNetworkSwitchMtuAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the MTU configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateSwitchMtu"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkSwitchMtu")]
	[Put("/networks/{networkId}/switch/mtu")]
	Task<SwitchMtu> UpdateNetworkSwitchMtuAsync(
		string networkId,
		[Body] SwitchMtu updateSwitchMtu,
		CancellationToken cancellationToken = default
		);
}
