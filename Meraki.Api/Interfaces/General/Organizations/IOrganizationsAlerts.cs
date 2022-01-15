namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrganizationsAlerts
{
	/// <summary>
	/// List all organization-wide alert configurations
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[ApiOperationId("getOrganizationAlertsProfiles")]
	[Get("/organizations/{organizationId}/alerts/profiles")]
	Task<List<OrganizationAlert>> GetOrganizationAlertsProfilesAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default);
}
