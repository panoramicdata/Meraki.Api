using Meraki.Api.Data;
using Refit;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Represents a collection of functions to interact with the API endpoints
	/// </summary>
	public interface IBluetoothSettings
	{
		/// <summary>
		/// Return the bluetooth settings for a wireless device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		[Get("/devices/{serial}/wireless/bluetooth/settings")]
		Task<WirelessBluetoothSettingsUpdateRequest> GetForDeviceAsync(
			[AliasAs("serial")] string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Return the Bluetooth settings for a network.
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		[Get("/networks/{networkId}/bluetoothSettings")]
		Task<NetworkBluetoothSettingsUpdateRequest> GetForNetworkAsync(
			[AliasAs("networkId")] string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the bluetooth settings for a wireless device
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial">The serial number</param>
		/// <param name="UpdateDeviceWirelessBluetoothSettings">Body for updating device's wireless bluetooth settings</param>
		[Put("/devices/{serial}/wireless/bluetooth/settings")]
		Task<WirelessBluetoothSettingsUpdateRequest> UpdateForDeviceAsync(
			[AliasAs("serial")] string serial,
			[Body] WirelessBluetoothSettingsUpdateRequest UpdateDeviceWirelessBluetoothSettings,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// Update the Bluetooth settings for a network
		/// </summary>
		/// <exception cref="ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId">The network id</param>
		/// <param name="UpdateNetworkBluetoothSettings">Body for updating network's wireless bluetooth settings</param>
		[Put("/networks/{networkId}/wireless/bluetooth/settings")]
		Task<NetworkBluetoothSettingsUpdateRequest> UpdateForNetworkAsync(
			[AliasAs("networkId")] string networkId,
			[Body] NetworkBluetoothSettingsUpdateRequest UpdateNetworkBluetoothSettings,
			CancellationToken cancellationToken = default);
	}
}
