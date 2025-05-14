namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsCertificates
{
	/// <summary>
	/// Gets all or specific certificates for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationCertificates")]
	[Get("/organizations/{organizationId}/certificates")]
	Task<OrganizationCertificates> GetOrganizationCertificatesAsync(string organizationId, CancellationToken cancellationToken = default);
}
