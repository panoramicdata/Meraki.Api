namespace Meraki.Api.Interfaces.General.LiveTools;
/// <summary>
/// I Live Tools Routing Table
/// </summary>
public interface ILiveToolsRoutingTable
{
	/// <summary>
	/// Return an routing table live tool job.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceLiveToolsRoutingTable")]
	[Get("/devices/{serial}/liveTools/routingTable/{id}")]
	Task<DeviceLiveToolsRoutingTableGetResponse> GetDeviceLiveToolsRoutingTableAsync(
		string serial,
		string id,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Enqueue a job to perform a routing table request for the device. Only native Catalyst switches are supported. This endpoint has a sustained rate limit of one request every five seconds per device, with an allowed burst of five requests.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createDeviceLiveToolsRoutingTable")]
	[Post("/devices/{serial}/liveTools/routingTable")]
	Task<DeviceLiveToolsRoutingTableCreateResponse> CreateDeviceLiveToolsRoutingTableAsync(
		string serial,
		[Body] DeviceLiveToolsRoutingTableCreateRequest request,
		CancellationToken cancellationToken = default);
}
