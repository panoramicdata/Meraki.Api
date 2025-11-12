namespace Meraki.Api.Interfaces.General.LiveTools;

/// <summary>
/// I Live Tools Speed Test
/// </summary>
public interface ILiveToolsSpeedTest
{
	/// <summary>
	/// Returns a speed test result in megabits per second. If test is not complete, no results are present.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceLiveToolsSpeedTest")]
	[Get("/devices/{serial}/liveTools/speedTest/{id}")]
	Task<DeviceLiveToolsSpeedTestGetResponse> GetDeviceLiveToolsSpeedTestAsync(
		string serial,
		string id,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Enqueue a job to execute a speed test from a device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createDeviceLiveToolsSpeedTest")]
	[Post("/devices/{serial}/liveTools/speedTest")]
	Task<DeviceLiveToolsSpeedTestCreateResponse> CreateDeviceLiveToolsSpeedTestAsync(
		string serial,
		[Body] DeviceLiveToolsSpeedTestCreateRequest request,
		CancellationToken cancellationToken = default
	);
}
