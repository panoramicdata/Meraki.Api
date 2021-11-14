namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksSettings
{
	/// <summary>
	/// Return the settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[Get("/networks/{networkId}/settings")]
	Task<NetworkSettings> GetSettingsAsync(
		[AliasAs("networkId")] string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkSettings">Body for updating network settings</param>
	[Put("/networks/{networkId}/settings")]
	Task<NetworkSettings> UpdateSettingsAsync(
		[AliasAs("networkId")] string networkId,
		[Body] NetworkSettings updateNetworkSettings,
		CancellationToken cancellationToken = default
		);

}
