namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Webhooks Callbacks
/// </summary>
public interface IOrganizationsWebhooksCallbacks

{
	/// <summary>
	/// Return the status of an API callback
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="callbackId">The id of the callback</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/webhooks/callbacks/statuses/{callbackId}")]
	Task<CallbackStatus> GetOrganizationWebhooksCallbacksStatusAsync(
		string organizationId,
		string callbackId,
		CancellationToken cancellationToken = default
		);
}
