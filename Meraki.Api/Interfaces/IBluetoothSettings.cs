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
		/// getDeviceWirelessBluetoothSettings
		/// </summary>
		/// <remarks>
		/// Return the bluetooth settings for a wireless device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <returns>Task of Object</returns>
		[Get("/devices/{serial}/wireless/bluetooth/settings")]
		Task<object> GetForDeviceAsync(
			[AliasAs("serial")]string serial,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// getNetworkBluetoothSettings
		/// </summary>
		/// <remarks>
		/// Return the Bluetooth settings for a network. &lt;a href&#x3D;\&quot;https://documentation.meraki.com/MR/Bluetooth/Bluetooth_Low_Energy_(BLE)\&quot;&gt;Bluetooth settings&lt;/a&gt; must be enabled on the network.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <returns>Task of Object</returns>
		[Get("/networks/{networkId}/bluetoothSettings")]
		Task<object> GetForNetworkAsync([AliasAs("networkId")]string networkId,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateDeviceWirelessBluetoothSettings
		/// </summary>
		/// <remarks>
		/// Update the bluetooth settings for a wireless device
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="serial"></param>
		/// <param name="updateDeviceWirelessBluetoothSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/devices/{serial}/wireless/bluetooth/settings")]
		Task<object> UpdateForDeviceAsync(
			[AliasAs("serial")]string serial,
			[Body]WirelessBluetoothSettingsUpdateRequest updateDeviceWirelessBluetoothSettings,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// updateNetworkBluetoothSettings
		/// </summary>
		/// <remarks>
		/// Update the Bluetooth settings for a network
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkBluetoothSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/wireless/bluetooth/settings")]
		Task<object> UpdateForNetworkAsync(
			[AliasAs("networkId")]string networkId,
			[Body]NetworkBluetoothSettingsUpdateRequest updateNetworkBluetoothSettings,
			CancellationToken cancellationToken = default);
	}
}
