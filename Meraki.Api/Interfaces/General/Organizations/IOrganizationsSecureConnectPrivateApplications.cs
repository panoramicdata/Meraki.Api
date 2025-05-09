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
}
