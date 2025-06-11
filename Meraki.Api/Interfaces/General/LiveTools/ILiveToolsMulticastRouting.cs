namespace Meraki.Api.Interfaces.General.LiveTools;

public interface ILiveToolsMulticastRouting
{
	/// <summary>
	/// Return a Multicast routing live tool job.
	/// </summary>
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
}
