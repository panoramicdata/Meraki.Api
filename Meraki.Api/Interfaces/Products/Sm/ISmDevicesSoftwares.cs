namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// I Sm Devices Softwares
/// </summary>
public interface ISmDevicesSoftwares
{
	/// <summary>
	/// Get a list of softwares associated with a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/sm/devices/{deviceId}/softwares")]
	Task<List<Software>> GetNetworkSmDeviceSoftwaresAsync(
		string networkId,
		string deviceId,
		CancellationToken cancellationToken = default
		);
}
