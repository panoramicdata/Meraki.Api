namespace Meraki.Api.Sections.General.Organizations;

/// <summary>
/// Provides access to organizations vpn API endpoints
/// </summary>
public class OrganizationsVpnSection
{
	/// <summary>
	/// Gets the site to site
	/// </summary>

	public OrganizationsVpnSiteToSiteSection SiteToSite { get; internal set; } = new();
}
