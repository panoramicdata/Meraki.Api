namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// I Sm Devices Wlan Lists
/// </summary>
public interface ISmDevicesWlanLists
{
	/// <summary>
	/// List the saved SSID names on a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/sm/devices/{deviceId}/wlanLists")]
	Task<List<WlanList>> GetNetworkSmDeviceWlanListsAsync(
		string networkId,
		string deviceId,
		CancellationToken cancellationToken = default
		);
}
