namespace Meraki.Api.Interfaces.General.LiveTools;
public interface ILiveToolsAclHitCount
{
	/// <summary>
	/// Enqueue a job to perform an ACL hit count for the device. This endpoint has a sustained rate limit of one request every five seconds per device, with an allowed burst of five requests.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="serial"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createDeviceLiveToolsAclHitCount")]
	[Post("/devices/{serial}/liveTools/aclHitCount")]
	Task<LiveToolsAclHitCount> CreateDeviceLiveToolsAclHitCountAsync(
		string serial,
		[Body] LiveToolsAclHitCountCreate request,
		CancellationToken cancellationToken = default
	);
}
