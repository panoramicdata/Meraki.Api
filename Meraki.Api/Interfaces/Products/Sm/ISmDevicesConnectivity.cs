namespace Meraki.Api.Interfaces.Products.Sm;

/// <summary>
/// I Sm Devices Connectivity
/// </summary>
public interface ISmDevicesConnectivity
{
	/// <summary>
	/// Returns historical connectivity data (whether a device is regularly checking in to Dashboard).
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="deviceId">The device id</param>
	/// <param name="perPage">The number of entries per page returned. Acceptable range is 3 - 1000. Default is 1000. (optional)</param>
	/// <param name="startingAfter">A token used by the server to indicate the start of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="endingBefore">A token used by the server to indicate the end of the page. Often this is a timestamp or an ID but it is not limited to those. This parameter should not be defined by client applications. The link for the first, last, prev, or next page in the HTTP Link header should define it. (optional)</param>
	/// <param name="cancellationToken"></param>
	[Get("/networks/{networkId}/sm/devices/{deviceId}/connectivity")]
	Task<DeviceConnectivity> GetNetworkSmDeviceConnectivityAsync(
		string networkId,
		string deviceId,
		int? perPage = 1000,
		string startingAfter = null!,
		string endingBefore = null!,
		CancellationToken cancellationToken = default
		);
}
