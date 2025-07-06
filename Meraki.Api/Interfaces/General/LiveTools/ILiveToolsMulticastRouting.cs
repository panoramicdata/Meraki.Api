namespace Meraki.Api.Interfaces.General.LiveTools;

public interface ILiveToolsMulticastRouting
{
	/// <summary>
	/// Return a Multicast routing live tool job.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="multicastRoutingId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceLiveToolsMulticastRouting")]
	[Get("/devices/{serial}/liveTools/multicastRouting/{multicastRoutingId}")]
	Task<DeviceLiveToolsMulticastRoutingGetResponse> GetDeviceLiveToolsMulticastRoutingAsync(
		string serial,
		string multicastRoutingId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Enqueue a job to perform a Multicast routing request for the device. This endpoint currently supports switches. This endpoint has a sustained rate limit of one request every five seconds per device, with an allowed burst of five requests.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createDeviceLiveToolsMulticastRouting")]
	[Post("/devices/{serial}/liveTools/multicastRouting")]
	Task<DeviceLiveToolsMulticastRoutingCreateResponse> CreateDeviceLiveToolsMulticastRoutingAsync(
		string serial,
		[Body] DeviceLiveToolsMulticastRoutingCreateRequest request,
		CancellationToken cancellationToken = default
	);
}
