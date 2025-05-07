namespace Meraki.Api.Interfaces.General.Networks;
public interface INetworksLocationScanning
{
	/// <summary>
	/// Return scanning API settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The Network ID</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[Get("/networks/{networkId}/locationScanning")]
	Task<NetworksLocationScanning> GetNetworkLocationScanningAsync(string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Change scanning API settings
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The Network ID</param>
	/// <param name="networksLocationScanningRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/networks/{networkId}/locationScanning")]
	Task<NetworksLocationScanning>
		UpdateNetworkLocationScanningAsync(string networkId,
			[Body] NetworksLocationScanningUpdateRequest networksLocationScanningRequest,
			CancellationToken cancellationToken = default);

	/// <summary>
	/// Return list of scanning API receivers
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The Network ID</param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Get("/networks/{networkId}/locationScanning/httpServers")]
	Task<List<NetworksLocationScanningHttpServerResponse>> GetNetworkLocationScanningHttpServersAsync(string networkId,
			CancellationToken cancellationToken = default);

	/// <summary>
	/// Set the list of scanning API receivers. Old receivers will be removed
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">\The Network ID</param>
	/// <param name="networksLocationScanningHttpServerUpdateRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[Put("/networks/{networkId}/locationScanning/httpServers")]
	Task<NetworksLocationScanningHttpServerResponse> UpdateNetworkLocationScanningHttpServersAsync(string networkId,
		[Body] NetworksLocationScanningHttpServerUpdateRequest networksLocationScanningHttpServerUpdateRequest,
		CancellationToken cancellationToken = default);
}
