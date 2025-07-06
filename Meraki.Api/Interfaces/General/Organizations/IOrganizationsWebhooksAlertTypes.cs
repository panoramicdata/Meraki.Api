namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsWebhooksAlertTypes
{
	/// <summary>
	/// Return a list of alert types to be used with managing webhook alerts
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="productType">The product type (Optional)</param>
	/// <param name="cancellationToken"></param>
	[Get("/organizations/{organizationId}/webhooks/alertTypes")]
	Task<List<WebhookAlertType>> GetOrganizationWebhooksAlertTypesAsync(
		string organizationId,
		string? productType = null,
		CancellationToken cancellationToken = default
		);
}
