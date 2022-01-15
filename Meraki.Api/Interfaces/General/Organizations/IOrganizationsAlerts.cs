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

	/// <summary>
	/// Create an organization-wide alert configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createOrganizationAlertsProfile">Body</param>
	[ApiOperationId("createOrganizationAlertsProfile")]
	[Post("/organizations/{organizationId}/alerts/profiles")]
	Task<OrganizationAlert> CreateOrganizationAlertsProfileAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] OrganizationAlert createOrganizationAlertsProfile,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update an organization-wide alert config
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="alertConfigId">The alert config id</param>
	/// <param name="updateOrganizationAlertsProfile">Body</param>
	[ApiOperationId("updateOrganizationAlertsProfile")]
	[Put("/organizations/{organizationId}/alerts/profiles/{alertConfigId}")]
	Task<OrganizationAlert> UpdateOrganizationAlertsProfileAsync(
		[AliasAs("organizationId")] string organizationId,
		[AliasAs("alertConfigId")] string alertConfigId,
		[Body] OrganizationAlert updateOrganizationAlertsProfile,
		CancellationToken cancellationToken = default);
}