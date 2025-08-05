namespace Meraki.Api.Interfaces.General.LiveTools;

public interface ILiveToolsWakeOnLan
{
	/// <summary>
	/// Enqueue a job to send a Wake-on-LAN packet from the device
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="createDeviceLiveToolsWakeOnLan">Body</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("createDeviceLiveToolsWakeOnLan")]
	[Post("/devices/{serial}/liveTools/wakeOnLan")]
	Task<LiveToolsWakeOnLan> CreateDeviceLiveToolsWakeOnLanAsync(
		string serial,
		[Body] LiveToolsWakeOnLanCreate createDeviceLiveToolsWakeOnLan,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Return a Wake-on-LAN job
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial">The serial number</param>
	/// <param name="wakeOnLanId">Wake on lan ID</param>
	/// <param name="cancellationToken"></param>
	[ApiOperationId("getDeviceLiveToolsWakeOnLan")]
	[Get("/devices/{serial}/liveTools/wakeOnLan/{wakeOnLanId}")]
	Task<LiveToolsWakeOnLanResult> GetDeviceLiveToolsWakeOnLanAsync(
		string serial,
		string wakeOnLanId,
		CancellationToken cancellationToken = default);
}
