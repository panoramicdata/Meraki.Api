namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations wireless radsec API endpoints
/// </summary>
public class OrganizationsWirelessRadsecSection
{
	/// <summary>
	/// Query for details on the organization's RADSEC device Certificate Authority certificates (CAs). The primary CA signs all the certificates that devices present when establishing a secure connection to RADIUS servers via RADSEC protocol. This API returns an array of the status of all of the CAs as well as their contents, if they've been generated. An organization will have at most one CA unless the CA is being rotated.
	/// </summary>

	public IOrganizationsWirelessRadsecCertificates Certificates { get; internal set; } = null!;
}
