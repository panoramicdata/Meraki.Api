namespace Meraki.Api.Interfaces.General.LiveTools;
/// <summary>
/// I Live Tools Acl Hit Count
/// </summary>
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
	Task<LiveToolsAclHitCountPostResponse> CreateDeviceLiveToolsAclHitCountAsync(
		string serial,
		[Body] LiveToolsAclHitCountCreate request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Return an ACL hit count live tool job.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="id"></param>
	/// <param name="serial"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getDeviceLiveToolsAclHitCount")]
	[Get("/devices/{serial}/liveTools/aclHitCount/{id}")]
	Task<LiveToolsAclHitCountGetResponse> GetDeviceLiveToolsAclHitCountAsync(
		string id,
		string serial,
		CancellationToken cancellationToken = default
	);
}
