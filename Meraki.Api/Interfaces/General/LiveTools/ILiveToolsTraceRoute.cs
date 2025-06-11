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
}
