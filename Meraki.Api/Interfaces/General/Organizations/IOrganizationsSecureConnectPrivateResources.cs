namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSecureConnectPrivateResources
{
	/// <summary>
	/// Provides a list of private resources for an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectPrivateResources")]
	[Get("/organizations/{organizationId}/secureConnect/privateResources")]
	Task<SecureConnectPrivateResourcesResponse> GetOrganizationSecureConnectPrivateResourcesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Adds a new private resource to the organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationSecureConnectPrivateResource")]
	[Post("/organizations/{organizationId}/secureConnect/privateResources")]
	Task<SecureConnectPrivateResourcesDataItem> CreateOrganizationSecureConnectPrivateResourceAsync(
		string organizationId,
		SecureConnectPrivateResourcesCreateRequest request,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Updates a specific private resource group.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationSecureConnectPrivateResource")]
	[Put("/organizations/{organizationId}/secureConnect/privateResources/{id}")]
	Task<SecureConnectPrivateResourcesDataItemUpdateResponse> UpdateOrganizationSecureConnectPrivateResourceAsync(string organizationId,
		SecureConnectPrivateResourcesUpdateRequest request,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Deletes a specific private resource. If this is the last resource in a resource group you must remove it from that resource group before deleting.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationSecureConnectPrivateResource")]
	[Delete("/organizations/{organizationId}/secureConnect/privateResources/{id}")]
	Task DeleteOrganizationSecureConnectPrivateResourceAsync(string organizationId,
		string id,
		CancellationToken cancellationToken = default);
}
