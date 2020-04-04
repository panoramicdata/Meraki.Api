using Meraki.Api.Data;
using Refit;
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
		Task<object> GetDeviceWirelessBluetoothSettings([AliasAs("serial")]string serial);

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
		Task<object> GetNetworkBluetoothSettings([AliasAs("networkId")]string networkId);

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
		Task<object> UpdateDeviceWirelessBluetoothSettings(
			[AliasAs("serial")]string serial,
			[Body]UpdateDeviceWirelessBluetoothSettings updateDeviceWirelessBluetoothSettings);

		/// <summary>
		/// updateNetworkBluetoothSettings
		/// </summary>
		/// <remarks>
		/// Update the Bluetooth settings for a network. See the docs page for &lt;a href&#x3D;\&quot;https://documentation.meraki.com/MR/Bluetooth/Bluetooth_Low_Energy_(BLE)\&quot;&gt;Bluetooth settings&lt;/a&gt;.
		/// </remarks>
		/// <exception cref="Swagger.Client.ApiException">Thrown when fails to make API call</exception>
		/// <param name="networkId"></param>
		/// <param name="updateNetworkBluetoothSettings"> (optional)</param>
		/// <returns>Task of Object</returns>
		[Put("/networks/{networkId}/bluetoothSettings")]
		Task<object> UpdateNetworkBluetoothSettings(
			[AliasAs("networkId")]string networkId,
			[Body]UpdateNetworkBluetoothSettings updateNetworkBluetoothSettings);
	}
}
