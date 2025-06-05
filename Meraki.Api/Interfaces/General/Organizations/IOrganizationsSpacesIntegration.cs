namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsSpacesIntegration
{
	/// <summary>
	/// Remove the Spaces integration from Meraki
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationSpacesIntegrationRemove")]
	[Delete("/organizations/{organizationId}/spaces/integration/remove")]
	Task<OrganizationSpacesIntegrationActionResponse> DeleteOrganizationSpacesIntegrationRemoveAsync(string organizationId, CancellationToken cancellationToken = default);

	/// <summary>
	/// Remove the Spaces integration from Meraki
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("removeOrganizationSpacesIntegration")]
	[Post("/organizations/{organizationId}/spaces/integration/remove")]
	Task<OrganizationSpacesIntegrationActionResponse> RemoveOrganizationSpacesIntegrationAsync(string organizationId, CancellationToken cancellationToken = default);
}
