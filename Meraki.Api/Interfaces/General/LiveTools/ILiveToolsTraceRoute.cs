namespace Meraki.Api.Interfaces.General.LiveTools;

public interface ILiveToolsTraceRoute
{
	/// <summary>
	/// Return a trace route job
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="traceRouteId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceLiveToolsTraceRoute")]
	[Get("/devices/{serial}/liveTools/traceRoute/{traceRouteId}")]
	Task<DeviceLiveToolsTraceRouteGetResponse> GetTraceRouteAsync(
		string serial,
		string traceRouteId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Enqueue a job to run trace route in the device. This endpoint has a sustained rate limit of one request every five seconds per device, with an allowed burst of five requests.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createDeviceLiveToolsTraceRoute")]
	[Post("/devices/{serial}/liveTools/traceRoute")]
	Task<DeviceLiveToolsTraceRouteCreateResponse> CreateDeviceLiveToolsTraceRouteAsync(
		string serial,
		[Body] DeviceLiveToolsTraceRouteCreateRequest request,
		CancellationToken cancellationToken = default
	);
}
