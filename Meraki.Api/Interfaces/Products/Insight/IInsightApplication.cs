namespace Meraki.Api.Interfaces.Products.Insight;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IInsightApplication
{
	/// <summary>
	/// List all Insight tracked applications
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/insight/applications")]
	Task<List<InsightApplication>> GetOrganizationInsightApplicationsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);
}
