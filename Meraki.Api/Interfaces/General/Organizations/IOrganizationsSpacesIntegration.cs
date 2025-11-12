namespace Meraki.Api.Interfaces.General.Organizations;

/// <summary>
/// I Organizations Spaces Integration
/// </summary>
public interface IOrganizationsSpacesIntegration
{
	/// <summary>
	/// Get the status of the Spaces integration in Meraki
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("getOrganizationSpacesIntegrateStatus")]
	[Get("/organizations/{organizationId}/spaces/integrate/status")]
	Task<OrganizationSpacesIntegrateStatus> GetOrganizationSpacesIntegrateStatusAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Remove the Spaces integration from Meraki
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">Organization ID</param>
	/// <param name="cancellationToken">The cancellation token</param>
	[ApiOperationId("removeOrganizationSpacesIntegration")]
	[Post("/organizations/{organizationId}/spaces/integration/remove")]
	Task<OrganizationSpacesIntegrationActionResponse> RemoveOrganizationSpacesIntegrationAsync(
		string organizationId, 
		CancellationToken cancellationToken = default);
}
