namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations vpn site to site API endpoints
/// </summary>
public class OrganizationsVpnSiteToSiteSection
{
	/// <summary>
	/// Get the list of available IPsec SLA policies for an organization
	/// </summary>

	public IOrganizationsVpnSiteToSiteIpsec Ipsec { get; set; } = null!;
}
