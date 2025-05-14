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

	/// <summary>
	/// Update a certificate's description for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="certificateId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationCertificate")]
	[Put("/organizations/{organizationId}/certificates/{certificateId}")]
	Task<OrganizationCertificates> UpdateOrganizationCertificateAsync(string organizationId, string certificateId, OrganizationCertificatesUpdateRequest request, CancellationToken cancellationToken = default);

	/// <summary>
	/// Delete a certificate for an organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="certificateId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("deleteOrganizationCertificate")]
	[Delete("/organizations/{organizationId}/certificates/{certificateId}")]
	Task DeleteOrganizationCertificateAsync(string organizationId, string certificateId, CancellationToken cancellationToken = default);
}
