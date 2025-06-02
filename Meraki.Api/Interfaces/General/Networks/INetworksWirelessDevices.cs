namespace Meraki.Api.Interfaces.General.Networks;
public interface INetworksWirelessDevices
{
	/// <summary>
	/// Fetch the health scores of all APs on this network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getNetworkWirelessDevicesHealthScores")]
	[Get("/networks/{networkId}/wireless/devices/healthScores")]
	Task<List<WirelessDeviceHealthScore>> GetNetworkWirelessDevicesHealthScoresAsync(
		string networkId,
		CancellationToken cancellationToken = default
		);
}
