namespace Meraki.Api.Interfaces.General.Networks;
public interface INetworksLocationScanning
{
	/// <summary>
	/// Return scanning API settings
	/// </summary>
	/// <param name="networkId">The Network ID</param>
	/// <param name="cancellationToken">Cancellation Token</param>
	/// <returns></returns>
	[Get("/networks/{networkId}/locationScanning")]
	Task<NetworksLocationScanningResponse> GetNetworkLocationScanningAsync(string networkId,
		CancellationToken cancellationToken = default);
}
