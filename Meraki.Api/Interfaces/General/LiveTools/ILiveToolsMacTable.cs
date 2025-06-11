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
}
