namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations wireless certificates API endpoints
/// </summary>
public class OrganizationsWirelessCertificatesSection
{
	/// <summary>
	/// Query for details on the organization's OpenRoaming Certificate Authority certificate (CAs).
	/// </summary>

	public IOrganizationsWirelessCertificatesOpenRoaming OpenRoaming { get; internal set; } = null!;
}
