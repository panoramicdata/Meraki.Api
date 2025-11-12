namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations integrations API endpoints
/// </summary>
public class OrganizationsIntegrationsSection
{
	/// <summary>
	/// Returns the networks in the organization that have XDR enabled
	/// </summary>

	public IOrganizationsIntegrationsXdr Xdr { get; internal set; } = null!;
}
