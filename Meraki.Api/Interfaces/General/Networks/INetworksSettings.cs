namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// I Networks
/// </summary>
public interface INetworksSettings
{
	/// <summary>
	/// Return the settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/settings")]
	Task<NetworkSettings> GetNetworkSettingsAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkSettings">Body for updating network settings</param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/settings")]
	Task<NetworkSettings> UpdateNetworkSettingsAsync(
		string networkId,
		[Body] NetworkSettings updateNetworkSettings,
		CancellationToken cancellationToken = default
		);
}
