namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsWirelessCertificatesOpenRoaming
{
	/// <summary>
	/// Query for details on the organization's OpenRoaming Certificate Authority certificate (CAs).
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessCertificatesOpenRoamingCertificateAuthority")]
	[Get("/organizations/{organizationId}/wireless/certificates/openRoaming/certificateAuthority")]
	Task<OrganizationWirelessCertificatesOpenRoamingCertificateAuthority> GetOrganizationWirelessCertificatesOpenRoamingCertificateAuthorityAsync(
		string organizationId,
		CancellationToken cancellationToken = default);
}
