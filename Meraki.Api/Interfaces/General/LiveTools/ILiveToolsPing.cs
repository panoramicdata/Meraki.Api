namespace Meraki.Api.Interfaces.General.LiveTools;

/// <summary>
/// I Live Tools Ping
/// </summary>
public interface ILiveToolsPing
{
	/// <summary>
	/// Enqueue a job to ping a target host from the device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="createDeviceLiveToolsPing">Body</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createDeviceLiveToolsPing")]
	[Post("/devices/{serial}/liveTools/ping")]
	Task<LiveToolsPing> CreateDeviceLiveToolsPingAsync(
		string serial,
		[Body] LiveToolsPingCreate createDeviceLiveToolsPing,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a ping job. Latency unit in response is in milliseconds. Size is in bytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="id">The device id</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceLiveToolsPing")]
	[Get("/devices/{serial}/liveTools/ping/{id}")]
	Task<LiveToolsPing> GetDeviceLiveToolsPingAsync(
		string serial,
		string id,
		CancellationToken cancellationToken = default);
}
