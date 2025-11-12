namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// I Sm Devices Cellular Usage History
/// </summary>
public interface ISmDevicesCellularUsageHistory
{
	/// <summary>
	/// Return the client's daily cellular data usage history
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/sm/devices/{deviceId}/cellularUsageHistory")]
	Task<List<ClientUsageHistory>> GetNetworkSmDeviceCellularUsageHistoryAsync(
		string networkId,
		string deviceId,
		CancellationToken cancellationToken = default
		);
}
