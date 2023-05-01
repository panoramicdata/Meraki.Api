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
	Task<List<OrganizationAlertProfile>> GetOrganizationAlertsProfilesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create an organization-wide alert configuration
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="createRequest">Body</param>
	[ApiOperationId("createOrganizationAlertsProfile")]
	[Post("/organizations/{organizationId}/alerts/profiles")]
	Task<OrganizationAlertProfile> CreateOrganizationAlertsProfileAsync(
		string organizationId,
		[Body] OrganizationAlertProfileCreateRequest createRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Update an organization-wide alert config
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="alertConfigId">The alert config id</param>
	/// <param name="updateRequest">Body</param>
	[ApiOperationId("updateOrganizationAlertsProfile")]
	[Put("/organizations/{organizationId}/alerts/profiles/{alertConfigId}")]
	Task<OrganizationAlertProfile> UpdateOrganizationAlertsProfileAsync(
		string organizationId,
		string alertConfigId,
		[Body] OrganizationAlertProfileUpdateRequest updateRequest,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Removes an organization-wide alert config
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="alertConfigId">The alert config id</param>
	[ApiOperationId("deleteOrganizationAlertsProfile")]
	[Delete("/organizations/{organizationId}/alerts/profiles/{alertConfigId}")]
	Task DeleteOrganizationAlertsProfileAsync(
		string organizationId,
		string alertConfigId,
		CancellationToken cancellationToken = default
		);
}