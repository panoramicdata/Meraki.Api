namespace Meraki.Api.Interfaces.General.LiveTools;

public interface ILiveToolsPingDevice
{
	/// <summary>
	/// Enqueue a job to check connectivity status to the device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="createDeviceLiveToolsPingDevice">Body</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createDeviceLiveToolsPingDevice")]
	[Post("/devices/{serial}/liveTools/pingDevice")]
	Task<LiveToolsPing> CreateDeviceLiveToolsPingDeviceAsync(
		string serial,
		[Body] LiveToolsPing createDeviceLiveToolsPingDevice,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a ping job. Latency unit in response is in milliseconds. Size is in bytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceLiveToolsPingDevice")]
	[Get("/devices/{serial}/liveTools/pingDevice/{id}")]
	Task<LiveToolsPing> GetDeviceLiveToolsPingDeviceAsync(
		string serial,
		string id,
		CancellationToken cancellationToken = default);
}
