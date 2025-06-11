namespace Meraki.Api.Interfaces.General.LiveTools;

public interface ILiveToolsCyclePort
{
	/// <summary>
	/// Enqueue a job to perform a cycle port for the device on the specified ports. This endpoint has a sustained rate limit of one request every five seconds per device, with an allowed burst of five requests.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createDeviceLiveToolsCyclePort")]
	[Post("/devices/{serial}/liveTools/cyclePort")]
	Task<DeviceLiveToolsCyclePortCreateResponse> CreateDeviceLiveToolsCyclePortAsync(
		string serial,
		[Body] DeviceLiveToolsCyclePortCreateRequest request,
		CancellationToken cancellationToken = default);
}
