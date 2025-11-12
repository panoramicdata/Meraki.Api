namespace Meraki.Api.Interfaces.Products.Wireless;

/// <summary>
/// I Wireless Bluetooth
/// </summary>
public interface IWirelessBluetoothSettings
{
	/// <summary>
	/// Return the bluetooth settings for a wireless device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The device serial number</param>
	/// <param name="cancellationToken"></param>
	[Get("/devices/{serial}/wireless/bluetooth/settings")]
	Task<DeviceBluetoothSettings> GetDeviceWirelessBluetoothSettingsAsync(
		string serial,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return the Bluetooth settings for a network.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/wireless/bluetooth/settings")]
	Task<NetworkBluetoothSettings> GetNetworkWirelessBluetoothSettingsAsync(
		string networkId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the bluetooth settings for a wireless device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="deviceBluetoothSettings">Body for updating device's wireless bluetooth settings</param>
	/// <param name="cancellationToken"></param>
	[Put("/devices/{serial}/wireless/bluetooth/settings")]
	Task<DeviceBluetoothSettings> UpdateDeviceWirelessBluetoothSettingsAsync(
		string serial,
		[Body] DeviceBluetoothSettings deviceBluetoothSettings,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update the Bluetooth settings for a network
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="networkBluetoothSettings">Body for updating network's wireless bluetooth settings</param>
	/// <param name="cancellationToken"></param>
	[Put("/networks/{networkId}/wireless/bluetooth/settings")]
	Task<NetworkBluetoothSettings> UpdateNetworkWirelessBluetoothSettingsAsync(
		string networkId,
		[Body] NetworkBluetoothSettings networkBluetoothSettings,
		CancellationToken cancellationToken = default);
}
