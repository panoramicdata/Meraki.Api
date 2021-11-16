namespace Meraki.Api.Interfaces.Products.Sm;

public interface ISmDevicesCellularUsageHistory
{
	/// <summary>
	/// Return the client's daily cellular data usage history
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	[Get("/networks/{networkId}/sm/devices/{deviceId}/cellularUsageHistory")]
	Task<List<ClientUsageHistory>> GetNetworkSmDeviceCellularUsageHistoryAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("deviceId")] string deviceId,
		CancellationToken cancellationToken = default
		);
}
