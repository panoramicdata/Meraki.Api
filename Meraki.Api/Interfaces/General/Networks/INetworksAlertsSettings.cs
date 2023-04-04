namespace Meraki.Api.Interfaces.General.Networks;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface INetworksAlertsSettings
{
	/// <summary>
	/// Return the alert configuration for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	[ApiOperationId("getNetworkAlertsSettings")]
	[Get("/networks/{networkId}/alerts/settings")]
	Task<NetworkAlertSettings> GetNetworkAlertsSettingsAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the alert configuration for this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="updateNetworkAlertSettings">Body for updating network alert settings</param>
	[ApiOperationId("updateNetworkAlertsSettings")]
	[Put("/networks/{networkId}/alerts/settings")]
	Task<NetworkAlertSettings> UpdateNetworkAlertsSettingsAsync(
		string networkId,
		[Body] NetworkAlertSettings updateNetworkAlertSettings = null!,
		CancellationToken cancellationToken = default);
}