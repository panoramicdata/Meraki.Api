namespace Meraki.Api.Interfaces.General.LiveTools;
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
}
