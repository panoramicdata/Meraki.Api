using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IWireless
	{
		/// <summary>
		/// Return the bluetooth settings for a wireless device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The device serial number</param>
		[Get("/devices/{serial}/wireless/bluetooth/settings")]
		Task<DeviceBluetoothSettings> GetDeviceDeviceBluetoothSettingsAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the Bluetooth settings for a network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/bluetoothSettings")]
		Task<NetworkBluetoothSettings> GetNetworkDeviceBluetoothSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the bluetooth settings for a wireless device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="updateDeviceDeviceBluetoothSettings">Body for updating device's wireless bluetooth settings</param>
		[Put("/devices/{serial}/wireless/bluetooth/settings")]
		Task<DeviceBluetoothSettings> UpdateDeviceDeviceBluetoothSettingsAsync(
			[AliasAs("serial")] string serial,
			[Body] DeviceBluetoothSettings updateDeviceDeviceBluetoothSettings,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the Bluetooth settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="updateNetworkBluetoothSettings">Body for updating network's wireless bluetooth settings</param>
		[Put("/networks/{networkId}/wireless/bluetooth/settings")]
		Task<NetworkBluetoothSettings> UpdateNetworkDeviceBluetoothSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkBluetoothSettings updateNetworkBluetoothSettings,
			CancellationToken cancellationToken = default);
	}
}
