namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// I Sm Devices Device Profiles
/// </summary>
public interface ISmDevicesDeviceProfiles
{
	/// <summary>
	/// Get the installed profiles associated with a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/sm/devices/{deviceId}/deviceProfiles")]
	Task<List<DeviceProfile>> GetNetworkSmDeviceDeviceProfilesAsync(
		string networkId,
		string deviceId,
		CancellationToken cancellationToken = default
		);
}
