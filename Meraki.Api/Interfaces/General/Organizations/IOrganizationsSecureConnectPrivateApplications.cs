namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSecureConnectPrivateApplications
{
	/// <summary>
	/// Provides a list of private applications for an Organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectPrivateApplications")]
	[Get("/organizations/{organizationId}/secureConnect/privateApplications")]
	Task<SecureConnectPrivateApplications> GetOrganizationSecureConnectPrivateApplicationsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Adds a new private application to the Organization. A maximum of 300 private applications are allowed for an organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="secureConnectPrivateApplication"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationSecureConnectPrivateApplication")]
	[Post("/organizations/{organizationId}/secureConnect/privateApplications")]
	Task<SecureConnectPrivateApplication> CreateOrganizationSecureConnectPrivateApplicationAsync(
		string organizationId,
		[Body] SecureConnectPrivateApplicationCreateRequest secureConnectPrivateApplication,
		CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Return the details of a specific private application
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="id"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectPrivateApplication")]
	[Get("/organizations/{organizationId}/secureConnect/privateApplications/{id}")]
	Task<SecureConnectPrivateApplication> GetOrganizationSecureConnectPrivateApplicationAsync(string organizationId, string id, CancellationToken cancellationToken = default);

	/// <summary>
	/// Updates a specific private application. Updates can be made to Name, Description, Destinations, App Protocol, SNI and SSL verification. Application groups can be added or removed.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="id"></param>
	/// <param name="secureConnectPrivateApplication"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationSecureConnectPrivateApplication")]
	[Put("/organizations/{organizationId}/secureConnect/privateApplications/{id}")]
	Task<SecureConnectPrivateApplication> UpdateOrganizationSecureConnectPrivateApplicationAsync(string organizationId, string id, [Body] SecureConnectPrivateApplicationUpdateRequest secureConnectPrivateApplication, CancellationToken cancellationToken = default
		);

	/// <summary>
	/// Deletes a specific private application. Delink the application from any application groups before deleting the app. Cascade delete application group if this is the only application in the group.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="id"></param>
	/// <param name="secureConnectPrivateApplicationDeleteRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationSecureConnectPrivateApplication")]
	[Delete("/organizations/{organizationId}/secureConnect/privateApplications/{id}")]
	Task DeleteOrganizationSecureConnectPrivateApplicationAsync(string organizationId, string id, [Body] SecureConnectPrivateApplicationDeleteRequest secureConnectPrivateApplicationDeleteRequest, CancellationToken cancellationToken = default
		);
}
