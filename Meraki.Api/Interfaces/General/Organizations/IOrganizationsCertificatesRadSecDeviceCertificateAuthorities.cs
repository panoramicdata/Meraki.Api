namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsCertificatesRadSecDeviceCertificateAuthorities
{
	/// <summary>
	/// Query for details on the organization's RADSEC device Certificate Authority certificates (CAs). The primary CA signs all the certificates that devices present when establishing a secure connection to RADIUS servers via RADSEC protocol. This API returns an array of the status of all of the CAs as well as their contents, if they've been generated. An organization will have at most one CA unless the CA is being rotated.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationCertificatesRadSecDeviceCertificateAuthorities")]
	[Get("/organizations/{organizationId}/certificates/radSec/deviceCertificateAuthorities")]
	Task<OrganizationCertificatesRadSecDeviceCertificateAuthorities> GetOrganizationCertificatesRadSecDeviceCertificateAuthoritiesAsync(
		string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Create an organization's RADSEC device Certificate Authority (CA). Call this endpoint when turning on RADSEC in the firmware for the first time. Calling this endpoint starts an asynchronous process to generate the CA; call GET afterwards to retrieve the contents of the CA. Note this CA is generated and controlled by Meraki. Subsequent calls will not generate a new CA.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("createOrganizationCertificatesRadSecDeviceCertificateAuthority")]
	[Post("/organizations/{organizationId}/certificates/radSec/deviceCertificateAuthorities")]
	Task<OrganizationCertificatesRadSecDeviceCertificateAuthorities> CreateOrganizationCertificatesRadSecDeviceCertificateAuthorityAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
