namespace Meraki.Api.Interfaces.General.Networks;

public interface INetworksClientsSplashAuthorizationStatus
{
	/// <summary>
	/// Return the splash authorization for a client, for each SSID they've associated with through splash
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="clientId">The client id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getNetworkClientSplashAuthorizationStatus")]
	[Get("/networks/{networkId}/clients/{clientId}/splashAuthorizationStatus")]
	Task<ClientSplashAuthorizationStatusUpdateRequest> GetNetworkClientSplashAuthorizationStatusAsync(
		string networkId,
		string clientId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update a client's splash authorization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="clientId">The client id</param>
	/// <param name="updateNetworkClientSplashAuthorizationStatus">Body for updating client's splash authorization</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("updateNetworkClientSplashAuthorizationStatus")]
	[Put("/networks/{networkId}/clients/{clientId}/splashAuthorizationStatus")]
	Task<ClientSplashAuthorizationStatusUpdateRequest> UpdateNetworkClientSplashAuthorizationStatusAsync(
		string networkId,
		string clientId,
		[Body] ClientSplashAuthorizationStatusUpdateRequest updateNetworkClientSplashAuthorizationStatus,
		CancellationToken cancellationToken = default);
}
