namespace Meraki.Api.Interfaces.General.LiveTools;
public interface ILiveToolsMacTable
{
	/// <summary>
	/// Return a MAC table live tool job.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="macTableId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceLiveToolsMacTable")]
	[Get("/devices/{serial}/liveTools/macTable/{macTableId}")]
	Task<DeviceLiveToolsMacTableGetResponse> GetDeviceLiveToolsMacTableAsync(
		string serial,
		string macTableId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Enqueue a job to request the MAC table from the device. Switches currently support this feature. This endpoint has a sustained rate limit of one request every five seconds per device, with an allowed burst of five requests.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createDeviceLiveToolsMacTable")]
	[Post("/devices/{serial}/liveTools/macTable")]
	Task<DeviceLiveToolsMacTableCreateResponse> CreateDeviceLiveToolsMacTableAsync(
		string serial,
		[Body] DeviceLiveToolsMacTableCreateRequest request,
		CancellationToken cancellationToken = default
	);
}
