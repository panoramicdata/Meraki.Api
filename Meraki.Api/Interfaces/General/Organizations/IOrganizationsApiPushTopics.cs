namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Interface for Push API Topics
/// </summary>
public interface IOrganizationsApiPushTopics
{
	/// <summary>
	/// List available Push API topics for an organization
	/// GET /organizations/{organizationId}/api/push/topics
	/// </summary>
	/// <param name="organizationId">The organization ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[Get("/organizations/{organizationId}/api/push/topics")]
	Task<List<PushTopic>> GetOrganizationApiPushTopicsAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
