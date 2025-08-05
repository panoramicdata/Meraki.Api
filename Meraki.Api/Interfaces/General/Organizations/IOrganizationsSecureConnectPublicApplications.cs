namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsSecureConnectPublicApplications
{
	/// <summary>
	/// Provides a list of public applications for an Organization.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationSecureConnectPublicApplications")]
	[Get("/organizations/{organizationId}/secureConnect/publicApplications")]
	Task<OrganizationSecureConnectPublicApplications> GetOrganizationSecureConnectPublicApplicationsAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);
}
