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
		Task<DeviceBluetoothSettings> GetDeviceBluetoothSettingsAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the Bluetooth settings for a network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/wireless/bluetooth/settings")]
		Task<NetworkBluetoothSettings> GetNetworkBluetoothSettingsAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the bluetooth settings for a wireless device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="deviceBluetoothSettings">Body for updating device's wireless bluetooth settings</param>
		[Put("/devices/{serial}/wireless/bluetooth/settings")]
		Task<DeviceBluetoothSettings> UpdateDeviceBluetoothSettingsAsync(
			[AliasAs("serial")] string serial,
			[Body] DeviceBluetoothSettings deviceBluetoothSettings,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the Bluetooth settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="networkBluetoothSettings">Body for updating network's wireless bluetooth settings</param>
		[Put("/networks/{networkId}/wireless/bluetooth/settings")]
		Task<NetworkBluetoothSettings> UpdateNetworkBluetoothSettingsAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkBluetoothSettings networkBluetoothSettings,
			CancellationToken cancellationToken = default);
	}
}
