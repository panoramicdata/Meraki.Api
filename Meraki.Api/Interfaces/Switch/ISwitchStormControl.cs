namespace Meraki.Api.Interfaces.Switch;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface ISwitchStormControl
{
	/// <summary>
	/// Return the storm control configuration for a switch network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkSwitchStormControl")]
	[Get("/networks/{networkId}/switch/stormControl")]
	Task<StormControl> GetStormControlAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Update the storm control configuration for a switch network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkSwitchSettingsStormControl"></param>
	[ApiOperationId("updateNetworkSwitchStormControl")]
	[Put("/networks/{networkId}/switch/stormControl")]
	Task<StormControl> UpdateStormControlAsync(
		[AliasAs("networkId")] string networkId,
		[Body] StormControl updateNetworkSwitchSettingsStormControl,
		CancellationToken cancellationToken = default
		);
}
