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
}
