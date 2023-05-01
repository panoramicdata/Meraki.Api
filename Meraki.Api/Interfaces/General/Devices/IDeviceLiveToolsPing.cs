namespace Meraki.Api.Interfaces.General.Devices;

public interface IDeviceLiveToolsPing
{
	/// <summary>
	/// Enqueue a job to ping a target host from the device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="createDeviceLiveToolsPing">Body</param>
	[ApiOperationId("createDeviceLiveToolsPing")]
	[Post("/devices/{serial}/liveTools/ping")]
	Task<LiveToolPing> CreateDeviceLiveToolsPingAsync(
		string serial,
		[Body] LiveToolPingCreate createDeviceLiveToolsPing,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a ping job. Latency unit in response is in milliseconds. Size is in bytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="id">The device id</param>
	[ApiOperationId("getDeviceLiveToolsPing")]
	[Get("/devices/{serial}/liveTools/ping/{id}")]
	Task<LiveToolPing> GetDeviceLiveToolsPingAsync(
		string serial,
		string id,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Enqueue a job to check connectivity status to the device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="createDeviceLiveToolsPingDevice">Body</param>
	[ApiOperationId("createDeviceLiveToolsPingDevice")]
	[Post("/devices/{serial}/liveTools/pingDevice")]
	Task<LiveToolPing> CreateDeviceLiveToolsPingDeviceAsync(
		string serial,
		[Body] LiveToolPing createDeviceLiveToolsPingDevice,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a ping job. Latency unit in response is in milliseconds. Size is in bytes.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	[ApiOperationId("getDeviceLiveToolsPingDevice")]
	[Get("/devices/{serial}/liveTools/pingDevice/{id}")]
	Task<LiveToolPing> GetDeviceLiveToolsPingDeviceAsync(
		string serial,
		string id,
		CancellationToken cancellationToken = default);
}
