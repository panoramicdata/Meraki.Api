namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsWebhooksCallbacks

{
	/// <summary>
	/// Return the status of an API callback
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="callbackId">The id of the callback</param>
	[Get("/organizations/{organizationId}/webhooks/callbacks/statuses/{callbackId}")]
	Task<CallbackStatus> GetOrganizationWebhooksCallbacksStatusAsync(
		string organizationId,
		string callbackId,
		CancellationToken cancellationToken = default
		);
}
