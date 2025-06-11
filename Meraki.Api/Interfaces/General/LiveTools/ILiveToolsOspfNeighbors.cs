namespace Meraki.Api.Interfaces.General.LiveTools;

public interface ILiveToolsOspfNeighbors
{
	/// <summary>
	/// Return an OSPF neighbors live tool job.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="ospfNeighborsId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceLiveToolsOspfNeighbor")]
	[Get("/devices/{serial}/liveTools/ospfNeighbors/{ospfNeighborsId}")]
	Task<DeviceLiveToolsOspfNeighborGetResponse> GetDeviceLiveToolsOspfNeighborAsync(
		string serial,
		string ospfNeighborsId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Enqueue a job to perform a OSPF neighbors request for the device. This endpoint currently supports switches. This endpoint has a sustained rate limit of one request every five seconds per device, with an allowed burst of five requests.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createDeviceLiveToolsOspfNeighbor")]
	[Post("/devices/{serial}/liveTools/ospfNeighbors")]
	Task<DeviceLiveToolsOspfNeighborCreateResponse> CreateDeviceLiveToolsOspfNeighborAsync(
		string serial,
		[Body] DeviceLiveToolsOspfNeighborCreateRequest request,
		CancellationToken cancellationToken = default
	);
}
