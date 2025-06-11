namespace Meraki.Api.Interfaces.General.LiveTools;

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
}
