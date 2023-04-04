namespace Meraki.Api.Interfaces.Products.Sm;

public interface ISmDevicesBypassActivationLockAttempts
{
	/// <summary>
	/// Bypass activation lock attempt
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="createNetworkSmBypassActivationLockAttempt">Body for bypassing a lock attempt</param>
	[Post("/networks/{networkId}/sm/bypassActivationLockAttempts")]
	Task<SmBypassActivationLockAttempt> CreateNetworkSmBypassActivationLockAttemptAsync(
		string networkId,
		[Body] SmBypassActivationLockAttemptCreationRequest createNetworkSmBypassActivationLockAttempt,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Bypass activation lock attempt status
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="attemptId">The attempt id</param>
	[Get("/networks/{networkId}/sm/bypassActivationLockAttempts/{attemptId}")]
	Task<SmBypassActivationLockAttempt> GetNetworkSmBypassActivationLockAttemptAsync(
		string networkId,
		string attemptId,
		CancellationToken cancellationToken = default
		);
}
