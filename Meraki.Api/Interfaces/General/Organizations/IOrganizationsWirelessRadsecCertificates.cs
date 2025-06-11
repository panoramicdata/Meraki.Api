namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsWirelessRadsecCertificates
{
	/// <summary>
	/// Query for details on the organization's RADSEC device Certificate Authority certificates (CAs). The primary CA signs all the certificates that devices present when establishing a secure connection to RADIUS servers via RADSEC protocol. This API returns an array of the status of all of the CAs as well as their contents, if they've been generated. An organization will have at most one CA unless the CA is being rotated.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("getOrganizationWirelessDevicesRadsecCertificatesAuthorities")]
	[Get("/organizations/{organizationId}/wireless/devices/radsec/certificates/authorities")]
	Task<OrganizationWirelessDevicesRadsecCertificatesAuthorities> GetOrganizationWirelessDevicesRadsecCertificatesAuthoritiesAsync(
		string organizationId,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Update an organization's RADSEC device Certificate Authority (CA) state. Note this CA is generated and controlled by Meraki. Call this endpoint to update the state to "trusted", at which point Meraki will generate device certificates. "trusted" means the CA is placed on your RADSEC server(s) and devices establishing a secure connection using certs signed by this CA will pass verification.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="request"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationWirelessDevicesRadsecCertificatesAuthorities")]
	[Put("/organizations/{organizationId}/wireless/devices/radsec/certificates/authorities")]
	Task<OrganizationWirelessDevicesRadsecCertificatesAuthority> UpdateOrganizationWirelessDevicesRadsecCertificatesAuthoritiesAsync(
		string organizationId,
		[Body] OrganizationWirelessDevicesRadsecCertificatesAuthorityUpdateRequest request,
		CancellationToken cancellationToken = default
	);
}
