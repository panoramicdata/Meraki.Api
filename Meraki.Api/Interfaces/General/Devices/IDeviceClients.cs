namespace Meraki.Api.Interfaces.General.Devices;

/// <summary>
/// I Device Clients
/// </summary>
public interface IDeviceClients
{
	/// <summary>
	/// List the clients of a device, up to a maximum of a month ago
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="t0">The beginning of the timespan for the data. The maximum lookback period is 31 days from today. (optional)</param>
	/// <param name="timespan">The timespan for which the information will be fetched. If specifying timespan, do not specify parameter t0. The value must be in seconds and be less than or equal to 31 days. The default is 1 day. (optional)</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceClients")]
	[Get("/devices/{serial}/clients")]
	Task<List<DeviceClient>> GetDeviceClientsAsync(
		string serial,
		string t0 = null!,
		double? timespan = null,
		CancellationToken cancellationToken = default);
}
