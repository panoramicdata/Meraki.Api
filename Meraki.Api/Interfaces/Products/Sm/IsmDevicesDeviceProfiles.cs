namespace Meraki.Api.Interfaces.Products.Sm;

public interface ISmDevicesDeviceProfiles
{
	/// <summary>
	/// Get the profiles associated with a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	[Get("/networks/{networkId}/sm/devices/{deviceId}/deviceProfiles")]
	Task<List<DeviceProfile>> GetNetworkSmDeviceProfilesAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("deviceId")] string deviceId,
		CancellationToken cancellationToken = default
		);
}
